using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Rift.UK.Core.RGI2.REO;
using Rift.UK.Core.RGI2.REO.DeserializationObjects;
using Rift.UK.Client.RGI2.Connector.Helper_Classes;
using Rift.UK.Core.RGI2.REO.SerializationObjects;
using Rift.UK.Core.RGI2.REO.Logging;

namespace Rift.UK.Client.RGI2.Connector
{
    public class UserConnector
    {
        string userServiceAddress;
        public UserConnector()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            userServiceAddress = appSettings["UserServiceAddress"];
        }

        public User GetUser(string systemName)
        {
            User currentUser = new User();
            string jsonResult = string.Empty;
            UserServiceDO userServiceDO = new UserServiceDO();

            string URL = string.Format("{0}GetUser/{1}", userServiceAddress, systemName);

            try
            {
                WebClient serviceRequest = new WebClient();
                jsonResult = serviceRequest.DownloadString(new Uri(URL));
                jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
            }
            catch (Exception ex) { ClientLogger.WriteError(ex, "Error getting user\nMethod: UserConnector.GetUser", systemName); }

            userServiceDO = JsonConvert.DeserializeObject<UserServiceDO>(jsonResult);
            currentUser = userServiceDO.GetUserResult;
            return currentUser;
        }

        public bool CheckAccessToRGI2(string systemName)
        {
            bool allowed = false;
            string jsonResult = string.Empty;
            UserServiceDO userServiceDO = new UserServiceDO();

            string URL = string.Format("{0}CheckAccessToRGI2/{1}", userServiceAddress, systemName);

            try
            {
                WebClient serviceRequest = new WebClient();
                jsonResult = serviceRequest.DownloadString(new Uri(URL));
                jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
            }
            catch (Exception ex) { ClientLogger.WriteError(ex, "Error getting access for user\nMethod: UserConnector.CheckAccessToRGI2", systemName); }

            userServiceDO = JsonConvert.DeserializeObject<UserServiceDO>(jsonResult);
            allowed = userServiceDO.CheckAccessToRGI2Result;
            return allowed;
        }
    }
}
