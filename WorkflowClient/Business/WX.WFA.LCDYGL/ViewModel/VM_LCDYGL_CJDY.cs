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

namespace WX.WFA.LCDYGL
{
   public class VM_LCDYGL_CJDY : ViewModelBase
    {
        public VM_LCDYGL_CJDY()
        {
            D_QueryEntity = new VO_WF_GZLDY();
            initDatagrid();
        }

        private VO_WF_GZLDY _D_QueryEntity;
        public VO_WF_GZLDY D_QueryEntity
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

        private List<VO_WF_GZLDY> TemData = new List<VO_WF_GZLDY>()
        { 
            //new VO_WF_GZLDY(){SLGUID=Guid.NewGuid(),DYID="001",DYBB=1,DYZT=0,DYMS="abc",DYRQ=DateTime.Now,DYSJ=DateTime.Now,QYRQ=DateTime.Now,QYSJ=DateTime.Now},
            //new VO_WF_GZLDY(){SLGUID=Guid.NewGuid(),DYID="002",DYBB=2,DYZT=0,DYMS="aaa",DYRQ=DateTime.Now,DYSJ=DateTime.Now,QYRQ=DateTime.Now,QYSJ=DateTime.Now},
            //new VO_WF_GZLDY(){SLGUID=Guid.NewGuid(),DYID="003",DYBB=3,DYZT=0,DYMS="bbb",DYRQ=DateTime.Now,DYSJ=DateTime.Now,QYRQ=DateTime.Now,QYSJ=DateTime.Now},
            //new VO_WF_GZLDY(){SLGUID=Guid.NewGuid(),DYID="004",DYBB=4,DYZT=0,DYMS="ccc",DYRQ=DateTime.Now,DYSJ=DateTime.Now,QYRQ=DateTime.Now,QYSJ=DateTime.Now},
            //new VO_WF_GZLDY(){SLGUID=Guid.NewGuid(),DYID="005",DYBB=5,DYZT=0,DYMS="ddd",DYRQ=DateTime.Now,DYSJ=DateTime.Now,QYRQ=DateTime.Now,QYSJ=DateTime.Now}
        };

        private ObservableCollection<VO_WF_GZLDY> _D_DYXXView;
        public ObservableCollection<VO_WF_GZLDY> D_DYXXView
        {
            get
            {
                if (_D_DYXXView == null)
                {
                    _D_DYXXView = new ObservableCollection<VO_WF_GZLDY>();
                }
                return _D_DYXXView;
            }

        }

        public void initDatagrid()
        {
            D_DYXXView.AddRange(TemData);
        }

        private VO_WF_GZLDY _D_DYSelectedItem;
        public VO_WF_GZLDY D_DYSelectedItem
        {
            get
            {
                return _D_DYSelectedItem;
            }
            set
            {
                if (_D_DYSelectedItem != value)
                {
                    _D_DYSelectedItem = value;
                    OnPropertyChanged("D_DYSelectedItem");
                }
            }
        }

    }
}
