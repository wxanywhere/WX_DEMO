
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_CZRZ:VOBase
      {
        private DateTime _RZRQX;
        public DateTime RZRQX
        {
          get
          {
            return _RZRQX;
          }
          set
          {
            if (_RZRQX != value)
            {
              _RZRQX = value;
              OnPropertyChanged("RZRQX");
            }
          }
        }

        private DateTime _RZRQ_START;
        public DateTime RZRQ_START
        {
          get
          {
            return _RZRQ_START;
          }
          set
          {
            if (_RZRQ_START != value)
            {
              _RZRQ_START = value;
              OnPropertyChanged("RZRQ_START");
              if (value != null)
              {
                RZRQ = decimal.Parse(value.ToString("yyyyMMdd"));
              }
            }
          }
        }

        private DateTime _RZRQ_END;
        public DateTime RZRQ_END
        {
          get
          {
            return _RZRQ_END;
          }
          set
          {
            if (_RZRQ_END != value)
            {
              _RZRQ_END = value;
              OnPropertyChanged("RZRQ_END");
              if (value != null)
              {
                RZSJ = decimal.Parse(value.AddDays(1).ToString("yyMMdd")); //临时
              }
            }
          }
        }

        private string _CZLXX;
        public string CZLXX
        {
            get
            {
                return _CZLXX;
            }
            set
            {
                if (_CZLXX != value)
                {
                    _CZLXX = value;
                    OnPropertyChanged("CZLXX");
                }
            }
        }

      }
  }