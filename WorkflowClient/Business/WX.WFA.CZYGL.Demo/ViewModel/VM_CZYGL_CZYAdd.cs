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

        private ICommand _CMD_Save;
        public ICommand CMD_Save
        {
            get
            {
                if (_CMD_Save == null)
                {
                    _CMD_Save = new RelayCommand(a =>
                    { 
                        //保存到数据库...

                        this.CloseCommand.Execute(D_CZYNew);
                    });

                }
                return this._CMD_Save;
            }
        }

        public void Initialize()
        {
            Title = "增加操作员";
            _D_CZYNew = new VO_WF_CZYB();
            _D_CZYNew.PZID = Guid.NewGuid().ToString();
            this.StartEdit(D_CZYNew, "D_CZYNew");

        }
    }
}
