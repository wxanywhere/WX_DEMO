using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WX.WFA.Common;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;
using WX.WFA.ViewModel;
using WX.WFA.VO;

namespace WX.WFA.LSSLGL
{
    public class VM_LSSLGL_SLLSXX : ViewModelBase
    {
        private VO_WF_SLXX_CX _D_SLXXDetail;
        public VO_WF_SLXX_CX D_SLXXDetail
        {
            get
            {
                return _D_SLXXDetail;
            }
            set
            {
                if (_D_SLXXDetail != value)
                {
                    _D_SLXXDetail = value;
                    OnPropertyChanged("D_SLXXDetail");
                }
            }
        }

        private VO_WF_LZXX_LS _D_LZSelectedItem;
        public VO_WF_LZXX_LS D_LZSelectedItem
        {
            get
            {
                return _D_LZSelectedItem;
            }
            set
            {
                if (_D_LZSelectedItem != value)
                {
                    _D_LZSelectedItem = value;
                    OnPropertyChanged("D_LZSelectedItem");                    
                }
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

        private BackgroundWorker _AsyncWorker;
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
        public void Initialize(VO_WF_SLXX_CX d_SLOriginal)
        {
            Title = "查看实例信息";
            _D_SLXXDetail = d_SLOriginal.Clone<VO_WF_SLXX_CX>();
            QueryLZXX(_D_SLXXDetail);
            //this.StartEdit(D_SLXXDetail, "D_SLXXDetail");
        }
        private ICommand _CMD_LZSXW;
        public ICommand CMD_LZSXW
        {
            get
            {
                if (_CMD_LZSXW == null)
                {
                    _CMD_LZSXW = new RelayCommand((e =>
                    {
                        if (this.D_LZSelectedItem != null)
                        {
                            var vm = new VM_LSSLGL_LZSXW();
                            vm.Initialize(D_LZSelectedItem);
                            vm.RequestClose += (o, ex) =>
                            {
                                if (ex.Data != null && ex.Data is VO_WF_LZXX_LS)
                                {
                                    D_SLLZView[D_SLLZView.IndexOf(this.D_LZSelectedItem)] = ex.Data as VO_WF_LZXX_LS;
                                }
                            };
                            this.ShowDialog(vm);
                        }
                    }),
                    (e => this.D_LZSelectedItem != null));
                }

                return _CMD_LZSXW;
            }
        }
    }
}
