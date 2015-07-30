using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.DataModelBase
{
    public class VOBase : INotifyPropertyChanged, ICloneable 
    {
        private Dictionary<string,object> _PVDic=new Dictionary<string,object>();
        private bool _DirtyDetectFlag=false;

        public VOBase()
        {
            _IsDirty = false;
            _IsChecked = false;
        }

        public void StartDirtyDetect()
        {
            _DirtyDetectFlag = true;
            _IsDirty = false;
            _PVDic.Clear();
            foreach (var property in this.GetType().GetProperties())
            {
                _PVDic.Add(property.Name, property.GetValue(this));
            }
        }

        public void StopDirtyDetect()
        {
            _DirtyDetectFlag = false;
            _IsDirty = false;
            _PVDic.Clear();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            this.VerifyPropertyName(propertyName);

            if (_DirtyDetectFlag && !IsDirty && propertyName != "IsDirty" && _PVDic.ContainsKey(propertyName) && _PVDic[propertyName] != this.GetType().GetProperty(propertyName).GetValue(this))
            {
                IsDirty = true;
            }

            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

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

        private bool _IsDirty;
        public bool IsDirty
        {
            get{
                return _IsDirty;
            }
            set{
                if (_IsDirty != value)
                {
                    _IsDirty = value;
                    OnPropertyChanged("IsDirty");
                    if (!value)
                    {
                        _PVDic.Clear();
                        foreach (var property in this.GetType().GetProperties())
                        {
                            _PVDic.Add(property.Name, property.GetValue(this));
                        }
                    }
                }
            }
        }

        private bool _IsChecked;
        public bool IsChecked
        {
            get
            {
                return _IsChecked;
            }
            set
            {
                if (_IsChecked!=value)
                {
                    _IsChecked = value;
                    OnPropertyChanged("IsChecked");
                }
            }
        }

        private EditType EditType { get; set; }


        object ICloneable.Clone()
        {
            return this.MemberwiseClone(); 
        }

        public T Clone<T>() where T:VOBase
        {
            return (this as ICloneable).Clone() as T;
        }
    }
}
