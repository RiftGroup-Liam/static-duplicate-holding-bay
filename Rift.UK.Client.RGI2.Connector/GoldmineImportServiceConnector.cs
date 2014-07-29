using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Configuration;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Rift.UK.Core.RGI2.REO.Logging;
using Rift.UK.Core.RGI2.REO;
using Rift.UK.Core.RGI2.REO.DeserializationObjects;
using Rift.UK.Client.RGI2.Connector.Helper_Classes;
using Rift.UK.Core.RGI2.REO.SerializationObjects;


namespace Rift.UK.Client.RGI2.Connector
{
    public class GoldmineImportServiceConnector
    {
        string goldmineImportServiceAddress;
        public GoldmineImportServiceConnector()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            goldmineImportServiceAddress = appSettings["GoldmineImportServiceAddress"];
        }

        public List<GMPossibleDuplicate> GetPossibleDuplicates(int recordCounter)
        {
            List<GMPossibleDuplicate> possibleDuplicates = new List<GMPossibleDuplicate>();
            string jsonResult = string.Empty;
            GoldmineImportServiceDO goldmineImportServiceDO = new GoldmineImportServiceDO();

            string URL = string.Format("{0}GetPossibleDuplicates/{1}", goldmineImportServiceAddress, recordCounter.ToString());

            try
            {
                WebClient serviceRequest = new WebClient();
                jsonResult = serviceRequest.DownloadString(new Uri(URL));
                jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
            }
            catch (Exception ex) 
            {
                ClientLogger.WriteError(ex, "Error retrieving the possible duplicate list.\nMethod: GoldmineImportServiceConnector.GetPossibleDuplicates", ClientGlobalData.CurrentUser.SystemName); 
                throw ex; 
            }

            try
            {
                goldmineImportServiceDO = JsonConvert.DeserializeObject<GoldmineImportServiceDO>(jsonResult);
                possibleDuplicates = goldmineImportServiceDO.GetPossibleDuplicatesResult;
            }
            catch (Exception ex)
            {
                ClientLogger.WriteError(ex, "Error deserializing the possible duplicate list.\nMethod: GoldmineImportServiceConnector.GetPossibleDuplicates", ClientGlobalData.CurrentUser.SystemName); 
            }
            return possibleDuplicates;
        }

