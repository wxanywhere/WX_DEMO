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
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;
using System.Windows;

namespace WX.WFA.SLGL
{
    public class VM_SLGL : ViewModelBase
    {
        private VO_WF_SLXX_CX _D_SLGLSelectedItem;
        public VO_WF_SLXX_CX D_SLGLSelectedItem
        {
            get
            {
                return _D_SLGLSelectedItem;
            }
            set
            {
                if (_D_SLGLSelectedItem != value)
                {
                    _D_SLGLSelectedItem = value;
                    OnPropertyChanged("D_SLGLSelectedItem");                    
                }
            }
        }
       
        private BackgroundWorker _AsyncWorker;

        public VM_SLGL()
        {
            D_QueryEntity = new VO_WF_SLXX();
        }

        private List<VO_WF_SLXX> TemData = new List<VO_WF_SLXX>()
        { 
          
        };

        private ObservableCollection<VO_WF_SLXX_CX> _D_SLView;
        public ObservableCollection<VO_WF_SLXX_CX> D_SLView
        {
            get
            {
                if (_D_SLView == null)
                {
                    _D_SLView = new ObservableCollection<VO_WF_SLXX_CX>();
                }
                return _D_SLView;
            }

        }

        private VO_WF_SLXX _D_QueryEntity;
        public VO_WF_SLXX D_QueryEntity
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

