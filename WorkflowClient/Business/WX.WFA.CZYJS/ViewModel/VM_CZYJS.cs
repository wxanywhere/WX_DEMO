using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WX.WFA.ViewModel;

namespace WX.WFA.CZYJS
{
    public class VM_CZYJS : ViewModelBase
    {

        private ICommand _CMD_Add;
        public ICommand CMD_Add
        {
            get
            {
                if (_CMD_Add == null)
                {
                    _CMD_Add = new RelayCommand(e =>
                    {
                        var vm = new VM_CZYJS_CZYAdd();
                        vm.RequestClose += (o, ex) =>
                        {
                           
                        };
                        this.ShowDialog(vm);
                    });
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
                    _CMD_Delete = new RelayCommand(e =>
                    {
                    });
                }

                return _CMD_Delete;
            }
        }
    }
}
