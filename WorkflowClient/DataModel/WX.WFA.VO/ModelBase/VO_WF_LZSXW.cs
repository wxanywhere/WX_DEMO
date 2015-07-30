
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_LZSXW:VOBase
      {
          public const System.String EntityName = "VO_WF_LZSXW";
          public VO_WF_LZSXW()
          {
              FieldsSumLength = 4040;
          }
          private VOFieldInfo[] _VOFieldInfos = new VOFieldInfo[]
          {
              new VOFieldInfo(0, "SXWID", typeof(String), false, false, 40, 0, 0, ""),
              new VOFieldInfo(1, "SXW", typeof(String), false, false, 4000, 0, 0, "")
          };

          public override VOFieldInfo[] VOFieldInfos
          {
              get
              {
                  return _VOFieldInfos;
              }
          }

          public String SXWID
          {
              get
              {
                  return GetValue<String>(VOE_WF_LZSXW.SXWID);
              }
              set
              {
                  SetValue<String>(VOE_WF_LZSXW.SXWID, value);
              }
          }
            
          public String SXW
          {
              get
              {
                  return GetValue<String>(VOE_WF_LZSXW.SXW);
              }
              set
              {
                  SetValue<String>(VOE_WF_LZSXW.SXW, value);
              }
          }
            

          public enum VOE_WF_LZSXW : int
          {
              SXWID,
              SXW,
          }
      }
  }
    