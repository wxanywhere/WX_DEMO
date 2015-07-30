
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_JBHDGX:VOBase
      {
          public const System.String EntityName = "VO_WF_JBHDGX";
          public VO_WF_JBHDGX()
          {
              FieldsSumLength = 4613;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "JBID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "HDID", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(2, "DYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(3, "DYBB", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(4, "JBNR", typeof(String), false, false, 4000, 0, 0, ""),
              new VOFieldInfo(5, "JBLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(6, "URI", typeof(String), false, false, 512, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String JBID
          {
              get
              {
                  return GetValue<String>(VOE_WF_JBHDGX.JBID);
              }
              set
              {
                  SetValue<String>(VOE_WF_JBHDGX.JBID, value);
              }
          }
            
          public Decimal HDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_JBHDGX.HDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_JBHDGX.HDID, value);
              }
          }
            
          public String DYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_JBHDGX.DYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_JBHDGX.DYID, value);
              }
          }
            
          public Decimal DYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_JBHDGX.DYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_JBHDGX.DYBB, value);
              }
          }
            
          public String JBNR
          {
              get
              {
                  return GetValue<String>(VOE_WF_JBHDGX.JBNR);
              }
              set
              {
                  SetValue<String>(VOE_WF_JBHDGX.JBNR, value);
              }
          }
            
          public Decimal JBLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_JBHDGX.JBLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_JBHDGX.JBLX, value);
              }
          }
            
          public String URI
          {
              get
              {
                  return GetValue<String>(VOE_WF_JBHDGX.URI);
              }
              set
              {
                  SetValue<String>(VOE_WF_JBHDGX.URI, value);
              }
          }
            

          public enum VOE_WF_JBHDGX : int
          {
              JBID,
              HDID,
              DYID,
              DYBB,
              JBNR,
              JBLX,
              URI,
          }
      }
  }
    