using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.Serialization;
using YDTF.ORMSupportClasses;
using YDTF.VO;

namespace YDTF.VO
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VO_SYS_HEAD
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="czyh">����Ա��</param>
        /// <param name="jgbm">��������</param>
        public VO_SYS_HEAD(decimal czyh, string jgbm)
            : base(EntityName)
        {
            InitClassEmpty(null, CreateFields());
            this.Fields[(int)VO_SYS_HEADIndex.CZYH].CurrentValue = czyh;
            if (jgbm != "0")
            {
                this.Fields[(int)VO_SYS_HEADIndex.JGBM].CurrentValue = jgbm;
            }
            this.Fields[(int)VO_SYS_HEADIndex.CZDM].CurrentValue = 0m;
            this.Fields[(int)VO_SYS_HEADIndex.WKDZ].CurrentValue = GetWKZD();
        }

        /// <summary>
        /// ����MAC��ַ
        /// </summary>
        private static string WKZD;

        /// <summary>
        /// ��ȡ����MAC��ַ
        /// </summary>
        /// <returns></returns>
        private string GetWKZD()
        {
            if (string.IsNullOrEmpty(WKZD))
            {
                WKZD = GetMacAddress();
            }
            return WKZD;
        }

        /// <summary>
        /// ��ȡ����MAC��ַ��������ֻ���ص�һ��������MAC��ַ���������SYS_HAED����WKDZ
        /// </summary>
        /// <returns></returns>
        public static string GetMacAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc != null && moc.Count > 0)
            {
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"])
                    {
                        return mo["MacAddress"].ToString().Replace(':', '-');
                    }
                }
            }
            return "00-00-00-00-00-00";
        }

        /// <summary>
        ///����ȡIP��ַ
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddress()
        {
            try
            {
                string st = string.Empty;
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        System.Array ar = null;
                        ar = (System.Array)(mo.Properties["IpAddress"].Value);
                        st = ar.GetValue(0).ToString();
                        break;
                    }
                }
                moc = null;
                mc = null;
                return st;
            }
            catch
            {
                return "0";
            }
            finally
            {
            }
        }
    }
}