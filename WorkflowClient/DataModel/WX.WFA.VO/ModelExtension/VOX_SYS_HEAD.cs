using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.Serialization;

namespace WX.WFA.VO
{
    /// <summary>
    /// 
    /// </summary>
    public partial class VOX_SYS_HEAD
    {
        public VOX_SYS_HEAD(bool isHeadPart)
        {
            IsHeadPart = isHeadPart;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="czyh">����Ա��</param>
        /// <param name="jgbm">��������</param>
        public VOX_SYS_HEAD(decimal czyh, string jgbm, bool isHeadPart)
            : base()
        {
            this.SetValue<decimal>(VOE_SYS_HEAD.CZYH, czyh);
            if (jgbm != "0")
            {
                this.SetValue<string>(VOE_SYS_HEAD.JGBM, jgbm);
            }
            this.SetValue<decimal>(VOE_SYS_HEAD.CZDM, 0m);
            this.SetValue<string>(VOE_SYS_HEAD.WKDZ, GetWKZD());
            IsHeadPart = isHeadPart;
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