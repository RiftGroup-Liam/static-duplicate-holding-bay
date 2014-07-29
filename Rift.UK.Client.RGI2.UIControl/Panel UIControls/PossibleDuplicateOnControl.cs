using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rift.UK.Client.RGI2.Connector;
using Rift.UK.Core.RGI2.REO;

namespace Rift.UK.Client.RGI2.UIControl
{
    public class PossibleDuplicateOnControl
    {
        GoldmineImportServiceConnector goldmineImportServiceConnector = new GoldmineImportServiceConnector();
        public delegate void PossibleDuplicateUpdated(object sender, EventArgs e);
        public event PossibleDuplicateUpdated OnPossibleDuplicateUpdated;

        private GMPossibleDuplicate possibleDuplicate;
        public GMPossibleDuplicate PossibleDuplicate { get { return possibleDuplicate; } set { possibleDuplicate = value; PossibleDuplicateObjectUpdated(); } }

        public void PossibleDuplicateObjectUpdated()
        {
            if (OnPossibleDuplicateUpdated != null)
            {
                OnPossibleDuplicateUpdated(this, EventArgs.Empty);
            }
        }

        public MatchingDetails RetrieveMatchingDetails(GMPossibleDuplicate gMPossibleDuplicate)
        {
            MatchingDetails matchingDetails = new MatchingDetails();
            matchingDetails = goldmineImportServiceConnector.GetMatchingDetails(gMPossibleDuplicate.LASTNAME, gMPossibleDuplicate.ZIP, gMPossibleDuplicate.PHONE1, gMPossibleDuplicate.PHONE2, gMPossibleDuplicate.UEMAILADDR);
            return matchingDetails;
        }
    }
}
