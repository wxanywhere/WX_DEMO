using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.WFA.DataModelBase;

namespace WX.WFA.VO
{
    public partial class VO_SYS_SVC:VOBase
    {
        public const System.String EntityName = "VO_SYS_SVC";
        public VO_SYS_SVC()
        {
            FieldsSumLength = 104;
        }
        private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
        {
            new VOFieldInfo(0,"SVC_UUID", typeof(Decimal[]), false, false,32, 0, 0,new decimal[]{0m,0m,0,0}),
            new VOFieldInfo(1,"SVC_NAME", typeof(String), false, false,64, 0, 6,""),
            new VOFieldInfo(2,"PARM_DESC_ID", typeof(Decimal), false, false, 8, 0, 0,0)
        };

        public override VOFieldInfo[] VOFieldInfos
        {
            get
            {
                return _VOFieldInfos;
            }
        }

        public Decimal[] SVC_UUID
        {
            get
            {
                return GetValue<Decimal[]>(VOE_SYS_SVC.SVC_UUID);
            }
            set
            {
                SetValue<Decimal[]>(VOE_SYS_SVC.SVC_UUID, value);
            }
        }

        public String SVC_NAME
        {
            get
            {
                return GetValue<String>(VOE_SYS_SVC.SVC_NAME);
            }
            set
            {
                SetValue<String>(VOE_SYS_SVC.SVC_NAME, value);
            }
        }

        public Decimal PARM_DESC_ID
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_SVC.PARM_DESC_ID);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_SVC.PARM_DESC_ID, value);
            }
        }

        public enum VOE_SYS_SVC : int
        {
            SVC_UUID,

            SVC_NAME,

            PARM_DESC_ID,
        }
    }
}
