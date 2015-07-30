using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.WFA.DataModelBase;

namespace WX.WFA.VO
{
    public partial class VO_V_WF_SLYXXX : VOBase
    {
        public const System.String EntityName = "VO_V_WF_SLYXXX";
        public VO_V_WF_SLYXXX()
        {
            FieldsSumLength = 11;
        }
        private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "SLZT", typeof(string), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "SLSL", typeof(decimal), false, false, 9, 0, 0, 0)

          };

        public override VOFieldInfo[] VOFieldInfos
        {
            get
            {
                return _VOFieldInfos;
            }
        }

        public string SLZT
        {
            get
            {
                return GetValue<string>(VOE_V_WF_SLYXXX.SLZT);
            }
            set
            {
                SetValue<string>(VOE_V_WF_SLYXXX.SLZT, value);
            }
        }

        public decimal SLSL
        {
            get
            {
                return GetValue<decimal>(VOE_V_WF_SLYXXX.SLSL);
            }
            set
            {
                SetValue<decimal>(VOE_V_WF_SLYXXX.SLSL, value);
            }
        }


        public enum VOE_V_WF_SLYXXX : int
        {
            SLZT,
            SLSL,
        }
    }
}
