
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_CZRZ:VOBase
      {
          public const System.String EntityName = "VO_WF_CZRZ";
          public VO_WF_CZRZ()
          {
              FieldsSumLength = 598;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "RZRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(1, "RZSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(2, "CZLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(3, "CZNR", typeof(String), false, false, 512, 0, 0, ""),
              new VOFieldInfo(4, "CZJG", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(5, "CZYH", typeof(String), false, false, 20, 0, 0, ""),
              new VOFieldInfo(6, "SLGUID", typeof(String), false, false, 40, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public Decimal RZRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_CZRZ.RZRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_CZRZ.RZRQ, value);
              }
          }
            
          public Decimal RZSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_CZRZ.RZSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_CZRZ.RZSJ, value);
              }
          }
            
          public Decimal CZLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_CZRZ.CZLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_CZRZ.CZLX, value);
              }
          }
            
          public String CZNR
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZRZ.CZNR);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZRZ.CZNR, value);
              }
          }
            
          public Decimal CZJG
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_CZRZ.CZJG);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_CZRZ.CZJG, value);
              }
          }
            
          public String CZYH
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZRZ.CZYH);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZRZ.CZYH, value);
              }
          }
            
          public String SLGUID
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZRZ.SLGUID);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZRZ.SLGUID, value);
              }
          }
            

          public enum VOE_WF_CZRZ : int
          {
              RZRQ,
              RZSJ,
              CZLX,
              CZNR,
              CZJG,
              CZYH,
              SLGUID,
          }
      }
  }
    