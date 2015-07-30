using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.DataModelBase
{
    public class VOFieldInfo
    {
        private int _Position = 0;
        private string _Name=String.Empty;
        private Type _DataType=null;
        private bool _IsPrimaryKey = false;
        private bool _IsNullable = false;
        private int _MaxLength = 0;
        private byte _Scale = 0;
        private byte _Precision = 0;
        private object _Value = null;
        private string _ValueText = String.Empty;

        public VOFieldInfo(int position,string name, Type dataType, bool isPrimaryKey, bool isNullable, int maxLength, byte scale, byte precision,object value)
        {
            _Position = position;
            _Name = name;
            _DataType = dataType;
            _IsPrimaryKey = IsPrimaryKey;
            _IsNullable = isNullable;
            _MaxLength = maxLength;
            _Scale = scale;
            _Precision = precision;
            _Value = value;
            _ValueText = value!=null ? value.ToString():String.Empty;
        }

        public int Position
        {
            get
            {
                return _Position;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
        }

        public Type DataType
        {
            get
            {
                return _DataType;
            }
        }

        public bool IsPrimaryKey
        {
            get
            {
                return _IsPrimaryKey;
            }
        }

        public bool IsNullable
        {
            get
            {
                return _IsNullable;
            }
        }

        public int MaxLength
        {
            get
            {
                return _MaxLength;
            }
        }

        public byte Scale
        {
            get
            {
                return _Scale;
            }
        }

        public byte Precision
        {
            get
            {
                return _Precision;
            }
        }

        public string ValueText
        {
            get
            {
                return _ValueText;
            }
        }

        public object Value 
        {
            get
            {
                return _Value;
            }
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    _ValueText = value != null ? value.ToString() : String.Empty;
                }
            }
        }
    }
}
