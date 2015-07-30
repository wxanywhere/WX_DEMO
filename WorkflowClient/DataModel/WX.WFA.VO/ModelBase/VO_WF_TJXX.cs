
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_TJXX:VOBase
      {
          public const System.String EntityName = "VO_WF_TJXX";
          public VO_WF_TJXX()
          {
              FieldsSumLength = 172;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "SLGUID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "HDID", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(2, "YWLSH", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(3, "JSID", typeof(String), false, false, 20, 0, 0, ""),
              new VOFieldInfo(4, "JSRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(5, "JSSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(6, "TJRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(7, "TJSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(8, "WBCZYH", typeof(String), false, false, 64, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String SLGUID
          {
              get
              {
                  return GetValue<String>(VOE_WF_TJXX.SLGUID);
              }
              set
              {
                  SetValue<String>(VOE_WF_TJXX.SLGUID, value);
              }
          }
            
          public Decimal HDID
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_TJXX.HDID);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_TJXX.HDID, value);
              }
          }
            
          public Decimal YWLSH
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_TJXX.YWLSH);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_TJXX.YWLSH, value);
              }
          }
            
          public String JSID
          {
              get
              {
                  return GetValue<String>(VOE_WF_TJXX.JSID);
              }
              set
              {
                  SetValue<String>(VOE_WF_TJXX.JSID, value);
              }
          }
            
          public Decimal JSRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_TJXX.JSRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_TJXX.JSRQ, value);
              }
          }
            
          public Decimal JSSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_TJXX.JSSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_TJXX.JSSJ, value);
              }
          }
            
          public Decimal TJRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_TJXX.TJRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_TJXX.TJRQ, value);
              }
          }
            
          public Decimal TJSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_TJXX.TJSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_TJXX.TJSJ, value);
              }
          }
            
          public String WBCZYH
          {
              get
              {
                  return GetValue<String>(VOE_WF_TJXX.WBCZYH);
              }
              set
              {
                  SetValue<String>(VOE_WF_TJXX.WBCZYH, value);
              }
          }
            

          public enum VOE_WF_TJXX : int
          {
              SLGUID,
              HDID,
              YWLSH,
              JSID,
              JSRQ,
              JSSJ,
              TJRQ,
              TJSJ,
              WBCZYH,
          }
      }
  }
    