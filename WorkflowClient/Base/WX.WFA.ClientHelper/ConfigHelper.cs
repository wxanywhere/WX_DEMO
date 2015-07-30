using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.ClientHelper
{
    public static class ConfigHelper
    {
        public static readonly string URLS = ConfigurationManager.AppSettings["URLS"];
        public static readonly string PACKING_TYPE = ConfigurationManager.AppSettings["PACKING_TYPE"];
        public static readonly string ENTITY_PROFIX = ConfigurationManager.AppSettings["ENTITY_PROFIX"];
        public static readonly string OPERATION_CODE_FIELD_NAME = ConfigurationManager.AppSettings["OPERATION_CODE_FIELD_NAME"];

        public static readonly string HEADER_ENCODING = ConfigurationManager.AppSettings["HEADER_ENCODING"];
        public static readonly string ERROR_ENCODING = ConfigurationManager.AppSettings["ERROR_ENCODING"];
        public static readonly string DATA_ENCODING = ConfigurationManager.AppSettings["DATA_ENCODING"];
    }
}
