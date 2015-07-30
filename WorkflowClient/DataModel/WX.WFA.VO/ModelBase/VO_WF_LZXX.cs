
using System;
using WX.WFA.DataModelBase;

namespace WX.WFA.VO
{
    public partial class VO_WF_LZXX : VOBase
    {
        public const System.String EntityName = "VO_WF_LZXX";
        public VO_WF_LZXX()
        {
            FieldsSumLength = 526;
        }
        private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "SLGUID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "HDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(2, "YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(3, "ZYID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(4, "QXHDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(5, "QX_YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(6, "HXHDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(7, "HX_YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(8, "ZYZT", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(9, "ZLC_GUID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(10, "JRRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(11, "JRSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(12, "JBID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(13, "LZSXW", typeof(String), false, false, 256, 0, 0, ""),
              new VOFieldInfo(14, "LCRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(15, "LCSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(16, "JZRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(17, "JZSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(18, "SXWID", typeof(String), false, false, 40, 0, 0, "")
          };

        public override VOFieldInfo[] VOFieldInfos
        {
            get
            {
                return _VOFieldInfos;
            }
        }

        public String SLGUID
        {
            get
            {
                return GetValue<String>(VOE_WF_LZXX.SLGUID);
            }
            set
            {
                SetValue<String>(VOE_WF_LZXX.SLGUID, value);
            }
        }

        public Decimal HDID
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.HDID);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.HDID, value);
            }
        }

        public Decimal YWLSH
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.YWLSH);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.YWLSH, value);
            }
        }

        public Decimal ZYID
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.ZYID);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.ZYID, value);
            }
        }

        public Decimal QXHDID
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.QXHDID);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.QXHDID, value);
            }
        }

        public Decimal QX_YWLSH
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.QX_YWLSH);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.QX_YWLSH, value);
            }
        }

        public Decimal HXHDID
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.HXHDID);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.HXHDID, value);
            }
        }

        public Decimal HX_YWLSH
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.HX_YWLSH);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.HX_YWLSH, value);
            }
        }

        public Decimal ZYZT
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.ZYZT);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.ZYZT, value);
            }
        }

        public String ZLC_GUID
        {
            get
            {
                return GetValue<String>(VOE_WF_LZXX.ZLC_GUID);
            }
            set
            {
                SetValue<String>(VOE_WF_LZXX.ZLC_GUID, value);
            }
        }

        public Decimal JRRQ
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.JRRQ);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.JRRQ, value);
            }
        }

        public Decimal JRSJ
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.JRSJ);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.JRSJ, value);
            }
        }

        public String JBID
        {
            get
            {
                return GetValue<String>(VOE_WF_LZXX.JBID);
            }
            set
            {
                SetValue<String>(VOE_WF_LZXX.JBID, value);
            }
        }

        public String LZSXW
        {
            get
            {
                return GetValue<String>(VOE_WF_LZXX.LZSXW);
            }
            set
            {
                SetValue<String>(VOE_WF_LZXX.LZSXW, value);
            }
        }

        public Decimal LCRQ
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.LCRQ);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.LCRQ, value);
            }
        }

        public Decimal LCSJ
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.LCSJ);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.LCSJ, value);
            }
        }

        public Decimal JZRQ
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.JZRQ);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.JZRQ, value);
            }
        }

        public Decimal JZSJ
        {
            get
            {
                return GetValue<Decimal>(VOE_WF_LZXX.JZSJ);
            }
            set
            {
                SetValue<Decimal>(VOE_WF_LZXX.JZSJ, value);
            }
        }

        public String SXWID
        {
            get
            {
                return GetValue<String>(VOE_WF_LZXX.SXWID);
            }
            set
            {
                SetValue<String>(VOE_WF_LZXX.SXWID, value);
            }
        }


        public enum VOE_WF_LZXX : int
        {
            SLGUID,
            HDID,
            YWLSH,
            ZYID,
            QXHDID,
            QX_YWLSH,
            HXHDID,
            HX_YWLSH,
            ZYZT,
            ZLC_GUID,
            JRRQ,
            JRSJ,
            JBID,
            LZSXW,
            LCRQ,
            LCSJ,
            JZRQ,
            JZSJ,
            SXWID,
        }
    }
}
