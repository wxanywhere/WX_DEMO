
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_SLTJ_CX:VOBase
      {
          public const System.String EntityName = "VO_WF_SLTJ_CX";
          public VO_WF_SLTJ_CX()
          {
              FieldsSumLength = 54;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "KSSL", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(1, "YXSL", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(2, "GQSL", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(3, "JSSL", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(4, "ZFSL", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(5, "QBSL", typeof(Decimal), false, false, 9, 0, 0, 0)
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public Decimal KSSL
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLTJ_CX.KSSL);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLTJ_CX.KSSL, value);
              }
          }
            
          public Decimal YXSL
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLTJ_CX.YXSL);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLTJ_CX.YXSL, value);
              }
          }
            
          public Decimal GQSL
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLTJ_CX.GQSL);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLTJ_CX.GQSL, value);
              }
          }
            
          public Decimal JSSL
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLTJ_CX.JSSL);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLTJ_CX.JSSL, value);
              }
          }
            
          public Decimal ZFSL
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLTJ_CX.ZFSL);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLTJ_CX.ZFSL, value);
              }
          }
            
          public Decimal QBSL
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_SLTJ_CX.QBSL);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_SLTJ_CX.QBSL, value);
              }
          }
            

          public enum VOE_WF_SLTJ_CX : int
          {
              KSSL,
              YXSL,
              GQSL,
              JSSL,
              ZFSL,
              QBSL,
          }
      }
  }
    