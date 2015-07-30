using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;
using WX.WFA.ViewModel;
using WX.WFA.Common;
using WX.WFA.VO;

namespace WX.WFA.LSSLGL
{
    public class VM_LSSLGL : ViewModelBase
    {
        public VM_LSSLGL()
        {
            D_QueryEntity = new VO_WF_SLXX_LS();
        }

        private VO_WF_SLXX_LS _D_QueryEntity;
        public VO_WF_SLXX_LS D_QueryEntity
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
                      value.QSRQ_START = DateTime.Now.Date.AddMonths(-1);
                      value.QSRQ_END = DateTime.Now.Date;
                    }
                }
            }
        }

        private VO_WF_SLXX_LS _D_DYSelectedItem;
        public VO_WF_SLXX_LS D_DYSelectedItem
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

        private ObservableCollection<VO_WF_SLXX_CX> _D_SLLSView;
        public ObservableCollection<VO_WF_SLXX_CX> D_SLLSView
        {
            get
            {
                if (_D_SLLSView == null)
                {
                    _D_SLLSView = new ObservableCollection<VO_WF_SLXX_CX>();
                }
                return _D_SLLSView;
            }

        }

        private ObservableCollection<VO_WF_LZXX_LS> _D_SLLZView;
        public ObservableCollection<VO_WF_LZXX_LS> D_SLLZView
        {
            get
            {
                if (_D_SLLZView == null)
                {
                    _D_SLLZView = new ObservableCollection<VO_WF_LZXX_LS>();
                }
                return _D_SLLZView;
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
                        D_QueryEntity = new VO_WF_SLXX_LS();
                    });
                }

                return _CMD_Reset;
            }
        }

        private VO_WF_SLXX_CX _D_SLSelectedItem;
        public VO_WF_SLXX_CX D_SLSelectedItem
        {
            get
            {
                return _D_SLSelectedItem;
            }
            set
            {
                if (_D_SLSelectedItem != value)
                {
                    _D_SLSelectedItem = value;
                    OnPropertyChanged("D_SLSelectedItem");
                    if(value !=null )
                        QueryLZXX(value);                    
                }
            }
        }        

        private void QueryLZXX(VO_WF_SLXX_CX vo)
        {
            D_SLLZView.Clear();
            IsProcessed = false;
            _AsyncWorker = new BackgroundWorker();
            _AsyncWorker.DoWork += (obj, args) =>
            {
                var client = new S_GZLGL();
                var voLZXX = new VO_WF_LZXX_LS();
                voLZXX.SLGUID = vo.SLGUID;
                args.Result = client.WFGL_CXLZXX_LS(voLZXX);
            };
            _AsyncWorker.RunWorkerCompleted += (obj, args) =>
            {
                try
                {
                    var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZXX_LS[]>;
                    if (result.Item2 != null)
                    {
                        MessageX.ShowError(result.Item2.TSXX);
                    }
                    else
                    {
                        D_SLLZView.AddRange(result.Item3.Select(a =>
                        {
                            a.JRRQX = DateTimeHelper.GetDateTime(a.JRRQ, a.JRSJ);
                            a.LCRQX = DateTimeHelper.GetDateTime(a.LCRQ, a.LCSJ);
                            switch (Decimal.ToInt32(a.ZYZT))
                            {
                                case 0:
                                    a.ZYZTX = "正常通过";
                                    break;
                                case 1:
                                    a.ZYZTX = "未通过结束";
                                    break;
                                case 2:
                                    a.ZYZTX = "待流转";
                                    break;
                                case 3:
                                    a.ZYZTX = "强制跳转";
                                    break;
                                case 4:
                                    a.ZYZTX = "作废";
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
                        D_SLLSView.Clear();
                        D_SLLZView.Clear();
                        IsProcessed = false;
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_GZLGL();
                            args.Result = client.WFGL_CXSLXX_LS(D_QueryEntity); 
                        };
                        _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                        {
                            try
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX[]>;
                                if (result.Item2 != null)
                                {
                                    MessageX.ShowError(result.Item2.TSXX);
                                }
                                else
                                {
                                    D_SLLSView.AddRange(result.Item3.Select(a =>
                                    {
                                        a.QDRQX = DateTimeHelper.GetDateTime(a.QDRQ, a.QDSJ);
                                        a.JRRQX = DateTimeHelper.GetDateTime(a.JRRQ, a.JRSJ);
                                        a.JZRQX = DateTimeHelper.GetDateTime(a.JZRQ, a.JZSJ);
                                        switch (Decimal.ToInt32(a.SLZT))
                                        {
                                            case 1:
                                                a.SLZTX = "开始";
                                                break;
                                            case 2:
                                                a.SLZTX = "运行";
                                                break;
                                            case 3:
                                                a.SLZTX = "挂起";
                                                break;
                                            case 4:
                                                a.SLZTX = "结束";
                                                break;
                                            case 5:
                                                a.SLZTX = "作废";
                                                break;
                                        };
                                        switch (Decimal.ToInt32(a.HDLX))
                                        {
                                            case 0:
                                                a.HDLXX = "开始";
                                                break;
                                            case 1:
                                                a.HDLXX = "结束";
                                                break;
                                            case 2:
                                                a.HDLXX = "人工活动";
                                                break;
                                            case 3:
                                                a.HDLXX = "自动活动";
                                                break;
                                            case 4:
                                                a.HDLXX = "会签活动";
                                                break;
                                            case 5:
                                                a.HDLXX = "并发活动";
                                                break;
                                            case 6:
                                                a.HDLXX = "动态并发活动";
                                                break;
                                            default:
                                                a.HDLXX = "其他活动";
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

        private ICommand _CMD_SLLSGL;
        public ICommand CMD_SLLSGL
        {
            get
            {
                if (_CMD_SLLSGL == null)
                {
                    _CMD_SLLSGL = new RelayCommand((e =>
                    {
                        if (this.D_SLSelectedItem != null)
                        {
                            var vm = new VM_LSSLGL_SLLSXX();
                            vm.Initialize(D_SLSelectedItem);
                            vm.RequestClose += (o, ex) =>
                            {
                                if (ex.Data != null && ex.Data is VO_WF_SLXX_CX)
                                {
                                    D_SLLSView[D_SLLSView.IndexOf(this.D_SLSelectedItem)] = ex.Data as VO_WF_SLXX_CX;
                                }
                            };
                            this.ShowDialog(vm);
                        }
                    }),
                    (e => this.D_SLSelectedItem != null));
                }

                return _CMD_SLLSGL;
            }
        }

    }
}