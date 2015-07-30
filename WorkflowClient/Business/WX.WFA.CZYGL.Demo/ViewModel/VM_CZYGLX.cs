using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WX.WFA.ViewModel;
using WX.WFA.Common;
using System.ComponentModel;
using WX.WFA.VO;
using WX.WFA.ServiceChannel;

namespace WX.WFA.CZYGL
{
    public class VM_CZYGLX : ViewModelBase
    {
        private BackgroundWorker _AsyncWorker;

        public VM_CZYGLX()
        {
            D_QueryEntity = new VO_WF_CZYB();
        }

        private List<VO_WF_CZYB> TemData = new List<VO_WF_CZYB>()
        { 
            new VO_WF_CZYB(){PZID=Guid.NewGuid().ToString(),CZYID="001",XM="wx01",MM="",DQZTX="可用",CJRQX=DateTime.Now},
            new VO_WF_CZYB(){PZID=Guid.NewGuid().ToString(),CZYID="005",XM="wx05",MM="",DQZTX="不可用",CJRQX=DateTime.Now}
        };

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
                        D_CZYView.Clear();

                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                          var client = new S_XTGL();
                          var vo=new VO_WF_CZQX();
                          //client.XTGL_CXCZQXX(vo);
                            System.Threading.Thread.Sleep(100);

                            if (!String.IsNullOrWhiteSpace(D_QueryEntity.XM))
                            {
                                args.Result = TemData.Where(a => a.XM.ToLower().Contains(D_QueryEntity.XM.Trim().ToLower())).ToList();
                            }
                            else
                            {
                                args.Result=TemData;
                            }
                        };
                        _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                        {
                            if (args.Result is List<VO_WF_CZYB>)
                            {
                                D_CZYView.AddRange(args.Result as List<VO_WF_CZYB>);
                            }
                            
                        };
                        _AsyncWorker.RunWorkerAsync();
                    });
                }

                return _CMD_Query;
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
                                D_CZYView.Add(ex.Data as VO_WF_CZYB);
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
                        if (MessageBox.Show("所选数据将被删除，是否继续？", "操作提示", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            _AsyncWorker = new BackgroundWorker();
                            _AsyncWorker.DoWork += (obj, args) =>
                            {
                                System.Threading.Thread.Sleep(100);

                                //从数据哭中删除数据...

                                args.Result = true; 
                            };
                            _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                            {
                                if (args.Result is bool && (bool)args.Result)
                                {
                                    D_CZYView.Remove(this.D_CZYSelectedItem);
                                }

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