        public MatchingDetails GetMatchingDetails(string lastname, string postCode, string PHONE1, string PHONE2, string UEMAILADDR)
        {
            MatchingDetails matchingDetails = new MatchingDetails();
            string jsonResult = string.Empty;
            GetMatchingDetailsSO getMatchingDetailsSO = new GetMatchingDetailsSO();
            GoldmineImportServiceDO goldmineImportServiceDO = new GoldmineImportServiceDO();
            string getMatchingDetailsSOAsJson = string.Empty;

            // set getMatchingDetailSO Properties
            getMatchingDetailsSO = PropertyAddition.SetGetMatchingDetailsSOProperties(lastname, postCode, PHONE1, PHONE2, UEMAILADDR, getMatchingDetailsSO);

            // Create URL and WebRequest Object
            string URL = string.Format("{0}GetMatchingDetails", goldmineImportServiceAddress);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            httpWebRequest = ConnectorHelper.SetUpWebRequestObject(httpWebRequest);

            getMatchingDetailsSOAsJson = SerializationHelper.SerializeGetMatchingDetailsSO(getMatchingDetailsSO);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            { 
                // send request to service
                try
                {
                    streamWriter.Write(getMatchingDetailsSOAsJson);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    ClientLogger.WriteError(ex, "Error retrieving the matching details.\nMethod: GoldmineImportServiceConnector.GetMatchingDetails", ClientGlobalData.CurrentUser.SystemName); 
                    throw ex; 
                }

                // get response object
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    jsonResult = streamReader.ReadToEnd();
                    jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
                }

                // deserialize
                try
                {
                    goldmineImportServiceDO = JsonConvert.DeserializeObject<GoldmineImportServiceDO>(jsonResult);
                    matchingDetails = goldmineImportServiceDO.GetMatchingDetailsResult;
                }
                catch (Exception ex) 
                {
                    ClientLogger.WriteError(ex, "Error deserializing the matching details.\nMethod: GoldmineImportServiceConnector.GetMatchingDetails", ClientGlobalData.CurrentUser.SystemName); 
                    HandleDeserializationException(ex);
                }
            }
            return matchingDetails;
        }

        public string ImportContact(GMPossibleDuplicate possibleDuplicate, User user)
        {
            string returnedRecId = string.Empty;
            string jsonResult = string.Empty;
            ImportContactSO importContactSO = new ImportContactSO();
            GoldmineImportServiceDO goldmineImportServiceDO = new GoldmineImportServiceDO();
            string importContactSOAsJson = string.Empty;

            // set importContactSO properties
            importContactSO = PropertyAddition.SetImportContactSOProperties(importContactSO, possibleDuplicate, user);

            // create URL and WebRequestObject
            string URL = string.Format("{0}ImportContact", goldmineImportServiceAddress);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            httpWebRequest = ConnectorHelper.SetUpWebRequestObject(httpWebRequest);

            importContactSOAsJson = SerializationHelper.SerializeImportContactSO(importContactSO);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            { 
                // send request to service
                try
                {
                    streamWriter.Write(importContactSOAsJson);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                catch (Exception ex) 
                {
                    ClientLogger.WriteError(ex, "Error importing contact.\nMethod: GoldmineImportServiceConnector.ImportContact", ClientGlobalData.CurrentUser.SystemName); 
                    throw ex;
                }

                // get response object
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    jsonResult = streamReader.ReadToEnd();
                    jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
                }

                // deserialize 
                try
                {
                    goldmineImportServiceDO = JsonConvert.DeserializeObject<GoldmineImportServiceDO>(jsonResult);
                    returnedRecId = goldmineImportServiceDO.ImportContactResult;
                }
                catch (Exception ex)
                {
                    ClientLogger.WriteError(ex, "Error deserializing result from importing contact.\nMethod: GoldmineImportServiceConnector.ImportContact", ClientGlobalData.CurrentUser.SystemName); 
                    HandleDeserializationException(ex);
                }
            }

            return returnedRecId;
        }

        public string CreateHistoryRecordForRiftId(GMPossibleDuplicate selectedPossibleDuplicate, string riftId, User user)
        {
            string returnedRecId = string.Empty;
            string jsonResult = string.Empty;
            CreateHistoryRecordForRiftIdSO createHistoryRecordForRiftIdSO = new CreateHistoryRecordForRiftIdSO();
            GoldmineImportServiceDO goldmineImportServiceDO = new GoldmineImportServiceDO();
            string createHistoryRecordForRiftIdSOAsJson = string.Empty;

            // set createHistoryRecordForRiftIdSO properties
            createHistoryRecordForRiftIdSO = PropertyAddition.SetCreateHistoryRecordForRiftIdSO(createHistoryRecordForRiftIdSO, selectedPossibleDuplicate, riftId, user);

            // create URL and WebRequestObject
            string URL = string.Format("{0}CreateHistoryRecordForRiftId", goldmineImportServiceAddress);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            httpWebRequest = ConnectorHelper.SetUpWebRequestObject(httpWebRequest);

            createHistoryRecordForRiftIdSOAsJson = SerializationHelper.SerializeCreateHistoryRecordForRiftIdSO(createHistoryRecordForRiftIdSO);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            { 
                // send request to service
                try
                {
                    streamWriter.Write(createHistoryRecordForRiftIdSOAsJson);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    ClientLogger.WriteError(ex, "Error creating history record for contact.\nMethod: GoldmineImportServiceConnector.CreateHistoryRecordForRiftId", ClientGlobalData.CurrentUser.SystemName); 
                    throw ex; 
                }

                // get response object 
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    jsonResult = streamReader.ReadToEnd();
                    jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
                }

                // deserialize
                try
                {
                    goldmineImportServiceDO = JsonConvert.DeserializeObject<GoldmineImportServiceDO>(jsonResult);
                    returnedRecId = goldmineImportServiceDO.CreateHistoryRecordForRiftIdResult;
                }
                catch (Exception ex)
                {
                    ClientLogger.WriteError(ex, "Error deserializing result for creating a history record for contact.\nMethod: GoldmineImportServiceConnector.CreateHistoryRecordForRiftId", ClientGlobalData.CurrentUser.SystemName); 
                    HandleDeserializationException(ex);
                }
            }
            return returnedRecId;
        }

        public bool DeletePossibleDuplicate(GMPossibleDuplicate selectedPossibleDuplicate, User user)
        {
            bool deletionSuccess = false;
            string jsonResult = string.Empty;
            string deletePossibleDuplicateSOAsJson = string.Empty;
            DeletePossibleDuplicateSO deletePossibleDuplicateSO = new DeletePossibleDuplicateSO();
            GoldmineImportServiceDO goldmineImportServiceDO = new GoldmineImportServiceDO();
                        
            deletePossibleDuplicateSO = PropertyAddition.SetDeletePossibleDuplicateSOProperties(deletePossibleDuplicateSO, selectedPossibleDuplicate, user);
            
            string URL = string.Format("{0}DeletePossibleDuplicate", goldmineImportServiceAddress);
            WebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            httpWebRequest = ConnectorHelper.SetUpWebRequestObject(httpWebRequest);

            deletePossibleDuplicateSOAsJson = SerializationHelper.SerializeDeletePossibleDuplicateSO(deletePossibleDuplicateSO);

            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                try
                {
                    streamWriter.Write(deletePossibleDuplicateSOAsJson);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    ClientLogger.WriteError(ex, "Error deleteing Possible Duplicate.\nMethod: GoldmineImportServiceConnector.CreateHistoryRecordForRiftId", ClientGlobalData.CurrentUser.SystemName); 
                    throw ex;
                }
            }

            // get response
            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                jsonResult = streamReader.ReadToEnd();
                jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
            }

            // deserialize
            try
            {
                goldmineImportServiceDO = JsonConvert.DeserializeObject<GoldmineImportServiceDO>(jsonResult);
                deletionSuccess = goldmineImportServiceDO.DeletePossibleDuplicateResult;
            }
            catch (Exception ex)
            {
                ClientLogger.WriteError(ex, "Error deserializing result for deleteing Possible Duplicate.\nMethod: GoldmineImportServiceConnector.CreateHistoryRecordForRiftId", ClientGlobalData.CurrentUser.SystemName); 
                HandleDeserializationException(ex);
            }
            return deletionSuccess;
        }

        public int PossibleDuplicatesCount()
        {
            int possibleDuplicateCount = 0;
            string jsonResult = string.Empty;
            GoldmineImportServiceDO goldmineImportServiceDO = new GoldmineImportServiceDO();

            string URL = string.Format("{0}PossibleDuplicatesCount", goldmineImportServiceAddress);

            try
            {
                WebClient serviceRequest = new WebClient();
                jsonResult = serviceRequest.DownloadString(new Uri(URL));
                jsonResult = ConnectorHelper.ChangeArrayParentheses(jsonResult);
            }
            catch (Exception ex)
            {
                ClientLogger.WriteError(ex, "Error retrieving Possible Duplicate count.\nMethod: GoldmineImportServiceConnector.CreateHistoryRecordForRiftId", ClientGlobalData.CurrentUser.SystemName); 
                throw ex;
            }

            try
            {
                goldmineImportServiceDO = JsonConvert.DeserializeObject<GoldmineImportServiceDO>(jsonResult);
                possibleDuplicateCount = goldmineImportServiceDO.PossibleDuplicatesCountResult;
            }
            catch (Exception ex) 
            {
                ClientLogger.WriteError(ex, "Error deserializing result from Possible Duplicate count.\nMethod: GoldmineImportServiceConnector.CreateHistoryRecordForRiftId", ClientGlobalData.CurrentUser.SystemName); 
                HandleDeserializationException(ex);
            }
            return possibleDuplicateCount;
        }

        public void HandleDeserializationException(Exception ex)
        {
            if (ex.GetType() == typeof(Newtonsoft.Json.JsonSerializationException))
            {
                throw ex;
            }
        }
    }
}
