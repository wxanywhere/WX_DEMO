using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WX.WFA.ServiceChannel;
using WX.WFA.TempData;
using WX.WFA.ViewCommon;
using WX.WFA.ViewModel;
using WX.WFA.VO;

namespace WX.WFA.MainFrame
{
    public class VM_Login : ViewModelBase
    {
        private BackgroundWorker _AsyncWorker;
        private BackgroundWorker _AsyncChildWorker;

        public VM_Login()
        {
            D_CZY = new VO_WF_CZYB();
            D_CZY.CZYID = "SuperAdmin";
            D_MM.Password = "1";
        }

        private Window _BindedWindow = null;
        public Window BindedWindow
        {
            get
            {
                return _BindedWindow;
            }
            set
            {
                if (value!=null)
                {
                    value.Closing+=((o,e)=>
                    {
                        Application.Current.Shutdown();
                    });
                }

                _BindedWindow = value;
            }
        }

        private VO_WF_CZYB _D_CZY;
        public VO_WF_CZYB D_CZY
        {
            get
            {
                return _D_CZY;
            }
            set
            {
                if (_D_CZY != value)
                {
                    _D_CZY = value;
                    OnPropertyChanged("D_CZY");
                }
            }
        }

        private PasswordBox _D_MM;
        public PasswordBox D_MM
        {
            get
            {
                if (_D_MM == null)
                {
                    _D_MM = new PasswordBox();
                    _D_MM.Width = 150;
                    _D_MM.Height = 23;
                }
                return _D_MM;
            }
        }

        private void OpenMainFrame(FunctionInfo[] functions, VO_WF_CZYB vo_WF_CZYB)
        {
            this.HostWindow.Hide();
            var v = new WX.WFA.MainFrame.W_MainFrame();
            var vm = new WX.WFA.MainFrame.VM_MainFrame(functions, vo_WF_CZYB);
            Application.Current.MainWindow = v;
            v.DataContext = vm;
            vm.MainWindow = v;
            vm.InitializeSpecific();
            v.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            v.WindowState = WindowState.Maximized;
            v.Show();
        }

        private ICommand _CMD_Login;
        public ICommand CMD_Login
        {
            get
            {
                var functions=(FunctionInfo[])null;
                if (_CMD_Login == null)
                {
                    _CMD_Login = new RelayCommand((e =>
                    {
                        D_CZY.MM = D_MM.Password;
                        if (D_CZY.CZYID != null && !String.IsNullOrWhiteSpace(D_CZY.CZYID) && D_CZY.CZYID.Trim().ToLower().Equals("superadmin"))
                        {
                            if (D_CZY.MM.Equals("1"))
                            {
                                functions =
                                    DataSourceHelper.VO_XT_GNs.Select(a =>
                                    {
                                        return new FunctionInfo() { DisabledFlag = a.JYBZ, FunctionTitle = a.GNBT, FunctionName = a.GNMC, EntryTypeName = a.LXMC, AssemblyName = a.ZPMC, AssemblyUri = a.URI };
                                    }).ToArray();
                                OpenMainFrame(functions,D_CZY);
                            }
                            else
                            {
                                MessageX.ShowInfo("登录失败，操作员ID或密码错误！");
                            }
                        }
                        else
                        {
                            _AsyncWorker = new BackgroundWorker();
                            _AsyncWorker.DoWork += (obj, args) =>
                            {
                                var client = new S_XTGL();
                                args.Result = client.XTGL_CXDLCZY(D_CZY);
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
                                    else if (result.Item3 != null)
                                    {
                                        _AsyncChildWorker = new BackgroundWorker();
                                        _AsyncChildWorker.DoWork += (objx, argsx) =>
                                        {
                                            var client = new S_XTGL();
                                            var vo_WF_CZYQX = new VO_WF_CZQX();
                                            vo_WF_CZYQX.CZYID = D_CZY.CZYID;
                                            argsx.Result = client.XTGL_CXCZQX(vo_WF_CZYQX);
                                        };
                                        _AsyncChildWorker.RunWorkerCompleted += (objx, argsx) =>
                                        {
                                            try
                                            {
                                                var resultx = argsx.Result as Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX[]>;
                                                if (resultx.Item2 != null)
                                                {
                                                    MessageX.ShowError(resultx.Item2.TSXX);
                                                }
                                                else if (resultx.Item3 != null)
                                                {
                                                    functions =
                                                        DataSourceHelper.VO_XT_GNs
                                                          .Where(a => resultx.Item3.Any(b => b.GNID == a.GNID))
                                                          .Select(a =>
                                                        {
                                                            return new FunctionInfo() { DisabledFlag = a.JYBZ, FunctionTitle = a.GNBT, FunctionName = a.GNMC, EntryTypeName = a.LXMC, AssemblyName = a.ZPMC, AssemblyUri = a.URI };
                                                        }).ToArray();
                                                    OpenMainFrame(functions, result.Item3);
                                                }
                                                else
                                                {
                                                    MessageX.ShowInfo("获取操作员功能权限失败！");
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageX.ShowError(ex.Message);
                                            }

                                        };
                                        _AsyncChildWorker.RunWorkerAsync();
                                    }
                                    else
                                    {
                                        MessageX.ShowInfo("登录失败，操作员ID或密码错误！");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageX.ShowError(ex.Message);
                                }

                            };
                            _AsyncWorker.RunWorkerAsync();
                        }
                    }),
                    (e => !String.IsNullOrWhiteSpace(D_CZY.CZYID) &&
                        !string.IsNullOrWhiteSpace(D_MM.Password)));
                }

                return _CMD_Login;
            }
        }

        private ICommand _CMD_Exit;
        public ICommand CMD_Exit
        {
            get
            {
                if (_CMD_Exit == null)
                {
                    _CMD_Exit = new RelayCommand(e =>
                    {
                        Application.Current.Shutdown();
                    });
                }

                return _CMD_Exit;
            }
        }
    }
}
