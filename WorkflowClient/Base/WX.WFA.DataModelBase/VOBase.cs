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
    public abstract class VOBase : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private Dictionary<string, object> _PVDic = null;
        private bool _DirtyDetectFlag = false;
        private int _position = 0;
        private bool _IsValidatedFinally = false;

        public VOBase()
        {
            _IsDirty = false;
            _IsChecked = false;
        }

        private static int _FieldsSumLength = 0;

        public int FieldsSumLength
        {
            get
            {
                return _FieldsSumLength;
            }
            protected set
            {
                _FieldsSumLength = value;
            }
        }

        public virtual VOFieldInfo[] VOFieldInfos { get; private set; }

        public VOFieldInfo GetFieldInfo(string fieldName)
        {
            if (VOFieldInfos != null)
            {
                return VOFieldInfos.FirstOrDefault(a => a.Name == fieldName);
            }

            return null;
        }

        protected void SetValue<T>(Enum fieldEnum, T value) //where T : IConvertible
        {
            _position = Convert.ToInt32(fieldEnum);
            if (!((T)Convert.ChangeType(VOFieldInfos[_position].Value, typeof(T))).Equals(value))
            {
                VOFieldInfos[_position].Value = value;
                OnPropertyChanged(fieldEnum.ToString());
            }
        }

        protected T GetValue<T>(Enum fieldEnum) //where T : IConvertible
        {
            _position = Convert.ToInt32(fieldEnum);
            return (T)Convert.ChangeType(VOFieldInfos[_position].Value, typeof(T));
        }

        public void StartDirtyDetect()
        {
            _DirtyDetectFlag = true;
            _IsDirty = false;
            _PVDic = new Dictionary<string, object>();
            foreach (var fieldInfo in VOFieldInfos)
            {
                _PVDic.Add(fieldInfo.Name, fieldInfo.Value);
            }
        }

        public void StopDirtyDetect()
        {
            _DirtyDetectFlag = false;
            _IsDirty = false;
            _PVDic.Clear();
            _PVDic = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            _IsValidatedFinally = false;
            this.VerifyPropertyName(propertyName);

            if (_DirtyDetectFlag && !IsDirty && propertyName != "IsDirty" && _PVDic.ContainsKey(propertyName) && _PVDic[propertyName] != GetFieldInfo(propertyName)) // this.GetType().GetProperty(propertyName).GetValue(this))
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
            get
            {
                return _IsDirty;
            }
            set
            {
                if (_IsDirty != value)
                {
                    _IsDirty = value;
                    OnPropertyChanged("IsDirty");
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
                if (_IsChecked != value)
                {
                    _IsChecked = value;
                    OnPropertyChanged("IsChecked");
                }
            }
        }

        public bool IsHeadPart { get; set; }

        private EditType EditType { get; set; }


        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public T Clone<T>() where T : VOBase
        {
            return (this as ICloneable).Clone() as T;
        }

        //-------------------------Validation

        private Dictionary<string, string> _Errors = null;

        public void UpdatreErrors(string propertyName, string message)
        {
            if (_IsEnableValidation)
            {
                if (message != null)
                {
                    if (!_Errors.ContainsKey(propertyName))
                    {
                        _Errors.Add(propertyName, message);
                    }
                    else
                    {
                        _Errors[propertyName] = message;
                    }
                }
                else
                {
                    _Errors.Remove(propertyName);
                }
            }
        }

        public string GetErrorMessage(string propertyName)
        {
            string message;
            _Errors.TryGetValue(propertyName, out message);
            return message;
        }

        private bool HasErrors
        {
            get
            {
                if (_Errors != null)
                {
                    return _Errors.Count != 0;
                }

                return false;
            }
        }


        public bool Validate()
        {
            if (!_IsValidatedFinally)
            {
                var x = (string)null;
                foreach (var fieldInfo in VOFieldInfos)
                {
                    x = this[fieldInfo.Name];
                }
                _IsValidatedFinally = true;
            }

            return !HasErrors;
        }

        public string Error
        {
            get { return this[null]; }
        }

        public virtual string this[string columnName]
        {
            get { return null; }
        }

        private bool _IsEnableValidation;
        public bool IsEnableValidation
        {
            get
            {
                return _IsEnableValidation;
            }
            set
            {
                if (_IsEnableValidation != value)
                {
                    _IsEnableValidation = value;
                    OnPropertyChanged("IsEnableValidation");
                    if (!value)
                    {
                        _Errors.Clear();
                        _Errors = null;
                    }
                    else
                    {
                        _Errors = new Dictionary<string, string>();
                    }
                }
            }
        }
    }
}
