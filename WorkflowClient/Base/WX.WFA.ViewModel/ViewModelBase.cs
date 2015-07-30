using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using WX.WFA.DataModelBase;
using WX.WFA.ViewCommon;

namespace WX.WFA.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        private string _DirtyDetectBindingPath =String.Empty;
        private bool _CloseTipFlag = true;

        private VOBase _EditingData = null;
        private bool _IsEditingDataEnableValidation = false;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.VerifyPropertyName(propertyName);

            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public delegate void RequestCloseEventHandler(object sender, RequestCloseEventArgs e);
        public event RequestCloseEventHandler RequestClose;
        public void OnRequestClose(object data = null)
        {
            RequestCloseEventHandler handler = RequestClose;
            if(handler!=null)
            {
                var e = new RequestCloseEventArgs(data);
                handler(this,e);
            }
        }

        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        private bool _IsProcessed=true;
        public bool IsProcessed
        {
          get
          {
            return _IsProcessed;
          }
          set
          {
            if (_IsProcessed != value)
            {
              _IsProcessed = value;
              OnPropertyChanged("IsProcessed");
            }
          }
        }

        private Visibility _VisibilityCloseButton = Visibility.Visible;
        public Visibility VisibilityCloseButton
        {
            get
            {
                return _VisibilityCloseButton;
            }
            set
            {
                if (_VisibilityCloseButton != value)
                {
                    _VisibilityCloseButton = value;
                    OnPropertyChanged("VisibilityCloseButton");
                }
            }
        }

        private Window _MainWindow;
        public Window MainWindow
        {
            get
            {
                if (_MainWindow==null)
                {
                    _MainWindow = Application.Current.MainWindow;
                }
                return _MainWindow;
            }
            set
            {
                _MainWindow = value;
            }
        }
        

        private ViewModelBase _MainWindowModel;
        public ViewModelBase MainWindowModel
        {
            get
            {
                if (MainWindow != null && MainWindow.DataContext is ViewModelBase)
                {
                    _MainWindowModel = _MainWindow.DataContext as ViewModelBase;
                }
                return _MainWindowModel;
            }
        }

        private Window _HostWindow;
        public Window HostWindow
        {
            get {
                if (_HostWindow==null)
                {
                    _HostWindow = MainWindow;
                }
                return _HostWindow;
            }
            private set
            {
                _HostWindow = value;
            }
        }

        private ViewModelBase _ParentModel;
        public ViewModelBase ParentModel
        {
            get
            {
                return _ParentModel;
            }
            private set
            {
                _ParentModel = value;
            }
        }

        private ICommand _CloseCommand;
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                {
                    _CloseCommand = new RelayCommand(a =>
                    {
                        if (a == null)
                        {
                            _CloseTipFlag = true;
                        }
                        else
                        {
                            _CloseTipFlag = false;
                        }
                        if (HostWindow != null && !HostWindow.Equals(MainWindow))
                        {
                            HostWindow.Close();
                        }
                        this.OnRequestClose(a);
                    });
                }

                return _CloseCommand;
            }
        }

        public void ShowDialog(ViewModelBase dialogModel)
        {
            var v = new Window();
            var vm = dialogModel;
            Binding tagBinding = null;
            object windowTagValue=null;
            v.DataContext = vm;
            vm.HostWindow =v;
            if (!string.IsNullOrWhiteSpace(vm._DirtyDetectBindingPath) && vm._EditingData!=null)
            {
                tagBinding = new Binding(vm._DirtyDetectBindingPath);
                tagBinding.UpdateSourceTrigger=UpdateSourceTrigger.PropertyChanged;
                BindingOperations.SetBinding(v, Window.TagProperty, tagBinding);

                v.Closing += (o, e) =>
                {
                    if (vm._CloseTipFlag)
                    {
                        windowTagValue = v.GetValue(Window.TagProperty);
                        if (windowTagValue != null && windowTagValue is bool && (bool)windowTagValue)
                        {
                            if (MessageBox.Show("所编辑的数据将被取消，是否继续？", "操作提示", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
                            {
                                e.Cancel = true;
                            }
                            else
                            {
                                vm._EditingData.StopDirtyDetect();
                                vm._IsEditingDataEnableValidation = false;
                                vm._EditingData.IsEnableValidation = false;
                            }
                        }
                    }
                    else
                    {
                        vm._EditingData.StopDirtyDetect();
                        vm._IsEditingDataEnableValidation = false;
                        vm._EditingData.IsEnableValidation = false;
                    }

                };
            }
            vm.ParentModel = this;
            vm.MainWindow = this.MainWindow;
            BindingOperations.SetBinding(v,Window.ContentProperty,new Binding());
            BindingOperations.SetBinding(v,Window.TitleProperty,new Binding("Title"));
            v.SizeToContent=SizeToContent.WidthAndHeight;
            v.ResizeMode=ResizeMode.NoResize;
            v.Icon=this.MainWindow.Icon;
            v.Owner=this.HostWindow;
            v.WindowStartupLocation=WindowStartupLocation.CenterOwner;
            v.Loaded += (o, e) =>
            {
                if (vm._EditingData != null)
                {
                    vm._EditingData.IsEnableValidation = vm._IsEditingDataEnableValidation;
                }
            };
            v.ShowDialog();
        }

        public void StartEdit(VOBase dataEntity,string BindingPropertyName)
        {
            dataEntity.StartDirtyDetect();
            _EditingData = dataEntity;
            _DirtyDetectBindingPath = String.Format("{0}.{1}", BindingPropertyName, "IsDirty");
            _IsEditingDataEnableValidation = true;
        }

        public virtual void OpenFunction(string assemblyName)
        {
            this.MainWindowModel.OpenFunction(assemblyName);
        }

        public virtual void InitializeSpecific(){}

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                string msg = "Invalid property name: " + propertyName;

                if (this.ThrowOnInvalidPropertyName)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }
        protected virtual bool ThrowOnInvalidPropertyName { get; private set; }


        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        {
        }

#if DEBUG
        ~ViewModelBase()
        {
            string msg = string.Format("{0} ({1}) ({2}) Finalized", this.GetType().Name, this.Title, this.GetHashCode());
            System.Diagnostics.Debug.WriteLine(msg);
        }
#endif
    }

}