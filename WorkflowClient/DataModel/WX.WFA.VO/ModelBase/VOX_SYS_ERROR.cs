using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.WFA.DataModelBase;

namespace WX.WFA.VO
{
    public class VOX_SYS_ERROR:VOBase
    {
        public const System.String EntityName = "VOX_SYS_ERROR";
        public VOX_SYS_ERROR()
        {
            FieldsSumLength = 296;
        }
        private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
        {
            new VOFieldInfo(0, "TSXX", typeof(String), false, false, 200, 0, 0,""),
            new VOFieldInfo(0, "JGBM", typeof(String), false, false, 5, 0, 0,""),
            new VOFieldInfo(0, "QDRQ", typeof(Decimal), false, false, 9, 0, 8,0),
            new VOFieldInfo(0, "YWBH", typeof(String), false, false, 8, 0, 0,""),
            new VOFieldInfo(0, "YHBH", typeof(String), true, false, 10, 0, 0,""),
            new VOFieldInfo(0, "YCXM", typeof(String), false, false, 50, 0, 0,""),
            new VOFieldInfo(0, "CZYH", typeof(Decimal), false, false, 7, 0, 6,0),
            new VOFieldInfo(0, "SQLCODE", typeof(Decimal), false, false, 7, 0, 6,0)
        };

        public override VOFieldInfo[] VOFieldInfos
        {
            get
            {
                return _VOFieldInfos;
            }
        }

        public String TSXX
        {
            get
            {
                return GetValue<String>(VOXE_SYS_ERROR.TSXX);
            }
            set
            {
                SetValue<String>(VOXE_SYS_ERROR.TSXX, value);
            }
        }

        public String JGBM
        {
            get
            {
                return GetValue<String>(VOXE_SYS_ERROR.JGBM);
            }
            set
            {
                SetValue<String>(VOXE_SYS_ERROR.JGBM, value);
            }
        }

        public Decimal QDRQ
        {
            get
            {
                return GetValue<Decimal>(VOXE_SYS_ERROR.QDRQ);
            }
            set
            {
                SetValue<Decimal>(VOXE_SYS_ERROR.QDRQ, value);
            }
        }

        public String YWBH
        {
            get
            {
                return GetValue<String>(VOXE_SYS_ERROR.YWBH);
            }
            set
            {
                SetValue<String>(VOXE_SYS_ERROR.YWBH, value);
            }
        }

        public String YHBH
        {
            get
            {
                return GetValue<String>(VOXE_SYS_ERROR.YHBH);
            }
            set
            {
                SetValue<String>(VOXE_SYS_ERROR.YHBH, value);
            }
        }

        public String YCXM
        {
            get
            {
                return GetValue<String>(VOXE_SYS_ERROR.YCXM);
            }
            set
            {
                SetValue<String>(VOXE_SYS_ERROR.YCXM, value);
            }
        }

        public Decimal CZYH
        {
            get
            {
                return GetValue<Decimal>(VOXE_SYS_ERROR.CZYH);
            }
            set
            {
                SetValue<Decimal>(VOXE_SYS_ERROR.CZYH, value);
            }
        }

        public Decimal SQLCODE
        {
            get
            {
                return GetValue<Decimal>(VOXE_SYS_ERROR.SQLCODE);
            }
            set
            {
                SetValue<Decimal>(VOXE_SYS_ERROR.SQLCODE, value);
            }
        }

        public enum VOXE_SYS_ERROR : int
        {

            /// <summary>
            /// 提示信息(客户查看信息)
            /// </summary>
            TSXX,

            /// <summary>
            /// 机构编码
            /// </summary>
            JGBM,

            /// <summary>
            /// 启动日期
            /// </summary>
            QDRQ,

            /// <summary>
            /// 业务编号
            /// </summary>
            YWBH,

            /// <summary>
            /// 用户编号
            /// </summary>
            YHBH,

            /// <summary>
            /// 源程序名(文件名->行号)
            /// </summary>
            YCXM,

            /// <summary>
            /// 操作员号
            /// </summary>
            CZYH,

            /// <summary>
            /// SQL返回码
            /// </summary>
            SQLCODE,

        }
    }
}
