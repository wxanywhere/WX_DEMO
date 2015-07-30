
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_CZQX:VOBase
      {
          public const System.String EntityName = "VO_WF_CZQX";
          public VO_WF_CZQX()
          {
              FieldsSumLength = 116;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "CZYID", typeof(String), false, false, 38, 0, 0, ""),
              new VOFieldInfo(1, "GNID", typeof(String), false, false, 38, 0, 0, ""),
              new VOFieldInfo(2, "GNMC", typeof(String), false, false, 40, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String CZYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZQX.CZYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZQX.CZYID, value);
              }
          }
            
          public String GNID
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZQX.GNID);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZQX.GNID, value);
              }
          }
            
          public String GNMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZQX.GNMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZQX.GNMC, value);
              }
          }
            

          public enum VOE_WF_CZQX : int
          {
              CZYID,
              GNID,
              GNMC,
          }
      }
  }
    