using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WX.WFA.ViewModel;
using WX.WFA.VO;
using WX.WFA.Common;
using WX.WFA.TempData;
using System.ComponentModel;
using WX.WFA.ViewCommon;
using WX.WFA.ServiceChannel;
using System.Windows;

namespace WX.WFA.CZYQX
{
    public class VM_CZYQX : ViewModelBase
    {
        private BackgroundWorker _AsyncWorker;
        private string _CurrentGNID=string.Empty;

        private ObservableCollection<VO_XT_GN> _D_GNView;
        public ObservableCollection<VO_XT_GN> D_GNView
        {
            get
            {
                if (_D_GNView == null)
                {
                    _D_GNView = new ObservableCollection<VO_XT_GN>();
                }
                return _D_GNView;
            }

        }

        private ObservableCollection<VO_WF_CZYB> _D_GNCZYView;
        public ObservableCollection<VO_WF_CZYB> D_GNCZYView
        {
            get
            {
                if (_D_GNCZYView == null)
                {
                    _D_GNCZYView = new ObservableCollection<VO_WF_CZYB>();
                }
                return _D_GNCZYView;
            }

        }

        private ICommand _CMD_Add;
        public ICommand CMD_Add
        {
            get
            {
                if (_CMD_Add == null)
                {
                  _CMD_Add = new RelayCommand((e =>
                  {
                    var vm = new VM_CZYQX_CZYSelect();
                    vm.Initialize(_CurrentGNID);
                    vm.RequestClose += (o, ex) =>
                    {
                      if (ex.Data != null && ex.Data is VO_WF_CZYB[])
                      {
                        D_GNCZYView.AddRange(ex.Data as VO_WF_CZYB[]);
                      }
                    };
                    this.ShowDialog(vm);
                  }),
                  (e => !String.IsNullOrWhiteSpace(_CurrentGNID)));
                }

                return _CMD_Add;
            }
        }

        private ICommand _CMD_Delete;
        public ICommand CMD_Delete
        {
            get
            {
                if (_CMD_Delete == null)
                {
                    _CMD_Delete = new RelayCommand((e =>
                    {
                      if (MessageX.ShowConfirm("所选数据将被删除，是否继续？") == MessageBoxResult.Yes)
                      {
                        IsProcessed = false;
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                          var client = new S_XTGL();
                          var vos = D_GNCZYView
                              .Where(a => a.IsChecked)
                              .Select(a => new VO_WF_CZQX() { CZYID = a.CZYID, GNID = _CurrentGNID })
                              .ToArray();
                          args.Result = client.XTGL_SCGNCZY(vos);
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
                              D_GNCZYView.Remove(D_GNCZYView.Where(a => a.IsChecked).ToArray());
                            }
                          }
                          catch (Exception ex)
                          {
                            MessageX.ShowError(ex.Message);
                          }
                          IsProcessed = true;
                        };
                        _AsyncWorker.RunWorkerAsync();
                      }
                    }),
                    (e => D_GNCZYView.Any(a => a.IsChecked)));
                }

                return _CMD_Delete;
            }
        }

        public void Initialize()
        {
            D_GNView.Clear();
            foreach (var item in DataSourceHelper.VO_XT_GNs)
            {
                item.ItemCommand = new RelayCommand(e =>
                {
                    _CurrentGNID=item.GNID;
                    D_GNCZYView.Clear();
                    IsProcessed = false;
                    _AsyncWorker = new BackgroundWorker();
                    _AsyncWorker.DoWork += (obj, args) =>
                    {
                        var client = new S_XTGL();
                        var vo = new VO_WF_CZQX();
                        vo.GNID = item.GNID;
                        args.Result = client.XTGL_CXGNCZY(vo);
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
                              D_GNCZYView.AddRange(
                                    result.Item3.Select(a =>
                                    {
                                      a.CJRQX = DateTimeHelper.GetDateTime(a.CJRQ, a.CJSJ);
                                      a.DQZTX = a.DCZT == 1 ? "可用" : "不可用";
                                      return a;
                                    }));
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
                D_GNView.Add(item);
            }
        }

        public override void InitializeSpecific()
        {
            Initialize();
        }
    }
}
