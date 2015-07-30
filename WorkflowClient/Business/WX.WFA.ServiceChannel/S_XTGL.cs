using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WX.WFA.ISOAClient;
using WX.WFA.ServiceContract;
using WX.WFA.VO;

namespace WX.WFA.ServiceChannel
{
    public class S_XTGL:IS_XTGL
    {
        private static readonly string ServicePrifix = "WF.XTGL.";

        //--------------操作管理

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB[]> XTGL_CXCZY(VO_WF_CZYB vo_WF_CZYB)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZYB);

            return result;
        }

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB> XTGL_BCCZY(VO_WF_CZYB vo_WF_CZYB)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZYB);

            return new Tuple<VOX_SYS_HEAD,VOX_SYS_ERROR,VO_WF_CZYB>(result.Item1,result.Item2,result.Item3!=null ? result.Item3[0]:null);
        }

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB> XTGL_SCCZY(VO_WF_CZYB vo_WF_CZYB)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZYB);

            return new Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(result.Item1, result.Item2, result.Item3 != null ? result.Item3[0] : null);
        }

        //--------------操作权限

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB[]> XTGL_CXGNCZY(VO_WF_CZQX vo_WF_CZQX)
        {
          var client = new ServiceClient();
          var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
          var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZQX);

          return result;
        }

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB[]> XTGL_CXWGNCZY(VO_WF_CZQX vo_WF_CZQX)
        {
          var client = new ServiceClient();
          var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
          var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZQX);

          return result;
        }

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX> XTGL_ZJGNCZY(VO_WF_CZQX[] vo_WF_CZQX)
        {
          var client = new ServiceClient();
          var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
          var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZQX);

          return new Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX>(result.Item1, result.Item2, result.Item3 != null ? result.Item3[0] : null);
        }

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX> XTGL_SCGNCZY(VO_WF_CZQX[] vo_WF_CZQX)
        {
          var client = new ServiceClient();
          var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
          var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZQX);

          return new Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX>(result.Item1, result.Item2, result.Item3 != null ? result.Item3[0] : null);
        }

        //--------------操作员登录

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX[]> XTGL_CXCZQX(VO_WF_CZQX vo_WF_CZQX)
        {
          var client = new ServiceClient();
          var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
          var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZQX>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZQX);

          return result;
        }

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB> XTGL_CXDLCZY(VO_WF_CZYB vo_WF_CZYB)
        {
          var client = new ServiceClient();
          var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
          var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZYB);

          return new Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZYB>(result.Item1, result.Item2, result.Item3 != null ? result.Item3[0] : null);
        }



        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZRZ[]> XTGL_CXCZRZ(VO_WF_CZRZ vo_WF_CZRZ)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, String.Empty, true);
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_CZRZ>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_CZRZ);

            return result;
        }
    }
}
