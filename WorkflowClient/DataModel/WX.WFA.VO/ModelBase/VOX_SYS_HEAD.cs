using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.WFA.DataModelBase;

namespace WX.WFA.VO
{
    public partial class VOX_SYS_HEAD : VOBase
    {
        public const System.String EntityName = "VOX_SYS_HEAD";
        public VOX_SYS_HEAD()
        {
            FieldsSumLength = 37;
        }
        private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
        {
            new VOFieldInfo(0,"CZDM", typeof(Decimal), false, false,5, 0, 4,0),
            new VOFieldInfo(1,"CZYH", typeof(Decimal), false, false,7, 0, 6,0),
            new VOFieldInfo(2,"JGBM", typeof(String), false, false, 5, 0, 0,""),
            new VOFieldInfo(3,"WKDZ", typeof(String), false, false,20, 0, 0,"")
        };

        public override VOFieldInfo[] VOFieldInfos
        {
            get
            {
                return _VOFieldInfos;
            }
        }

        public string CZDM
        {
            get
            {
                return GetValue<string>(VOE_SYS_HEAD.CZDM);
            }
            set
            {
                SetValue<string>(VOE_SYS_HEAD.CZDM, value);
            }
        }

        public string CZYH
        {
            get
            {
                return GetValue<string>(VOE_SYS_HEAD.CZYH);
            }
            set
            {
                SetValue<string>(VOE_SYS_HEAD.CZYH, value);
            }
        }

        public string JGBM
        {
            get
            {
                return GetValue<string>(VOE_SYS_HEAD.JGBM);
            }
            set
            {
                SetValue<string>(VOE_SYS_HEAD.JGBM, value);
            }
        }

        public string WKDZ
        {
            get
            {
                return GetValue<string>(VOE_SYS_HEAD.WKDZ);
            }
            set
            {
                SetValue<string>(VOE_SYS_HEAD.WKDZ, value);
            }
        }

        public enum VOE_SYS_HEAD : int
        {
            /// <summary>
            /// 操作代码：0
            /// </summary>
            CZDM,

            /// <summary>
            /// 操作员号
            /// </summary>
            CZYH,

            /// <summary>
            /// 见SYS
            /// </summary>
            JGBM,

            /// <summary>
            /// 网卡地址：终端网卡地址
            /// </summary>
            WKDZ,
        }

    }
}
