using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rift.UK.Core.RGI2.REO;
using Rift.UK.Client.RGI2.Connector;

namespace Rift.UK.Client.RGI2.UIControl
{
    public class PossibleDuplicateListControl
    {
        GoldmineImportServiceConnector goldmineImportServiceConnector = new GoldmineImportServiceConnector();
        public delegate void PossibleDuplicatesUpdated(object sender, EventArgs e);
        public event PossibleDuplicatesUpdated OnPossibleDuplicatesUpdated;
                
        private List<GMPossibleDuplicate> possibleDuplicates;
        public List<GMPossibleDuplicate> PossibleDuplicates { get { possibleDuplicates = possibleDuplicates.OrderBy(PD=>PD.CONTACT).ToList(); return possibleDuplicates; } set { possibleDuplicates = value; PossibleDuplicatesListUpdated(); } }

        public GMPossibleDuplicate selectedPossibleDuplicate;

        public void PossibleDuplicatesListUpdated()
        {
            if (OnPossibleDuplicatesUpdated != null)
            {
                OnPossibleDuplicatesUpdated(this, EventArgs.Empty);
            }
        }

        public void RetrieveList(int recordCounter)
        {
            this.possibleDuplicates = goldmineImportServiceConnector.GetPossibleDuplicates(recordCounter);
            this.possibleDuplicates = this.possibleDuplicates.OrderByDescending(X => X.Created).ToList();
            PossibleDuplicatesListUpdated();
        }

        public void GetNext10(int recordCounter)
        {
            if (possibleDuplicates.Count > 9)
            {
                RetrieveList(recordCounter);
            }
        }

        public void GetPrevious10(int recordCounter)
        {
            if (!(recordCounter < 0))
            {
                RetrieveList(recordCounter);
            }
        }
    }
}
