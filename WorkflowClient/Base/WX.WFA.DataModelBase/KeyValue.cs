using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.DataModelBase
{
    public class KeyValue<T, K> : VOBase where T:IComparable where K:IComparable
    {
        public KeyValue()
        {

        }

        public KeyValue(T key,K value)
        {
            _Key = key;
            _Value = value;
        }

        private T _Key;
        public T Key
        {
            get
            {
                return _Key;
            }
            set
            {
                if(!_Key.Equals(value))
                {
                    _Key = value;
                    OnPropertyChanged("Key");
                }
            }
        }

        private K _Value;
        public K Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (!_Value.Equals(value))
                {
                    _Value = value;
                    OnPropertyChanged("Value");
                }
            }
        }
    }
}
