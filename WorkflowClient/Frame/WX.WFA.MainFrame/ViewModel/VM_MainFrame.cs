using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using WX.WFA.TempData;
using WX.WFA.ViewCommon;
using WX.WFA.ViewModel;
using WX.WFA.VO;

namespace WX.WFA.MainFrame
{
    public class VM_MainFrame : ViewModelBase
    {
        private Dictionary<string, Type> _FunctionTypeDictionary = new Dictionary<string, Type>();
        private object _TemObj = null;
        private Assembly[] _TemAssemblies = null;
        private Assembly _ExistAssembly = null;
        private ViewModelBase _TempVM = null;
        private ViewModelBase _ExistVM = null;
        private Type _ExistType = null;
        private FunctionInfo _ExistFunction = null;
        private FunctionInfo[] _Functions = null;
        private VO_WF_CZYB _D_CZY;

        public VM_MainFrame(FunctionInfo[] functions, VO_WF_CZYB vo_WF_CZYB)
        {
            this.Title = "工作流管理";
            _Functions = functions;
            _D_CZY = vo_WF_CZYB;
        } 

        public VO_WF_CZYB D_CZY
        {
          get
          {
            return _D_CZY;
          }
          set
          {
            if (_D_CZY != value)
            {
              _D_CZY = value;
              OnPropertyChanged("D_CZY");
            }
          }
        }

        public override void InitializeSpecific()
        {
            this.MainWindow.Closing += (o, e) =>
            {
                if (MessageX.ShowConfirm("系统将退出，是否继续？") == MessageBoxResult.Yes)
                {
                    Application.Current.Shutdown();
                }
                else
                {
                    e.Cancel = true;
                }
            };
        }

        public Visibility this[string assemblyName]
        {
            get 
            {
                if (_Functions.FirstOrDefault(a => a.AssemblyName.Equals(assemblyName)) != null)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }
        }

        private ObservableCollection<ViewModelBase> _Workspaces;
        public ObservableCollection<ViewModelBase> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<ViewModelBase>();
                    _Workspaces.CollectionChanged += (o, e) =>
                    {
                        if (e.NewItems != null && e.NewItems.Count > 0)
                        {
                            foreach (var item in e.NewItems.Cast<ViewModelBase>())
                            {
                                item.RequestClose += (ox, ex) =>
                                {
                                    _Workspaces.Remove(item);
                                };
                            }
                        }
                    };
                }
                return _Workspaces;
            }
        }

        public override void OpenFunction(string AssemblyName)
        {
            _ExistFunction = _Functions.FirstOrDefault(a => a.FunctionName.ToLowerInvariant().Equals(AssemblyName.ToLowerInvariant()));
            if (_ExistFunction == null)
            {
                return;
            }

            _ExistVM = this.Workspaces.FirstOrDefault(vm => vm.GetType().Name.ToLowerInvariant().Equals(_ExistFunction.EntryTypeName.ToLowerInvariant()));
            if (_ExistVM != null)
            {
                SetActiveWorkspace(_ExistVM);
                return;
            }

            if (!_FunctionTypeDictionary.TryGetValue(_ExistFunction.EntryTypeName, out _ExistType))
            {
                try
                {
                    _TemObj = Application.LoadComponent(new Uri(_ExistFunction.AssemblyUri, UriKind.Relative));
                    Application.Current.Resources.MergedDictionaries.Add(_TemObj as ResourceDictionary);
                }
                catch
                {
                    return;
                }
                if (_TemObj != null && _TemObj is ResourceDictionary)
                {
                    _TemAssemblies = AppDomain.CurrentDomain.GetAssemblies();
                    if (_TemAssemblies != null)
                    {
                        _ExistAssembly = _TemAssemblies.FirstOrDefault(a => a.GetName().Name.ToLowerInvariant() == _ExistFunction.AssemblyName.ToLowerInvariant());
                        if (_ExistAssembly != null)
                        {
                            _ExistType = _ExistAssembly.GetTypes().FirstOrDefault(a => a.Name.ToLowerInvariant().Equals(_ExistFunction.EntryTypeName.ToLowerInvariant()));
                        }
                    }
                }
            }

            if (_ExistType != null)
            {
                _TemObj = Activator.CreateInstance(_ExistType);
                if (_TemObj != null && _TemObj is ViewModelBase)
                {
                    _TempVM = (_TemObj as ViewModelBase);
                    _TempVM.Title = _ExistFunction.FunctionTitle;
                    _TempVM.InitializeSpecific();
                    if (!_FunctionTypeDictionary.ContainsKey(_ExistFunction.EntryTypeName))
                    {
                        _FunctionTypeDictionary.Add(_ExistFunction.EntryTypeName, _ExistType);
                    }
                    Workspaces.Add(_TempVM);
                    SetActiveWorkspace(_TempVM);
                }
            }

        }

        private void SetActiveWorkspace(ViewModelBase workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }

        private ICommand _CMD_Test;
        public ICommand CMD_Test
        {
            get
            {
                if (_CMD_Test == null)
                {
                    _CMD_Test = new RelayCommand(a =>
                    {

                    });

                }
                return this._CMD_Test;
            }
        }

        private ICommand _CMD_Open;
        public ICommand CMD_Open
        {
            get
            {
                if (_CMD_Open == null)
                {
                    _CMD_Open = new RelayCommand(e =>
                    {
                        if (e != null)
                        {
                            OpenFunction(e.ToString());
                        }
                    });
                }

                return _CMD_Open;
            }
        }
    }
}
