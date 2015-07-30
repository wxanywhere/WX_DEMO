
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_SLXX:VOBase
      {
          private DateTime _QDRQX;
          public DateTime QDRQX
          {
              get
              {
                  return _QDRQX;
              }
              set
              {
                  if (_QDRQX != value)
                  {
                      _QDRQX = value;
                      OnPropertyChanged("QDRQX");
                  }
              }
          }
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

          private DateTime _JZRQX;
          public DateTime JZRQX
          {
              get
              {
                  return _JZRQX;
              }
              set
              {
                  if (_JZRQX != value)
                  {
                      _JZRQX = value;
                      OnPropertyChanged("JZRQX");
                  }
              }
          }

          private DateTime _QSRQ_START;
          public DateTime QSRQ_START
          {
              get
              {
                  return _QSRQ_START;
              }
              set
              {
                  if (_QSRQ_START != value)
                  {
                      _QSRQ_START = value;
                      OnPropertyChanged("QSRQ_START");
                      if (value != null)
                      {
                        QDRQ = decimal.Parse(value.ToString("yyyyMMdd"));
                      }
                  }
              }
          }

          private DateTime _QSRQ_END;
          public DateTime QSRQ_END
          {
              get
              {
                  return _QSRQ_END;
              }
              set
              {
                  if (_QSRQ_END != value)
                  {
                      _QSRQ_END = value;
                      OnPropertyChanged("QSRQ_END");
                      if (value != null)
                      {
                        QDSJ = decimal.Parse(value.AddDays(1).ToString("yyMMdd"));
                      }
                  }
              }
          }

          private string _SLZTX;
          public string SLZTX
          {
              get
              {
                  return _SLZTX;
              }
              set
              {
                  if (_SLZTX != value)
                  {
                      _SLZTX = value;
                      OnPropertyChanged("SLZTX");
                  }
              }
          }
          private string _HDLXX;
          public string HDLXX
          {
              get
              {
                  return _HDLXX;
              }
              set
              {
                  if (_HDLXX != value)
                  {
                      _HDLXX = value;
                      OnPropertyChanged("HDLXX");
                  }
              }
          }

      }
  }