using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Rift.UK.Core.RGI2.REO;
using Rift.UK.Client.RGI2.Connector;
using Rift.UK.Client.RGI2.UIControl.UI_Config_Reader;

namespace Rift.UK.Client.RGI2.UIControl
{
    public class MainFormControl
    {
        UserConnector userConnector = new UserConnector();
        GoldmineImportServiceConnector goldmineImportServiceConnector = new GoldmineImportServiceConnector();

        public string ImportContact(GMPossibleDuplicate selectedProssibleDuplicate, User user)
        {
            string returnRecId = string.Empty;
            returnRecId = goldmineImportServiceConnector.ImportContact(selectedProssibleDuplicate, user);
            return returnRecId;
        }

        public string CreateHistoryRecordForRiftId(GMPossibleDuplicate selectedPossibleDuplicate, string riftId, User user)
        {
            string historyRecordRecId = string.Empty;
            historyRecordRecId = goldmineImportServiceConnector.CreateHistoryRecordForRiftId(selectedPossibleDuplicate, riftId, user);
            return historyRecordRecId;
        }

        public User LoginUser(string systemName)
        {
            User currentUser = new User();
            currentUser = userConnector.GetUser(systemName);
            return currentUser;
        }

        public bool CheckAccessToRGI2(User user)
        {
            bool allowed = false;
            allowed = userConnector.CheckAccessToRGI2(user.SystemName);
            return allowed;
        }

        public bool DeletePossibleDuplicate(GMPossibleDuplicate selectedPossibleDuplicate, User user)
        {
            bool deletionSuccess = false;
            deletionSuccess = goldmineImportServiceConnector.DeletePossibleDuplicate(selectedPossibleDuplicate, user);
            return deletionSuccess;
        }

        public int GetPossibleDuplicateCount()
        {
            int possibleDuplicateCount = 0;
            possibleDuplicateCount = goldmineImportServiceConnector.PossibleDuplicatesCount();
            return possibleDuplicateCount;
        }

        public void ClearClientLog()
        {
            string filePath = ConfigReader.ReadClientLogFilePathFromConfig();
            string filename = "\\SystemLog.txt";
            string fileFullPath = filePath + filename;
            try
            {
                File.WriteAllText(fileFullPath, string.Empty);
            }
            catch (Exception ex) { }
        }
    }
}
