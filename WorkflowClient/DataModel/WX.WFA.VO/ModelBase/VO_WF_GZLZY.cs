
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_GZLZY:VOBase
      {
          public const System.String EntityName = "VO_WF_GZLZY";
          public VO_WF_GZLZY()
          {
              FieldsSumLength = 160;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "ZYID", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(1, "DYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(2, "DYBB", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(3, "QSHDID", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(4, "ZZHDID", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(5, "TJJBID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(6, "ZYLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(7, "TJLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(8, "ZYMC", typeof(String), false, false, 40, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public Decimal ZYID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLZY.ZYID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLZY.ZYID, value);
              }
          }
            
          public String DYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLZY.DYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLZY.DYID, value);
              }
          }
            
          public Decimal DYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLZY.DYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLZY.DYBB, value);
              }
          }
            
          public Decimal QSHDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLZY.QSHDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLZY.QSHDID, value);
              }
          }
            
          public Decimal ZZHDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLZY.ZZHDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLZY.ZZHDID, value);
              }
          }
            
          public String TJJBID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLZY.TJJBID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLZY.TJJBID, value);
              }
          }
            
          public Decimal ZYLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLZY.ZYLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLZY.ZYLX, value);
              }
          }
            
          public Decimal TJLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLZY.TJLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLZY.TJLX, value);
              }
          }
            
          public String ZYMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLZY.ZYMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLZY.ZYMC, value);
              }
          }
            

          public enum VOE_WF_GZLZY : int
          {
              ZYID,
              DYID,
              DYBB,
              QSHDID,
              ZZHDID,
              TJJBID,
              ZYLX,
              TJLX,
              ZYMC,
          }
      }
  }
    