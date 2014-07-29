using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Rift.UK.Client.RGI2.Connector.Helper_Classes
{
    public static class ConnectorHelper
    {
        public static WebRequest SetUpWebRequestObject(WebRequest httpWebRequest)
        {
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            return httpWebRequest;
        }

        public static string ChangeArrayParentheses(string jsonResult)
        {
            jsonResult = jsonResult.Replace(":[]", ":{}");
            return jsonResult;
        }
    }
}
