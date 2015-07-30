
  using System;
  using WX.WFA.DataModelBase;

  namespace WX.WFA.VO
  {
      public partial class VO_WF_GZLDY:VOBase
      {
        private DateTime _DYRQX;
        public DateTime DYRQX
        {
          get
          {
            return _DYRQX;
          }
          set
          {
            if (_DYRQX != value)
            {
              _DYRQX = value;
              OnPropertyChanged("DYRQX");
            }
          }
        }

        private DateTime _QYRQX;
        public DateTime QYRQX
        {
          get
          {
            return _QYRQX;
          }
          set
          {
            if (_QYRQX != value)
            {
              _QYRQX = value;
              OnPropertyChanged("QYRQX");
            }
          }
        }

        private DateTime _DYRQ_START;
        public DateTime DYRQ_START
        {
          get
          {
            return _DYRQ_START;
          }
          set
          {
            if (_DYRQ_START != value)
            {
              _DYRQ_START = value;
              OnPropertyChanged("DYRQ_START");
              if(value!=null)
              {
                DYRQ = decimal.Parse(value.ToString("yyyyMMdd"));
              }
            }
          }
        }

        private DateTime _DYRQ_END;
        public DateTime DYRQ_END
        {
          get
          {
            return _DYRQ_END;
          }
          set
          {
            if (_DYRQ_END != value)
            {
              _DYRQ_END = value;
              OnPropertyChanged("DYRQ_END");
              if (value != null)
              {
                DYSJ = decimal.Parse(value.AddDays(1).ToString("yyMMdd")); //临时
              }
            }
          }
        }
        private string _DYZTX;
        public string DYZTX
        {
            get
            {
                return _DYZTX;
            }
            set
            {
                if (_DYZTX != value)
                {
                    _DYZTX = value;
                    OnPropertyChanged("DYZTX");
                }
            }
        }



      }
  }