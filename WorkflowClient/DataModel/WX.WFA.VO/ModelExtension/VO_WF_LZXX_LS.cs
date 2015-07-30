
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_LZXX_LS:VOBase
      {
          private DateTime _JRRQX;
          public DateTime JRRQX
          {
              get
              {
                  return _JRRQX;
              }
              set
              {
                  if (_JRRQX != value)
                  {
                      _JRRQX = value;
                      OnPropertyChanged("JRRQX");
                  }
              }
          }

          private DateTime _LCRQX;
          public DateTime LCRQX
          {
              get
              {
                  return _LCRQX;
              }
              set
              {
                  if (_LCRQX != value)
                  {
                      _LCRQX = value;
                      OnPropertyChanged("LCRQX");
                  }
              }
          }
          private string _ZYZTX;
          public string ZYZTX
          {
              get
              {
                  return _ZYZTX;
              }
              set
              {
                  if (_ZYZTX != value)
                  {
                      _ZYZTX = value;
                      OnPropertyChanged("ZYZTX");
                  }
              }
          }

      }
  }