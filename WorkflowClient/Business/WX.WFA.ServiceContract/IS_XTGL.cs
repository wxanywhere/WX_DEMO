using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.WFA.VO;

namespace WX.WFA.ServiceContract
{
    public interface IS_XTGL
    {

        //--------------操作管理
        
        //查询操作员
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB[]> XTGL_CXCZY(VO_WF_CZYB vo_WF_CZYB);

        //保存操作员
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR,VO_WF_CZYB> XTGL_BCCZY(VO_WF_CZYB vo_WF_CZYB);

        //删除操作员
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB> XTGL_SCCZY(VO_WF_CZYB vo_WF_CZYB);

        //--------------操作权限

        //查询拥有指定权限的操作员
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB[]> XTGL_CXGNCZY(VO_WF_CZQX vo_WF_CZQX);

        //查询无指定功能的操作员元
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB[]> XTGL_CXWGNCZY(VO_WF_CZQX vo_WF_CZQX);

        //增加指定权限的操作员
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX> XTGL_ZJGNCZY(VO_WF_CZQX[] vo_WF_CZQX);

        //删除指定权限的操作员
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX> XTGL_SCGNCZY(VO_WF_CZQX[] vo_WF_CZQX);

        //--------------操作员登录

        //操作员登录查询
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB> XTGL_CXDLCZY(VO_WF_CZYB vo_WF_CZYB);

        //查询操作员权限
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX[]> XTGL_CXCZQX(VO_WF_CZQX vo_WF_CZQX);

        //查询操作日志
        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZRZ[]> XTGL_CXCZRZ(VO_WF_CZRZ vo_WF_CZRZ);
    }
}
