using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WX.WFA.ViewModel;
using WX.WFA.VO;
using WX.WFA.DataModelBase;
using WX.WFA.Common;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.ComponentModel;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;

namespace WX.WFA.CZYGL
{
    public class VM_CZYGL_CZYAdd:ViewModelBase
    {
        public VM_CZYGL_CZYAdd()
        {
            Initialize();
        }

        private VO_WF_CZYB _D_CZYNew;
        public VO_WF_CZYB D_CZYNew
        {
            get
            {
                return _D_CZYNew;
            }
            set
            {
                if (_D_CZYNew != value)
                {
                    _D_CZYNew = value;
                    OnPropertyChanged("D_CZYNew");
                }
            }
        }

        private ObservableCollection<KeyValue<decimal, string>> _D_ZTItems;
        public ObservableCollection<KeyValue<decimal, string>> D_ZTItems
        {
            get
            {
                if (_D_ZTItems == null)
                {
                    _D_ZTItems = new ObservableCollection<KeyValue<decimal, string>>();
                }
                return _D_ZTItems;
            }

        }

        private KeyValue<decimal,string> _D_ZTSelectedItem;
        public KeyValue<decimal, string> D_ZTSelectedItem
        {
            get
            {
                return _D_ZTSelectedItem;
            }
            set
            {
                if (_D_ZTSelectedItem != value)
                {
                    _D_ZTSelectedItem = value;
                    OnPropertyChanged("D_ZTSelectedItem");
                    if (value != null)
                    {
                      D_CZYNew.DCZT = value.Key;
                      D_CZYNew.DQZTX = value.Value;
                    }
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
                    _D_MM.Height = 23;
                    _D_MM.PasswordChanged += (o, e) => D_CZYNew.MM = _D_MM.Password;
                }
                return _D_MM;
            }
        }

        private PasswordBox _D_MMX;
        public PasswordBox D_MMX
        {
            get
            {
                if (_D_MMX == null)
                {
                    _D_MMX = new PasswordBox();
                    _D_MMX.Height = 23;
                    _D_MMX.PasswordChanged += (o, e) => D_CZYNew.MM = _D_MMX.Password;
                }
                return _D_MMX;
            }
        }

        private ICommand _CMD_Save;
        public ICommand CMD_Save
        {
            get
            {
                if (_CMD_Save == null)
                {
                    _CMD_Save = new RelayCommand((a =>
                    {
                        if(String.IsNullOrWhiteSpace(D_MM.Password) ||
                            String.IsNullOrWhiteSpace(D_MMX.Password) ||
                            D_MM.Password!=D_MMX.Password)
                        {
                            MessageX.ShowInfo("两次密码输入不一致");
                            return;
                        }
                        IsProcessed = false;
                        var asyncWorker = new BackgroundWorker();
                        asyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_XTGL();
                            args.Result = client.XTGL_BCCZY(D_CZYNew);
                        };
                        asyncWorker.RunWorkerCompleted += (obj, args) =>
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
                                    result.Item3.CJRQX = DateTimeHelper.GetDateTime(result.Item3.CJRQ, result.Item3.CJSJ);
                                    result.Item3.DQZTX = result.Item3.DCZT == 1 ? "可用" : "不可用";
                                    this.CloseCommand.Execute(result.Item3);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageX.ShowError(ex.Message);
                            }
                            IsProcessed = true;
                        };
                        asyncWorker.RunWorkerAsync();
                        
                    }),
                    (a => D_CZYNew.IsDirty && D_CZYNew.Validate()));

                }
                return this._CMD_Save;
            }
        }

        public void Initialize()
        {
            Title = "增加操作员";
            _D_CZYNew = new VO_WF_CZYB();
            _D_CZYNew.CZYBH = Guid.NewGuid().ToString();
            _D_CZYNew.PZID = Guid.NewGuid().ToString();
            D_ZTItems.Clear();
            D_ZTItems.Add(new KeyValue<decimal,string>(0,"不可用"));
            D_ZTItems.Add(new KeyValue<decimal, string>(1, "可用"));
            D_ZTSelectedItem = D_ZTItems[1];
            this.StartEdit(D_CZYNew, "D_CZYNew");
        }
    }
}