        private ICommand _CMD_Query;
        public ICommand CMD_Query
        {
            get
            {
                if (_CMD_Query == null)
                {
                    _CMD_Query = new RelayCommand(e =>
                    {
                        D_SLView.Clear();
                        IsProcessed = false;
                        _AsyncWorker = new BackgroundWorker();
                        _AsyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_GZLGL();
                            args.Result = client.WFGL_CXSLXX(D_QueryEntity); //client.WFGL_CXSLXX(vo);  //client.S09_WFGL_CXSLXX(vo); //client.WFGL_CXSLXX(vo); //dic.GetVOCollection<VO_WF_SLXX>().ToArray();
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
                                    D_SLView.AddRange(result.Item3.Select(a=>{
                                        a.QDRQX = DateTimeHelper.GetDateTime(a.QDRQ, a.QDSJ);
                                        a.JRRQX = DateTimeHelper.GetDateTime(a.JRRQ, a.JRSJ);
                                        a.JZRQX = DateTimeHelper.GetDateTime(a.JZRQ, a.JZSJ);
                                        switch(Decimal.ToInt32(a.SLZT))
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

        private ICommand _CMD_Reset;
        public ICommand CMD_Reset
        {
            get
            {
                if (_CMD_Reset == null)
                {
                    _CMD_Reset = new RelayCommand(e =>
                    {
                        D_QueryEntity = new VO_WF_SLXX();
                    });
                }

                return _CMD_Reset;
            }
        }
        private ICommand _CMD_SLGL;
        public ICommand CMD_SLGL
        {
            get
            {
                if (_CMD_SLGL == null)
                {
                    _CMD_SLGL = new RelayCommand((e =>
                    {
                        if (this.D_SLGLSelectedItem != null)
                        {
                            var vm = new VM_SLGL_CKSLXX();
                            vm.Initialize(D_SLGLSelectedItem);
                            vm.RequestClose += (o, ex) =>
                            {
                                if (ex.Data != null && ex.Data is VO_WF_SLXX_CX)
                                {
                                    D_SLView[D_SLView.IndexOf(this.D_SLGLSelectedItem)] = ex.Data as VO_WF_SLXX_CX;
                                }
                            };
                            this.ShowDialog(vm);
                        }
                    }),
                    (e => this.D_SLGLSelectedItem != null));
                }

                return _CMD_SLGL;
            }
        }

        private ICommand _CMD_SLKS;//开始
        public ICommand CMD_SLKS
        {
            get
            {
                if (_CMD_SLKS == null)
                {
                    _CMD_SLKS = new RelayCommand((e =>
                    {
                        if (this.D_SLGLSelectedItem != null)
                        {                            
                            IsProcessed = false;
                            _AsyncWorker = new BackgroundWorker();
                            _AsyncWorker.DoWork += (obj, args) =>
                            {
                                var client = new S_GZLGL();
                                var voCZRZ = new VO_WF_CZRZ();
                                var voSLXX = new VO_WF_SLXX();
                                var voGZLHD = new VO_WF_GZLHD();
                                var voLZSXW = new VO_WF_LZSXW();
                                voCZRZ.CZLX = 1;
                                voSLXX.SLGUID = D_SLGLSelectedItem.SLGUID;
                                voSLXX.DYBB = D_SLGLSelectedItem.DYBB;
                                voSLXX.DYID = D_SLGLSelectedItem.DYID;
                                args.Result = client.WFGL_SLCL(voCZRZ,voSLXX,voGZLHD,voLZSXW);
                            };
                            _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX[]>;

                                if (result == null)
                                {
                                    var items = D_SLView.Where(a =>
                                        a.SLGUID == D_SLGLSelectedItem.SLGUID && D_SLGLSelectedItem.DYID == a.DYID && D_SLGLSelectedItem.DYBB == a.DYBB);
                                    foreach (var item in items)
                                    {
                                        item.SLZT = 1;
                                        item.SLZTX = "开始";
                                    }
                                }
                                IsProcessed = true;
                            };
                            _AsyncWorker.RunWorkerAsync();                
                        }
                    }),
                    (e => this.D_SLGLSelectedItem != null));
                }

                return _CMD_SLKS;
            }
        }

        private ICommand _CMD_SLZT;//暂停
        public ICommand CMD_SLZT
        {
            get
            {
                if (_CMD_SLZT == null)
                {
                    _CMD_SLZT = new RelayCommand((e =>
                    {
                        if (this.D_SLGLSelectedItem != null)
                        {
                            IsProcessed = false;
                            _AsyncWorker = new BackgroundWorker();
                            _AsyncWorker.DoWork += (obj, args) =>
                            {
                                var client = new S_GZLGL();
                                var voCZRZ = new VO_WF_CZRZ();
                                var voSLXX = new VO_WF_SLXX();
                                var voGZLHD = new VO_WF_GZLHD();
                                var voLZSXW = new VO_WF_LZSXW();
                                voCZRZ.CZLX = 4;
                                voSLXX.SLGUID = D_SLGLSelectedItem.SLGUID;
                                voSLXX.DYBB = D_SLGLSelectedItem.DYBB;
                                voSLXX.DYID = D_SLGLSelectedItem.DYID;   
                                args.Result = client.WFGL_SLCL(voCZRZ, voSLXX, voGZLHD, voLZSXW);                                
                            };
                            _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                            {
                              
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX[]>;

                                if (result == null)
                                {
                                    var items = D_SLView.Where(a =>
                                        a.SLGUID == D_SLGLSelectedItem.SLGUID && D_SLGLSelectedItem.DYID == a.DYID && D_SLGLSelectedItem.DYBB == a.DYBB);
                                    foreach(var item in items){
                                        item.SLZT = 3;
                                        item.SLZTX="挂起";
                                    }
                                }
                                
                                IsProcessed = true;
                            };
                            _AsyncWorker.RunWorkerAsync();
                        }
                    }),
                    (e => this.D_SLGLSelectedItem != null && D_SLGLSelectedItem.SLZT==2));
                }

                return _CMD_SLZT;
            }
        }

        private ICommand _CMD_SLHF;//恢复
        public ICommand CMD_SLHF
        {
            get
            {
                if (_CMD_SLHF == null)
                {
                    _CMD_SLHF = new RelayCommand((e =>
                    {
                        if (this.D_SLGLSelectedItem != null)
                        {
                            IsProcessed = false;
                            _AsyncWorker = new BackgroundWorker();
                            _AsyncWorker.DoWork += (obj, args) =>
                            {
                                var client = new S_GZLGL();
                                var voCZRZ = new VO_WF_CZRZ();
                                var voSLXX = new VO_WF_SLXX();
                                var voGZLHD = new VO_WF_GZLHD();
                                var voLZSXW = new VO_WF_LZSXW();
                                voCZRZ.CZLX = 2;
                                voSLXX.SLGUID = D_SLGLSelectedItem.SLGUID;
                                voSLXX.DYBB = D_SLGLSelectedItem.DYBB;
                                voSLXX.DYID = D_SLGLSelectedItem.DYID;
                                args.Result = client.WFGL_SLCL(voCZRZ, voSLXX, voGZLHD, voLZSXW);                               
                            };
                            _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX[]>;

                                if (result == null)
                                {
                                    var items = D_SLView.Where(a =>
                                        a.SLGUID == D_SLGLSelectedItem.SLGUID && D_SLGLSelectedItem.DYID == a.DYID && D_SLGLSelectedItem.DYBB == a.DYBB);
                                    foreach (var item in items)
                                    {
                                        item.SLZT = 2;
                                        item.SLZTX = "运行";
                                    }
                                }
                                IsProcessed = true;
                            };
                            _AsyncWorker.RunWorkerAsync();
                        }
                    }),
                    (e => this.D_SLGLSelectedItem != null && D_SLGLSelectedItem.SLZT==3));
                }

                return _CMD_SLHF;
            }
        }
        
        private ICommand _CMD_SLZZ;//终止
        public ICommand CMD_SLZZ
        {
            get
            {
                if (_CMD_SLZZ == null)
                {
                    _CMD_SLZZ = new RelayCommand((e =>
                    {
                        if (this.D_SLGLSelectedItem != null)
                        {                            
                            IsProcessed = false;
                            _AsyncWorker = new BackgroundWorker();
                            _AsyncWorker.DoWork += (obj, args) =>
                            {
                                var client = new S_GZLGL();
                                var voCZRZ = new VO_WF_CZRZ();
                                var voSLXX = new VO_WF_SLXX();
                                var voGZLHD = new VO_WF_GZLHD();
                                var voLZSXW = new VO_WF_LZSXW();
                                voCZRZ.CZLX = 3;
                                voSLXX.SLGUID = D_SLGLSelectedItem.SLGUID;
                                voSLXX.DYBB = D_SLGLSelectedItem.DYBB;
                                voSLXX.DYID = D_SLGLSelectedItem.DYID;                                
                                args.Result = client.WFGL_SLCL(voCZRZ,voSLXX,voGZLHD,voLZSXW);
                            };
                            _AsyncWorker.RunWorkerCompleted += (obj, args) =>
                            {
                                var result = args.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX[]>;

                                if (result == null)
                                {
                                    var items = D_SLView.Where(a =>
                                        a.SLGUID == D_SLGLSelectedItem.SLGUID && D_SLGLSelectedItem.DYID == a.DYID && D_SLGLSelectedItem.DYBB == a.DYBB);
                                    foreach (var item in items)
                                    {
                                        item.SLZT = 4;
                                        item.SLZTX = "结束";
                                    }
                                }
                                IsProcessed = true;
                            };
                            _AsyncWorker.RunWorkerAsync();                
                        }
                    }),
                    (e => this.D_SLGLSelectedItem != null));
                }

                return _CMD_SLZZ;
            }
        }

    }
}
