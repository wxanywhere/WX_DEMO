using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.ViewModel
{
    public class RequestCloseEventArgs : EventArgs
    {
        public RequestCloseEventArgs(object data)
            : base()
        {
            Data = data;
        }

        public object Data { get; set; }
    }
}
