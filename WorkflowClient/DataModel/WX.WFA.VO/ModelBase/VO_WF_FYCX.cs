
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_FYCX:VOBase
      {
          public const System.String EntityName = "VO_WF_FYCX";
          public VO_WF_FYCX()
          {
              FieldsSumLength = 27;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "ROWFROM", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(1, "ROWTO", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(2, "ROWCOUNT", typeof(Decimal), false, false, 9, 0, 0, 0)
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public Decimal ROWFROM
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_FYCX.ROWFROM);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_FYCX.ROWFROM, value);
              }
          }
            
          public Decimal ROWTO
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_FYCX.ROWTO);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_FYCX.ROWTO, value);
              }
          }
            
          public Decimal ROWCOUNT
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_FYCX.ROWCOUNT);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_FYCX.ROWCOUNT, value);
              }
          }
            

          public enum VOE_WF_FYCX : int
          {
              ROWFROM,
              ROWTO,
              ROWCOUNT,
          }
      }
  }
    