using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.MainFrame
{
    public class FunctionInfo
    {
        public Guid FunctrionID { get; set; }
        public string FunctionName { get; set; }
        public string FunctionTitle { get; set; }
        public string EntryTypeName { get; set; }
        public string AssemblyName { get; set; }
        public string AssemblyUri { get; set; }
        public bool DisabledFlag { get; set; }
    }
}
