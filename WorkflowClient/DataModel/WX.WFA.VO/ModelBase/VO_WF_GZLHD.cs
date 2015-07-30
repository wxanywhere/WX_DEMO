
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_GZLHD:VOBase
      {
          public const System.String EntityName = "VO_WF_GZLHD";
          public VO_WF_GZLHD()
          {
              FieldsSumLength = 288;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "HDID", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(1, "DYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(2, "DYBB", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(3, "HDMC", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(4, "HDLX", typeof(Decimal), false, false, 3, 0, 0, 0),
              new VOFieldInfo(5, "JRLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(6, "LZLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(7, "X", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(8, "Y", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(9, "JRJBID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(10, "LZJBID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(11, "HDSX", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(12, "HDGQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(13, "CSTX", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(14, "GQLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(15, "ZLCDYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(16, "ZLCDYBB", typeof(Decimal), false, false, 9, 0, 0, 0)
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public Decimal HDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.HDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.HDID, value);
              }
          }
            
          public String DYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLHD.DYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLHD.DYID, value);
              }
          }
            
          public Decimal DYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.DYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.DYBB, value);
              }
          }
            
          public String HDMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLHD.HDMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLHD.HDMC, value);
              }
          }
            
          public Decimal HDLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.HDLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.HDLX, value);
              }
          }
            
          public Decimal JRLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.JRLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.JRLX, value);
              }
          }
            
          public Decimal LZLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.LZLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.LZLX, value);
              }
          }
            
          public Decimal X
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.X);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.X, value);
              }
          }
            
          public Decimal Y
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.Y);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.Y, value);
              }
          }
            
          public String JRJBID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLHD.JRJBID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLHD.JRJBID, value);
              }
          }
            
          public String LZJBID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLHD.LZJBID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLHD.LZJBID, value);
              }
          }
            
          public Decimal HDSX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.HDSX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.HDSX, value);
              }
          }
            
          public Decimal HDGQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.HDGQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.HDGQ, value);
              }
          }
            
          public Decimal CSTX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.CSTX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.CSTX, value);
              }
          }
            
          public Decimal GQLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.GQLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.GQLX, value);
              }
          }
            
          public String ZLCDYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLHD.ZLCDYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLHD.ZLCDYID, value);
              }
          }
            
          public Decimal ZLCDYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLHD.ZLCDYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLHD.ZLCDYBB, value);
              }
          }
            

          public enum VOE_WF_GZLHD : int
          {
              HDID,
              DYID,
              DYBB,
              HDMC,
              HDLX,
              JRLX,
              LZLX,
              X,
              Y,
              JRJBID,
              LZJBID,
              HDSX,
              HDGQ,
              CSTX,
              GQLX,
              ZLCDYID,
              ZLCDYBB,
          }
      }
  }
    