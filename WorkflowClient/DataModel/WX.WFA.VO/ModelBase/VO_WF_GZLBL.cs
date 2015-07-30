
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_GZLBL:VOBase
      {
          public const System.String EntityName = "VO_WF_GZLBL";
          public VO_WF_GZLBL()
          {
              FieldsSumLength = 816;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "BLMC", typeof(String), false, false, 200, 0, 0, ""),
              new VOFieldInfo(1, "DYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(2, "DYBB", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(3, "ID", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(4, "BLFW", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(5, "BLLX", typeof(Decimal), false, false, 3, 0, 0, 0),
              new VOFieldInfo(6, "JBID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(7, "SMXX", typeof(String), false, false, 512, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String BLMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLBL.BLMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLBL.BLMC, value);
              }
          }
            
          public String DYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLBL.DYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLBL.DYID, value);
              }
          }
            
          public Decimal DYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLBL.DYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLBL.DYBB, value);
              }
          }
            
          public Decimal ID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLBL.ID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLBL.ID, value);
              }
          }
            
          public Decimal BLFW
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLBL.BLFW);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLBL.BLFW, value);
              }
          }
            
          public Decimal BLLX
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLBL.BLLX);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLBL.BLLX, value);
              }
          }
            
          public String JBID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLBL.JBID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLBL.JBID, value);
              }
          }
            
          public String SMXX
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLBL.SMXX);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLBL.SMXX, value);
              }
          }
            

          public enum VOE_WF_GZLBL : int
          {
              BLMC,
              DYID,
              DYBB,
              ID,
              BLFW,
              BLLX,
              JBID,
              SMXX,
          }
      }
  }
    