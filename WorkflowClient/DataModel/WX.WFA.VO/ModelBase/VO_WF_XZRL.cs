
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_XZRL:VOBase
      {
          public const System.String EntityName = "VO_WF_XZRL";
          public VO_WF_XZRL()
          {
              FieldsSumLength = 123;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "RLID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(1, "RLMC", typeof(String), false, false, 50, 0, 0, ""),
              new VOFieldInfo(2, "RQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(3, "RQLX", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(4, "SM", typeof(String), false, false, 50, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public Decimal RLID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_XZRL.RLID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_XZRL.RLID, value);
              }
          }
            
          public String RLMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_XZRL.RLMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_XZRL.RLMC, value);
              }
          }
            
          public Decimal RQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_XZRL.RQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_XZRL.RQ, value);
              }
          }
            
          public Decimal RQLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_XZRL.RQLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_XZRL.RQLX, value);
              }
          }
            
          public String SM
          {
              get
              {
                  return GetValue<String>(VOE_WF_XZRL.SM);
              }
              set
              {
                  SetValue<String>(VOE_WF_XZRL.SM, value);
              }
          }
            

          public enum VOE_WF_XZRL : int
          {
              RLID,
              RLMC,
              RQ,
              RQLX,
              SM,
          }
      }
  }
    