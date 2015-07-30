using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
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

        private ICommand _CMD_Save;
        public ICommand CMD_Save
        {
            get
            {
                if (_CMD_Save == null)
                {
                    _CMD_Save = new RelayCommand(a =>
                    {
                        this.CloseCommand.Execute(_D_CZYModify);
                    });

                }
                return this._CMD_Save;
            }
        }

        public void Initialize(VO_WF_CZYB d_CZYOriginal)
        {
            Title = "修改操作员";
            _D_CZYModify = d_CZYOriginal.Clone<VO_WF_CZYB>();
            this.StartEdit(D_CZYModify, "D_CZYModify");
        }
    }
}
