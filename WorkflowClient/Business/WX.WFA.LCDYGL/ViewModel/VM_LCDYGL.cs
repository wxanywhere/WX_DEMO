using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WX.WFA.ViewModel;
using WX.WFA.Common;
using WX.WFA.VO;
using System.ComponentModel;
using WX.WFA.ViewCommon;
using System.Windows;
using WX.WFA.ServiceChannel;

namespace WX.WFA.LCDYGL
{
    public class VM_LCDYGL : ViewModelBase
    {
        public VM_LCDYGL()
        {
            D_QueryEntity = new VO_WF_GZLDY();
        }

        private VO_WF_GZLDY _D_QueryEntity;
        public VO_WF_GZLDY D_QueryEntity
        {
            get
            {
                return _D_QueryEntity;
            }
            set
            {
                if (_D_QueryEntity != value)
                {
                    _D_QueryEntity = value;
                    OnPropertyChanged("D_QueryEntity");
                    if (value != null)
                    {
                      value.DYRQ_START = DateTime.Now.Date.AddMonths(-1);
                      value.DYRQ_END = DateTime.Now.Date;
                    }
                }
            }
        }

        private VO_WF_GZLDY _D_DYSelectedItem;
        public VO_WF_GZLDY D_DYSelectedItem
        {
            get
            {
                return _D_DYSelectedItem;
            }
            set
            {
                if (_D_DYSelectedItem != value)
                {
                    _D_DYSelectedItem = value;
                    OnPropertyChanged("D_DYSelectedItem");
                }
            }
        }

        private ICommand _CMD_CJDY;
        public ICommand CMD_CJDY
        {
            get
            {
                if (_CMD_CJDY == null)
                {
                    _CMD_CJDY = new RelayCommand(e =>
                    {
                        VM_LCDYGL_CJDY sl = new VM_LCDYGL_CJDY();
                        this.ShowDialog(sl);
                    });
                }

                return _CMD_CJDY;
            }
        }

        private ObservableCollection<VO_WF_GZLDY> _D_DYView;
        public ObservableCollection<VO_WF_GZLDY> D_DYView
        {
            get
            {
                if (_D_DYView == null)
                {
                    _D_DYView = new ObservableCollection<VO_WF_GZLDY>();
                }
                return _D_DYView;
            }

        }

        private ICommand _CMD_Reset;
        public ICommand CMD_Reset
        {
            get
            {
                if (_CMD_Reset == null)
                {
                    _CMD_Reset = new RelayCommand(e =>
                    {
                        D_QueryEntity = new VO_WF_GZLDY();
                    });
                }

                return _CMD_Reset;
            }
        }

        private BackgroundWorker _AsyncWorker;
        private ICommand _CMD_Query;
        public ICommand CMD_Query
        {
            get
            {
                if (_CMD_Query == null)
                {
                    _CMD_Query = new RelayCommand(e =>
                    {
                        D_DYView.Clear();
                        IsProcessed = false;
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_GZLGL();
                            args.Result = client.WFDY_CXLCDY(D_QueryEntity); //client.WFGL_CXSLXX(vo); //client.WFGL_CXSLXX(vo);  //client.S09_WFGL_CXSLXX(vo); //client.WFGL_CXSLXX(vo); //dic.GetVOCollection<VO_WF_SLXX>().ToArray();
                        };
                        _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                        {
                            try
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_GZLDY[]>;
                                if (result.Item2 != null)
                                {
                                    MessageX.ShowError(result.Item2.TSXX);
                                }
                                else
                                {
                                    D_DYView.AddRange(
                                      result.Item3.Select(a =>
                                      {
                                        a.DYRQX = DateTimeHelper.GetDateTime(a.DYRQ, a.DYSJ);
                                        a.QYRQX = DateTimeHelper.GetDateTime(a.QYRQ, a.QYSJ);
                                        switch (Decimal.ToInt32(a.DYZT))
                                        {
                                            case 0:
                                                a.DYZTX = "新定义";
                                                break;
                                            case 1:
                                                a.DYZTX = "已发布";
                                                break;
                                            case 2:
                                                a.DYZTX = "模板";
                                                break;                                            
                                        };
                                        return a;
                                      })
                                      );
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "错误信息", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            IsProcessed = true;
                        };
                        _AsyncWorker.RunWorkerAsync();

                    });
                }

                return _CMD_Query;
            }

        }

    }
}
