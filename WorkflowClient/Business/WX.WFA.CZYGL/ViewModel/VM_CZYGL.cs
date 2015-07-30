using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;

using WX.WFA.ViewModel;
using WX.WFA.Common;
using WX.WFA.VO;
using WX.WFA.ISOAClient;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;

namespace WX.WFA.CZYGL
{
    public class VM_CZYGL : ViewModelBase
    {
        private BackgroundWorker _AsyncWorker;

        public VM_CZYGL()
        {
            D_QueryEntity = new VO_WF_CZYB();
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

        private VO_WF_CZYB _D_CZYSelectedItem;
        public VO_WF_CZYB D_CZYSelectedItem
        {
            get
            {
                return _D_CZYSelectedItem;
            }
            set
            {
                if (_D_CZYSelectedItem != value)
                {
                    _D_CZYSelectedItem = value;
                    OnPropertyChanged("D_CZYSelectedItem");
                }
            }
        }

        private VO_WF_CZYB _D_QueryEntity;
        public VO_WF_CZYB D_QueryEntity
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

        private ICommand _CMD_Query;
        public ICommand CMD_Query
        {
            get
            {
                if (_CMD_Query == null)
                {
                    _CMD_Query = new RelayCommand(e =>
                    {
                        IsProcessed = false;
                        D_CZYView.Clear();
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_XTGL();
                            args.Result = client.XTGL_CXCZY(D_QueryEntity);
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

        private ICommand _CMD_Reset;
        public ICommand CMD_Reset
        {
          get
          {
            if (_CMD_Reset == null)
            {
              _CMD_Reset = new RelayCommand(e =>
              {
                D_QueryEntity = new VO_WF_CZYB();
              });
            }

            return _CMD_Reset;
          }
        }

        private ICommand _CMD_Add;
        public ICommand CMD_Add
        {
            get
            {
                if (_CMD_Add == null)
                {
                    _CMD_Add = new RelayCommand(e =>
                    {
                        var vm = new VM_CZYGL_CZYAdd();
                        vm.RequestClose += (o,ex) =>
                        {
                            if (ex.Data != null && ex.Data is VO_WF_CZYB)
                            {
                                D_CZYView.Insert(0,ex.Data as VO_WF_CZYB);
                            }
                        };
                        this.ShowDialog(vm);
                    });
                }

                return _CMD_Add;
            }
        }

        private ICommand _CMD_Modify;
        public ICommand CMD_Modify
        {
            get
            {
                if (_CMD_Modify == null)
                {
                    _CMD_Modify = new RelayCommand((e =>
                    {
                        if (this.D_CZYSelectedItem != null)
                        {
                            var vm = new VM_CZYGL_CZYModify();
                            vm.Initialize(D_CZYSelectedItem);
                            vm.RequestClose += (o, ex) =>
                            {
                                if (ex.Data != null && ex.Data is VO_WF_CZYB)
                                {
                                    D_CZYView[D_CZYView.IndexOf(this.D_CZYSelectedItem)] = ex.Data as VO_WF_CZYB;
                                }
                            };
                            this.ShowDialog(vm);
                        }
                    }),
                    (e => this.D_CZYSelectedItem != null));
                }

                return _CMD_Modify;
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
                            args.Result = client.XTGL_SCCZY(D_CZYSelectedItem);
                          };
                          _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                          {
                            try
                            {
                              var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>;
                              if (result.Item2 != null)
                              {
                                MessageX.ShowError(result.Item2.TSXX);
                              }
                              else
                              {
                                D_CZYView.Remove(this.D_CZYSelectedItem);
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
                    (e=>this.D_CZYSelectedItem!=null));
                }

                return _CMD_Delete;
            }
        }
    }
}
