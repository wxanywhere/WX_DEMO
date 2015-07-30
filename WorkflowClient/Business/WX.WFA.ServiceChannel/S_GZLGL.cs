using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WX.WFA.ServiceContract;
using WX.WFA.VO;
using System.Reflection;
using WX.WFA.ISOAClient;

namespace WX.WFA.ServiceChannel
{
    public class S_GZLGL : IS_GZLGL
    {
        private static readonly string ServicePrifix = "WF.WFGL.";

        //public Tuple<VO_SYS_HEAD, VO_WF_SLXXX, VO_WF_SLXXX[]> WFGL_CXSLXXA(VO_WF_SLXXX vo_WF_SLXX)
        //{
        //    var client = new ServiceClient();
        //    var sysHead = new VO_SYS_HEAD(0,String.Empty);
        //    sysHead.IsSysHead = true;
        //    var result = client.CallService<VO_SYS_HEAD, VO_WF_SLXXX, VO_WF_SLXXX>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_SLXX);


        //    return new Tuple<VO_SYS_HEAD, VO_WF_SLXXX,VO_WF_SLXXX[]>(result.Item1,result.Item2,result.Item3);
        //}

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX[]> S09_WFGL_CXSLXX(VO_WF_SLXX vo_WF_SLXX)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, String.Empty,true);
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX>(ServicePrifix + MethodBase.GetCurrentMethod().Name, sysHead, vo_WF_SLXX);


            return new Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX[]>(result.Item1, result.Item2, result.Item3);
        }

        public Tuple<VO_SYS_HEAD,VOX_SYS_ERROR,VO_WF_SLXX[]> WFGL_CXSLXX_IDPC(VO_WF_SLXX vo_WF_SLXX)
        {
            var client = new ServiceClient(PackingProviderType.ValuePackingProvider, "OP_CODE");
            var sysHead = new VO_SYS_HEAD(true);
            var sysSvc = new VO_SYS_SVC(true);
            var svcName = "IDP.WF.WFGL_CXSLXX";  //ServicePrifix + MethodBase.GetCurrentMethod().Name;
            sysSvc.SVC_NAME = svcName;
            var result = client.CallService<VO_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX>(svcName, sysHead,sysSvc, vo_WF_SLXX);


            return result;
        }

        public Tuple<VO_SYS_HEAD, VOX_SYS_ERROR, VO_WF_GZLDY[]> WFDY_CXLCDY_IDPC(VO_WF_GZLDY vo_WF_SLXX)
        {
            var client = new ServiceClient(PackingProviderType.ValuePackingProvider, "OP_CODE");
            var sysHead = new VO_SYS_HEAD(true);
            var sysSvc = new VO_SYS_SVC(true);
            var svcName = "IDP.WF.WFDY_CXLCDY";  //ServicePrifix + MethodBase.GetCurrentMethod().Name;
            sysSvc.SVC_NAME = svcName;
            var result = client.CallService<VO_SYS_HEAD, VOX_SYS_ERROR, VO_WF_GZLDY>(svcName, sysHead, sysSvc, vo_WF_SLXX);


            return result;
        }

        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX[]> WFGL_CXSLXX(VO_WF_SLXX vo_WF_SLXX)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0,"",true);
            String ServicePrifix = "WF.WFGL.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX>(svcName, sysHead, vo_WF_SLXX);

            return result;
        }

        public Tuple<VO_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX[]> WFGL_CXSLXX01(VO_WF_SLXX vo_WF_SLXX)
        {
            throw new NotImplementedException();
        }



        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_GZLDY[]> WFDY_CXLCDY(VO_WF_GZLDY vo_WF_GZLDY)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, "", true);
            String ServicePrifix = "WF.WFDY.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_GZLDY>(svcName, sysHead, vo_WF_GZLDY);

            return result;
        }


        Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX[]> IS_GZLGL.WFGL_CXSLXX01(VO_WF_SLXX vo_WF_SLXX)
        {
            throw new NotImplementedException();
        }


        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX[]> WFGL_CXSLXX_LS(VO_WF_SLXX_LS vo_WF_SLXX_LS)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, "", true);
            String ServicePrifix = "WF.WFGL.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX_CX>(svcName, sysHead, vo_WF_SLXX_LS);

            return result;
        }


        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLTJ_CX[]> WFGL_SLTJ(VO_WF_SLTJ_CX vo_WF_SLTJ)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, "", true);
            String ServicePrifix = "WF.WFGL.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLTJ_CX>(svcName, sysHead, vo_WF_SLTJ);

            return result;
        }


        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZXX_LS[]> WFGL_CXLZXX_LS(VO_WF_LZXX_LS vo_WF_LZXX_LS)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, "", true);
            String ServicePrifix = "WF.WFGL.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZXX_LS>(svcName, sysHead, vo_WF_LZXX_LS);

            return result;
        }


        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZXX[]> WFGL_CXLZXX(VO_WF_LZXX vo_WF_LZXX)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, "", true);
            String ServicePrifix = "WF.WFGL.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZXX>(svcName, sysHead, vo_WF_LZXX);
            return result;
        }


        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZSXW[]> WFGL_CXLZSXW(VO_WF_LZSXW vo_WF_LZSXW)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, "", true);
            String ServicePrifix = "WF.WFGL.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_LZSXW>(svcName, sysHead, vo_WF_LZSXW);
            return result;
        }


        public Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX> WFGL_SLCL(VO_WF_CZRZ vo_WF_CZRZ, VO_WF_SLXX vo_WF_SLXX, VO_WF_GZLHD vo_WF_GZLHD, VO_WF_LZSXW vo_WF_LZSXW)
        {
            var client = new ServiceClient();
            var sysHead = new VOX_SYS_HEAD(0, "", true);
            String ServicePrifix = "WF.WFGL.";
            var svcName = ServicePrifix + MethodBase.GetCurrentMethod().Name;
            var result = client.CallService<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX>(svcName, sysHead, vo_WF_CZRZ,vo_WF_SLXX,vo_WF_GZLHD,vo_WF_LZSXW);
            if (result.Item3.Length > 0)
                return new Tuple<VOX_SYS_HEAD, VOX_SYS_ERROR, VO_WF_SLXX>(result.Item1, result.Item2, result.Item3[0]);
            else
                return null;
        }
    }
}
