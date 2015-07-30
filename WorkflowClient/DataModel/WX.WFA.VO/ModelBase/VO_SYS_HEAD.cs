using System;
using WX.WFA.DataModelBase;

namespace WX.WFA.VO
{
    public partial class VO_SYS_HEAD:VOBase
    {
        public const System.String EntityName = "VO_SYS_HEAD";
        public VO_SYS_HEAD()
        {
            FieldsSumLength = 98;
        }
        private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
        {
            new VOFieldInfo(0,"OP_CODE", typeof(Decimal), false, false,8, 0, 0,0),
            new VOFieldInfo(1,"TRANS_ID", typeof(String), false, false,48, 0, 6,""),
            new VOFieldInfo(2,"REQ_PROT_VER", typeof(String), false, false, 1, 0, 0,""),
            new VOFieldInfo(3,"REQ_TYPE", typeof(String), false, false,1, 0, 0,""),
            new VOFieldInfo(4,"CLT_SERV_REV", typeof(decimal), false, false,8, 0, 0,0),
            new VOFieldInfo(5,"DATE", typeof(Decimal), false, false,8, 0, 0,0),
            new VOFieldInfo(6,"TIME", typeof(Decimal), false, false,8, 0, 0,0),
            new VOFieldInfo(7,"REQ_LEN", typeof(Decimal), false, false,8, 0, 0,0),
            new VOFieldInfo(8,"REQ_CRC", typeof(Decimal), false, false,8, 0, 0,0)
        };

        public override VOFieldInfo[] VOFieldInfos
        {
            get
            {
                return _VOFieldInfos;
            }
        }

        public Decimal OP_CODE
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.OP_CODE);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.OP_CODE, value);
            }
        }

        public String TRANS_ID
        {
            get
            {
                return GetValue<String>(VOE_SYS_HEAD.TRANS_ID);
            }
            set
            {
                SetValue<String>(VOE_SYS_HEAD.TRANS_ID, value);
            }
        }

        public Decimal REQ_PROT_VER
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.REQ_PROT_VER);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.REQ_PROT_VER, value);
            }
        }

        public Decimal REQ_TYPE
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.REQ_TYPE);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.REQ_TYPE, value);
            }
        }

        public Decimal CLT_SERV_REV
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.CLT_SERV_REV);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.CLT_SERV_REV, value);
            }
        }

        public Decimal DATE
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.DATE);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.DATE, value);
            }
        }

        public Decimal TIME
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.TIME);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.TIME, value);
            }
        }

        public Decimal REQ_LEN
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.REQ_LEN);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.REQ_LEN, value);
            }
        }

        public Decimal REQ_CRC
        {
            get
            {
                return GetValue<Decimal>(VOE_SYS_HEAD.REQ_CRC);
            }
            set
            {
                SetValue<Decimal>(VOE_SYS_HEAD.REQ_CRC, value);
            }
        }

        public enum VOE_SYS_HEAD : int
        {
            OP_CODE,

            TRANS_ID,

            REQ_PROT_VER,

            REQ_TYPE,

            CLT_SERV_REV,

            DATE,

            TIME,

            REQ_LEN,

            REQ_CRC,
        }
    }
}
