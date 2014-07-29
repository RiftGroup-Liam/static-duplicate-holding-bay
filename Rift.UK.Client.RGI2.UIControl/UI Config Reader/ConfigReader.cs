using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Configuration;

namespace Rift.UK.Client.RGI2.UIControl.UI_Config_Reader
{
    public static class ConfigReader
    {
        public static string ReadServiceImportUserUSERNAME()
        { 
            string serviceImportUsername = string.Empty;
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            serviceImportUsername = appSettings["ServerImportingUser_USERNAME"];
            return serviceImportUsername;
        }

        public static string ReadClientLogFilePathFromConfig()
        {
            string filePath = string.Empty;
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            filePath = appSettings["LogDirectory"];
            return filePath;
        }
    }
}
