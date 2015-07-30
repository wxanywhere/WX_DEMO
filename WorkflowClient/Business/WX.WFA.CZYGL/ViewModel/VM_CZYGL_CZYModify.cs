using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WX.WFA.Common;
using WX.WFA.DataModelBase;
using WX.WFA.ServiceChannel;
using WX.WFA.ViewCommon;
using WX.WFA.ViewModel;
using WX.WFA.VO;

namespace WX.WFA.CZYGL
{
    public class VM_CZYGL_CZYModify:ViewModelBase
    {

        private VO_WF_CZYB _D_CZYModify;
        public VO_WF_CZYB D_CZYModify
        {
            get
            {
                return _D_CZYModify;
            }
            set
            {
                if (_D_CZYModify != value)
                {
                    _D_CZYModify = value;
                    OnPropertyChanged("D_CZYModify");
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

        private KeyValue<decimal, string> _D_ZTSelectedItem;
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
                    if(value!=null){
                        D_CZYModify.DCZT = value.Key;
                        D_CZYModify.DQZTX = value.Value;
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
                    _D_MM.PasswordChanged += (o, e) => D_CZYModify.MM = _D_MM.Password;
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
                    _D_MMX.PasswordChanged += (o, e) => D_CZYModify.MM = _D_MMX.Password;
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
                        if (String.IsNullOrWhiteSpace(D_MM.Password) ||
                            String.IsNullOrWhiteSpace(D_MMX.Password) ||
                            D_MM.Password != D_MMX.Password)
                        {
                            MessageX.ShowInfo("两次密码输入不一致");
                            return;
                        }
                        IsProcessed = false;
                        var asyncWorker = new BackgroundWorker();
                        asyncWorker.DoWork += (obj, args) =>
                        {
                            var client = new S_XTGL();
                            args.Result = client.XTGL_BCCZY(D_CZYModify);
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
                                MessageBox.Show(ex.Message, "错误信息", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            IsProcessed = true;
                        };
                        asyncWorker.RunWorkerAsync();
                    }),
                    (a => D_CZYModify.IsDirty && D_CZYModify.Validate()));
                }
                return this._CMD_Save;
            }
        }

        public void Initialize(VO_WF_CZYB d_CZYOriginal)
        {
            Title = "修改操作员";
            _D_CZYModify = d_CZYOriginal.Clone<VO_WF_CZYB>();
            D_MM.Password = d_CZYOriginal.MM;
            D_MMX.Password = d_CZYOriginal.MM;
            D_ZTItems.Clear();
            D_ZTItems.Add(new KeyValue<decimal, string>(0, "不可用"));
            D_ZTItems.Add(new KeyValue<decimal, string>(1, "可用"));
            D_ZTSelectedItem = D_ZTItems.FirstOrDefault(a => a.Key == d_CZYOriginal.DCZT);
            this.StartEdit(D_CZYModify, "D_CZYModify");
        }
    }
}
