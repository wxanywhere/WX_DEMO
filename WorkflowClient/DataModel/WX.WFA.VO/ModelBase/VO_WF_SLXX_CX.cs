
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_SLXX_CX:VOBase
      {
          public const System.String EntityName = "VO_WF_SLXX_CX";
          public VO_WF_SLXX_CX()
          {
              FieldsSumLength = 527;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "DYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "DYBB", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(2, "SLZT", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(3, "QDRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(4, "QDSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(5, "FLC_GUID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(6, "FLC_HDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(7, "FLC_YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(8, "GLC_GUID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(9, "GLC_HDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(10, "GLC_YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(11, "HDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(12, "HDLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(13, "HD_YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(14, "JRRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(15, "JRSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(16, "JZRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(17, "JZSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(18, "QXHDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(19, "QX_YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(20, "SLGUID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(21, "SLZID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(22, "ZLC_GUID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(23, "ZLC_HDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(24, "ZLC_YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(25, "DYMC", typeof(String), false, false, 100, 0, 0, ""),
              new VOFieldInfo(26, "HDMC", typeof(String), false, false, 40, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String DYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.DYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.DYID, value);
              }
          }
            
          public Decimal DYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.DYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.DYBB, value);
              }
          }
            
          public Decimal SLZT
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.SLZT);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.SLZT, value);
              }
          }
            
          public Decimal QDRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.QDRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.QDRQ, value);
              }
          }
            
          public Decimal QDSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.QDSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.QDSJ, value);
              }
          }
            
          public String FLC_GUID
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.FLC_GUID);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.FLC_GUID, value);
              }
          }
            
          public Decimal FLC_HDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.FLC_HDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.FLC_HDID, value);
              }
          }
            
          public Decimal FLC_YWLSH
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.FLC_YWLSH);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.FLC_YWLSH, value);
              }
          }
            
          public String GLC_GUID
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.GLC_GUID);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.GLC_GUID, value);
              }
          }
            
          public Decimal GLC_HDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.GLC_HDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.GLC_HDID, value);
              }
          }
            
          public Decimal GLC_YWLSH
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.GLC_YWLSH);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.GLC_YWLSH, value);
              }
          }
            
          public Decimal HDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.HDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.HDID, value);
              }
          }
            
          public Decimal HDLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.HDLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.HDLX, value);
              }
          }
            
          public Decimal HD_YWLSH
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.HD_YWLSH);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.HD_YWLSH, value);
              }
          }
            
          public Decimal JRRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.JRRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.JRRQ, value);
              }
          }
            
          public Decimal JRSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.JRSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.JRSJ, value);
              }
          }
            
          public Decimal JZRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.JZRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.JZRQ, value);
              }
          }
            
          public Decimal JZSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.JZSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.JZSJ, value);
              }
          }
            
          public Decimal QXHDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.QXHDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.QXHDID, value);
              }
          }
            
          public Decimal QX_YWLSH
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.QX_YWLSH);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.QX_YWLSH, value);
              }
          }
            
          public String SLGUID
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.SLGUID);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.SLGUID, value);
              }
          }
            
          public String SLZID
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.SLZID);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.SLZID, value);
              }
          }
            
          public String ZLC_GUID
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.ZLC_GUID);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.ZLC_GUID, value);
              }
          }
            
          public Decimal ZLC_HDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.ZLC_HDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.ZLC_HDID, value);
              }
          }
            
          public Decimal ZLC_YWLSH
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLXX_CX.ZLC_YWLSH);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLXX_CX.ZLC_YWLSH, value);
              }
          }
            
          public String DYMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.DYMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.DYMC, value);
              }
          }
            
          public String HDMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_SLXX_CX.HDMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_SLXX_CX.HDMC, value);
              }
          }
            

          public enum VOE_WF_SLXX_CX : int
          {
              DYID,
              DYBB,
              SLZT,
              QDRQ,
              QDSJ,
              FLC_GUID,
              FLC_HDID,
              FLC_YWLSH,
              GLC_GUID,
              GLC_HDID,
              GLC_YWLSH,
              HDID,
              HDLX,
              HD_YWLSH,
              JRRQ,
              JRSJ,
              JZRQ,
              JZSJ,
              QXHDID,
              QX_YWLSH,
              SLGUID,
              SLZID,
              ZLC_GUID,
              ZLC_HDID,
              ZLC_YWLSH,
              DYMC,
              HDMC,
          }
      }
  }
    