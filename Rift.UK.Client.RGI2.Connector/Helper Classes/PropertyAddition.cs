using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rift.UK.Core.RGI2.REO.SerializationObjects;
using Rift.UK.Core.RGI2.REO;
namespace Rift.UK.Client.RGI2.Connector.Helper_Classes
{
    public static class PropertyAddition
    {
        public static GetMatchingDetailsSO SetGetMatchingDetailsSOProperties(string lastname, string postCode, string PHONE1, string PHONE2, string UEMAILADDR, GetMatchingDetailsSO getMatchingDetailsSO)
        {
            getMatchingDetailsSO.lastname = lastname;
            getMatchingDetailsSO.postCode = postCode;
            getMatchingDetailsSO.PHONE1 = PHONE1;
            getMatchingDetailsSO.PHONE2 = PHONE2;
            getMatchingDetailsSO.UEMAILADDR = UEMAILADDR;
            return getMatchingDetailsSO;
        }

        public static ImportContactSO SetImportContactSOProperties(ImportContactSO importContactSO, GMPossibleDuplicate possibleDuplicate, User user)
        {
            importContactSO.possibleDuplicate = possibleDuplicate;
            importContactSO.user = user;
            return importContactSO;
        }

        public static CreateHistoryRecordForRiftIdSO SetCreateHistoryRecordForRiftIdSO(CreateHistoryRecordForRiftIdSO createHistoryRecordForRiftIdSO, GMPossibleDuplicate selectedPossibleDuplicate, string riftId, User user)
        {
            createHistoryRecordForRiftIdSO.possibleDuplicate = selectedPossibleDuplicate;
            createHistoryRecordForRiftIdSO.riftId = riftId;
            createHistoryRecordForRiftIdSO.user = user;
            return createHistoryRecordForRiftIdSO;
        }

        public static DeletePossibleDuplicateSO SetDeletePossibleDuplicateSOProperties(DeletePossibleDuplicateSO deletePossibleDuplicateSO, GMPossibleDuplicate selectedPossibleDuplicate, User user)
        {
            deletePossibleDuplicateSO.possibleDuplicate = selectedPossibleDuplicate;
            deletePossibleDuplicateSO.user = user;
            return deletePossibleDuplicateSO;
        }
    }
}
