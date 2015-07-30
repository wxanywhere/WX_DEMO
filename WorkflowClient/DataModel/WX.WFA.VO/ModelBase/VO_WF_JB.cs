
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_JB:VOBase
      {
          public const System.String EntityName = "VO_WF_JB";
          public VO_WF_JB()
          {
              FieldsSumLength = 4094;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "JBID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "DYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(2, "DYBB", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(3, "JBNR1", typeof(String), false, false, 2000, 0, 0, ""),
              new VOFieldInfo(4, "JBNR2", typeof(String), false, false, 2000, 0, 0, ""),
              new VOFieldInfo(5, "JBLX", typeof(Decimal), false, false, 5, 0, 0, 0)
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
                  return GetValue<String>(VOE_WF_JB.JBID);
              }
              set
              {
                  SetValue<String>(VOE_WF_JB.JBID, value);
              }
          }
            
          public String DYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_JB.DYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_JB.DYID, value);
              }
          }
            
          public Decimal DYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_JB.DYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_JB.DYBB, value);
              }
          }
            
          public String JBNR1
          {
              get
              {
                  return GetValue<String>(VOE_WF_JB.JBNR1);
              }
              set
              {
                  SetValue<String>(VOE_WF_JB.JBNR1, value);
              }
          }
            
          public String JBNR2
          {
              get
              {
                  return GetValue<String>(VOE_WF_JB.JBNR2);
              }
              set
              {
                  SetValue<String>(VOE_WF_JB.JBNR2, value);
              }
          }
            
          public Decimal JBLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_JB.JBLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_JB.JBLX, value);
              }
          }
            

          public enum VOE_WF_JB : int
          {
              JBID,
              DYID,
              DYBB,
              JBNR1,
              JBNR2,
              JBLX,
          }
      }
  }
    