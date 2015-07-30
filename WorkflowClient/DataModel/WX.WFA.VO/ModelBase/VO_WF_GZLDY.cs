
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_GZLDY:VOBase
      {
          public const System.String EntityName = "VO_WF_GZLDY";
          public VO_WF_GZLDY()
          {
              FieldsSumLength = 552;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "DYID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "DYBB", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(2, "DYMC", typeof(String), false, false, 100, 0, 0, ""),
              new VOFieldInfo(3, "DYRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(4, "DYSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(5, "DYZT", typeof(Decimal), false, false, 3, 0, 0, 0),
              new VOFieldInfo(6, "DYSM", typeof(String), false, false, 200, 0, 0, ""),
              new VOFieldInfo(7, "QYRQ", typeof(Decimal), false, false, 9, 0, 0, 0),
              new VOFieldInfo(8, "QYSJ", typeof(Decimal), false, false, 7, 0, 0, 0),
              new VOFieldInfo(9, "NBCZYH", typeof(String), false, false, 64, 0, 0, ""),
              new VOFieldInfo(10, "WBCZYH", typeof(String), false, false, 64, 0, 0, ""),
              new VOFieldInfo(11, "PZID", typeof(String), false, false, 40, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String DYID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLDY.DYID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLDY.DYID, value);
              }
          }
            
          public Decimal DYBB
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLDY.DYBB);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLDY.DYBB, value);
              }
          }
            
          public String DYMC
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLDY.DYMC);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLDY.DYMC, value);
              }
          }
            
          public Decimal DYRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLDY.DYRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLDY.DYRQ, value);
              }
          }
            
          public Decimal DYSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLDY.DYSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLDY.DYSJ, value);
              }
          }
            
          public Decimal DYZT
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLDY.DYZT);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLDY.DYZT, value);
              }
          }
            
          public String DYSM
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLDY.DYSM);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLDY.DYSM, value);
              }
          }
            
          public Decimal QYRQ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLDY.QYRQ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLDY.QYRQ, value);
              }
          }
            
          public Decimal QYSJ
          {
              get
              {
                  return GetValue<Decimal>(VOE_WF_GZLDY.QYSJ);
              }
              set
              {
                  SetValue<Decimal>(VOE_WF_GZLDY.QYSJ, value);
              }
          }
            
          public String NBCZYH
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLDY.NBCZYH);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLDY.NBCZYH, value);
              }
          }
            
          public String WBCZYH
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLDY.WBCZYH);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLDY.WBCZYH, value);
              }
          }
            
          public String PZID
          {
              get
              {
                  return GetValue<String>(VOE_WF_GZLDY.PZID);
              }
              set
              {
                  SetValue<String>(VOE_WF_GZLDY.PZID, value);
              }
          }
            

          public enum VOE_WF_GZLDY : int
          {
              DYID,
              DYBB,
              DYMC,
              DYRQ,
              DYSJ,
              DYZT,
              DYSM,
              QYRQ,
              QYSJ,
              NBCZYH,
              WBCZYH,
              PZID,
          }
      }
  }
    