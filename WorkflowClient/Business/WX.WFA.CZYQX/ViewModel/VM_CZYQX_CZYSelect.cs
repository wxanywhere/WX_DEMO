using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;
using WX.WFA.ViewModel;
using WX.WFA.VO;
using WX.WFA.Common;

namespace WX.WFA.CZYQX
{
    public class VM_CZYQX_CZYSelect : ViewModelBase
    {
        private BackgroundWorker _AsyncWorker;
        private string _CurrentGNID;

        public VM_CZYQX_CZYSelect()
        {
        }

        private VO_WF_CZQX _D_QueryEntity;
        public VO_WF_CZQX D_QueryEntity
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
                }
            }
        }

        private ObservableCollection<VO_WF_CZYB> _D_CZYView;
        public ObservableCollection<VO_WF_CZYB> D_CZYView
        {
            get
            {
                if (_D_CZYView == null)
                {
                  _D_CZYView = new ObservableCollection<VO_WF_CZYB>();
                }
                return _D_CZYView;
            }

        }

        private ICommand _CMD_Query;
        public ICommand CMD_Query
        {
            get
            {
                if (_CMD_Query == null)
                {
                    _CMD_Query = new RelayCommand(e =>
                    {
                        D_CZYView.Clear();
                        IsProcessed = false;
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_XTGL();
                            D_QueryEntity.GNID = _CurrentGNID;
                            args.Result = client.XTGL_CXWGNCZY(D_QueryEntity); 
                        };
                        _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                        {
                            try
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB[]>;
                                if (result.Item2 != null)
                                {
                                    MessageX.ShowError(result.Item2.TSXX);
                                }
                                else
                                {
                                    D_CZYView.AddRange(
                                      result.Item3.Select(a=>{
                                        a.CJRQX = DateTimeHelper.GetDateTime(a.CJRQ, a.CJSJ);
                                        a.DQZTX = a.DCZT == 1 ? "可用" : "不可用";
                                        return a;
                                      })
                                    );
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageX.ShowError(ex.Message);
                            }
                            IsProcessed = true;
                        };
                        _AsyncWorker.RunWorkerAsync();

                    });
                }

                return _CMD_Query;
            }
        }

        private ICommand _CMD_Select;
        public ICommand CMD_Select
        {
            get
            {
                if (_CMD_Select == null)
                {
                    _CMD_Select = new RelayCommand((e =>
                    {
                        IsProcessed = false;
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_XTGL();
                            var vos = D_CZYView
                                .Where(a => a.IsChecked)
                                .Select(a => new VO_WF_CZQX() { CZYID = a.CZYID, GNID = _CurrentGNID })
                                .ToArray();
                            args.Result = client.XTGL_ZJGNCZY(vos);
                        };
                        _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                        {
                            try
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX>;
                                if (result.Item2 != null)
                                {
                                    MessageX.ShowError(result.Item2.TSXX);
                                }
                                else
                                {
                                  this.CloseCommand.Execute(D_CZYView.Where(a => a.IsChecked).ToArray());
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageX.ShowError(ex.Message);
                            }
                            IsProcessed = true;
                        };
                        _AsyncWorker.RunWorkerAsync();
                        
                    }),
                    (e => D_CZYView.Any(a => a.IsChecked)));
                }

                return _CMD_Select;
            }
        }

        public void Initialize(string gnid)
        {
            Title = "选择操作员";
            D_QueryEntity = new VO_WF_CZQX();
            _CurrentGNID = gnid;
        }
    }
}
