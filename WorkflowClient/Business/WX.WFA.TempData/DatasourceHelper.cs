using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.WFA.VO;

namespace WX.WFA.TempData
{
    public static class DataSourceHelper
    {
        public static VO_XT_GN[] VO_XT_GNs = new VO_XT_GN[]
        {

            //数据由配置文件或数据库获取
            new VO_XT_GN(){GNID="7b3974f0-82a5-4bbc-933a-02917cd2075f", JYBZ=true, GNBT="流程定义管理",GNMC="WX.WFA.LCDYGL", LXMC="VM_LCDYGL",ZPMC="WX.WFA.LCDYGL", URI="/WX.WFA.LCDYGL;Component/Resources/VMT_LCDYGL.xaml"},
            new VO_XT_GN(){GNID="4b5b06d9-cc02-4042-8560-b688c1cbe23c", JYBZ=true, GNBT="实例运行统计",GNMC="WX.WFA.YXTJ", LXMC="VM_YXTJ",ZPMC="WX.WFA.YXTJ", URI="/WX.WFA.YXTJ;Component/Resources/VMT_YXTJ.xaml"},
            new VO_XT_GN(){GNID="8c5d1b38-0d00-4880-8a6b-a33a35aeded5", JYBZ=true, GNBT="归档实例管理",GNMC="WX.WFA.LSSLGL", LXMC="VM_LSSLGL",ZPMC="WX.WFA.LSSLGL", URI="/WX.WFA.LSSLGL;Component/Resources/VMT_LSSLGL.xaml"},
            new VO_XT_GN(){GNID="985b2408-2ad6-4a78-9d5c-6bb0788d4fbc", JYBZ=true, GNBT="实例管理",GNMC="WX.WFA.SLGL", LXMC="VM_SLGL",ZPMC="WX.WFA.SLGL", URI="/WX.WFA.SLGL;Component/Resources/VMT_SLGL.xaml"},
            //new VO_XT_GN(){GNID="d749faaf-9e12-4c7a-870b-4f938ea341c9", JYBZ=true, GNBT="操作员管理示例",GNMC="WX.WFA.CZYGL.Demo", LXMC="VM_CZYGLX",ZPMC="WX.WFA.CZYGL.Demo", URI="/WX.WFA.CZYGL.Demo;Component/Resources/VMT_CZYGL.xaml"},
            new VO_XT_GN(){GNID="e28c7226-f49b-4c53-a998-2001362372a9", JYBZ=true, GNBT="操作员管理",GNMC="WX.WFA.CZYGL", LXMC="VM_CZYGL",ZPMC="WX.WFA.CZYGL", URI="/WX.WFA.CZYGL;Component/Resources/VMT_CZYGL.xaml"},
            new VO_XT_GN(){GNID="b43badc9-f87d-452e-992e-6a1250ac7ce8", JYBZ=true, GNBT="操作员权限管理",GNMC="WX.WFA.CZYQX", LXMC="VM_CZYQX",ZPMC="WX.WFA.CZYQX", URI="/WX.WFA.CZYQX;Component/Resources/VMT_CZYQX.xaml"},
            new VO_XT_GN(){GNID="91eeeef6-f044-41db-88f3-b8de37d34a53", JYBZ=true, GNBT="日志管理",GNMC="WX.WFA.RZGL", LXMC="VM_RZGL",ZPMC="WX.WFA.RZGL", URI="/WX.WFA.RZGL;Component/Resources/VMT_RZGL.xaml"}
        };

        public static VO_XT_JS[] VO_XT_JSs = new VO_XT_JS[]
        {
            new VO_XT_JS(){JSID="73d993de-4223-4f4b-9204-b1883c716342",JSMC="超级管理员",JSMS=""},
            new VO_XT_JS(){JSID="13ff6213-c25b-4391-afaa-280952994a00",JSMC="管理员",JSMS=""},
            new VO_XT_JS(){JSID="e6783ec3-76b5-4238-8217-702fcf5bf213",JSMC="角色A",JSMS=""},
            new VO_XT_JS(){JSID="ce8ca25a-8fe6-4460-9670-dd5682e97d01",JSMC="角色B",JSMS=""},
            new VO_XT_JS(){JSID="84bf0bb4-d20d-4c0b-857a-e0e19026d0fc",JSMC="角色C",JSMS=""},
            new VO_XT_JS(){JSID="c95c879e-641c-48cb-8e5c-7050ad464f96",JSMC="角色D",JSMS=""},
            new VO_XT_JS(){JSID="0b6fb3a9-f407-46ca-8d87-b3df1cc9fe13",JSMC="角色E",JSMS=""}
        };

    }
}
