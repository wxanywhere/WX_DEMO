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
using WX.WFA.Common;
using WX.WFA.ViewModel;
using WX.WFA.VO;

namespace WX.WFA.RZGL
{
    public class VM_RZGL : ViewModelBase
    {
        public VM_RZGL()
        {
            D_QueryEntity = new VO_WF_CZRZ();
        }

        private VO_WF_CZRZ _D_QueryEntity;
        public VO_WF_CZRZ D_QueryEntity
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
                      value.RZRQ_START = DateTime.Now.Date.AddMonths(-1);
                      value.RZRQ_END = DateTime.Now.Date;
                    }
                }
            }
        }

        private VO_WF_CZRZ _D_DYSelectedItem;
        public VO_WF_CZRZ D_DYSelectedItem
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

        private ObservableCollection<VO_WF_CZRZ> _D_RZView;
        public ObservableCollection<VO_WF_CZRZ> D_RZView
        {
            get
            {
                if (_D_RZView == null)
                {
                    _D_RZView = new ObservableCollection<VO_WF_CZRZ>();
                }
                return _D_RZView;
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
                        D_QueryEntity = new VO_WF_CZRZ();
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
                        D_RZView.Clear();
                        IsProcessed = false;
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_XTGL();
                            args.Result = client.XTGL_CXCZRZ(D_QueryEntity);
                        };
                        _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                        {
                            try
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZRZ[]>;
                                if (result.Item2 != null)
                                {
                                    MessageX.ShowError(result.Item2.TSXX);
                                }
                                else
                                {
                                    D_RZView.AddRange(
                                      result.Item3.Select(a =>
                                      {
                                        a.RZRQX = DateTimeHelper.GetDateTime(a.RZRQ, a.RZSJ);
                                        switch (Decimal.ToInt32(a.CZLX))
                                        {
                                            case 1:
                                                a.CZLXX = "强制跳转";
                                                break;
                                            case 2:
                                                a.CZLXX = "撤回";
                                                break;
                                            case 3:
                                                a.CZLXX = "强制结束";
                                                break;
                                            case 4:
                                                a.CZLXX = "挂起";
                                                break;
                                            case 5:
                                                a.CZLXX = "恢复";
                                                break;
                                            case 6:
                                                a.CZLXX = "参与变更者";
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
