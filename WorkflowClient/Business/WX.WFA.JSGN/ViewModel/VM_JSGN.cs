using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WX.WFA.ViewModel;

namespace WX.WFA.JSGN
{
    public class VM_JSGN:ViewModelBase
    {
        private ICommand _CMD_Edit;
        public ICommand CMD_Edit
        {
            get
            {
                if (_CMD_Edit == null)
                {
                    _CMD_Edit = new RelayCommand(e =>
                    {
                        var vm = new VM_JSGN_Edit();
                        vm.RequestClose += (o, ex) =>
                        {

                        };
                        this.ShowDialog(vm);
                    });
                }

                return _CMD_Edit;
            }
        }
    }
}
