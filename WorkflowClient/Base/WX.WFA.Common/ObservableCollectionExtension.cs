using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.Common
{
    public static class ObservableCollectionExtension
    {
        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> data)
        {
            foreach (var x in data)
            {
                collection.Add(x);
            }
        }

        public static void Remove<T>(this ObservableCollection<T> collection, IEnumerable<T> data)
        {
            foreach (var x in data)
            {
                collection.Remove(x);
            }
        }
    }
}
