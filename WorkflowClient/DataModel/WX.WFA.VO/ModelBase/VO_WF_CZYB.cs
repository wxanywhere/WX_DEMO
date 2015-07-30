
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_CZYB:VOBase
      {
          public const System.String EntityName = "VO_WF_CZYB";
          public VO_WF_CZYB()
          {
              FieldsSumLength = 177;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "CZYBH", typeof(String), false, false, 38, 0, 0, ""),
              new VOFieldInfo(1, "CZYID", typeof(String), false, false, 38, 0, 0, ""),
              new VOFieldInfo(2, "XM", typeof(String), false, false, 20, 0, 0, ""),
              new VOFieldInfo(3, "MM", typeof(String), false, false, 20, 0, 0, ""),
              new VOFieldInfo(4, "CJRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(5, "CJSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(6, "DCZT", typeof(Decimal), false, false, 5, 0, 0, 0),
              new VOFieldInfo(7, "PZID", typeof(String), false, false, 40, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String CZYBH
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZYB.CZYBH);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZYB.CZYBH, value);
              }
          }
            
          public String CZYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZYB.CZYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZYB.CZYID, value);
              }
          }
            
          public String XM
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZYB.XM);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZYB.XM, value);
              }
          }
            
          public String MM
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZYB.MM);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZYB.MM, value);
              }
          }
            
          public Decimal CJRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_CZYB.CJRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_CZYB.CJRQ, value);
              }
          }
            
          public Decimal CJSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_CZYB.CJSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_CZYB.CJSJ, value);
              }
          }
            
          public Decimal DCZT
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_CZYB.DCZT);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_CZYB.DCZT, value);
              }
          }
            
          public String PZID
          {
              get
              {
                  return GetValue<String>(VOE_WF_CZYB.PZID);
              }
              set
              {
                  SetValue<String>(VOE_WF_CZYB.PZID, value);
              }
          }
            

          public enum VOE_WF_CZYB : int
          {
              CZYBH,
              CZYID,
              XM,
              MM,
              CJRQ,
              CJSJ,
              DCZT,
              PZID,
          }
      }
  }
    