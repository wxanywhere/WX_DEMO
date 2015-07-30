using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;
using WX.WFA.Common;
using WX.WFA.ViewModel;
using WX.WFA.VO;

namespace WX.WFA.LSSLGL
{
    public class VM_LSSLGL_LZSXW : ViewModelBase
    {
        private VO_WF_LZSXW _D_LZSXW;
        public VO_WF_LZSXW D_LZSXW
        {
            get
            {
                return _D_LZSXW;
            }
            set
            {
                if (_D_LZSXW != value)
                {
                    _D_LZSXW = value;
                    OnPropertyChanged("D_LZSXW");
                }
            }
        }

        private ObservableCollection<VO_WF_LZSXW> _D_LZSXWView;
        public ObservableCollection<VO_WF_LZSXW> D_LZSXWView
        {
            get
            {
                if (_D_LZSXWView == null)
                {
                    _D_LZSXWView = new ObservableCollection<VO_WF_LZSXW>();
                }
                return _D_LZSXWView;
            }

        }

        public void Initialize(VO_WF_LZXX_LS d_LZOriginal)
        {
            Title = "上下文信息";
            QueryLZSXW(d_LZOriginal);
        }
        private BackgroundWorker _AsyncWorker;
        public void QueryLZSXW(VO_WF_LZXX_LS vo)
        {
            D_LZSXWView.Clear();
            IsProcessed = false;
            _AsyncWorker = new BackgroundWorker();
            _AsyncWorker.DoWork += (obj, args) =>
            {
                var client = new S_GZLGL();
                var voLZSXW = new VO_WF_LZSXW();
                voLZSXW.SXWID = vo.SXWID;
                args.Result = client.WFGL_CXLZSXW(voLZSXW);
            };
            _AsyncWorker.RunWorkerCompleted += (obj, args) =>
            {
                try
                {
                    var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZSXW[]>;
                    if (result.Item2 != null)
                    {
                        MessageX.ShowError(result.Item2.TSXX);
                    }
                    else
                    {
                        D_LZSXWView.AddRange(result.Item3.Select(a =>
                        {
                            return a;
                        })
                        );
                        D_LZSXW = D_LZSXWView[0];
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
    }
}
