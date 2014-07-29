using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rift.UK.Core.RGI2.REO;
using Rift.UK.Client.RGI2.Connector;

namespace Rift.UK.Client.RGI2.UIControl
{
    public class PossibleDuplicateDetailsControl
    {
        public delegate void PossibleDuplicateUpdated(object sender, EventArgs e);
        public event PossibleDuplicateUpdated OnPossibleDuplicateUpdated;

        GoldmineImportServiceConnector goldmineImportServiceConnector = new GoldmineImportServiceConnector();
        private GMPossibleDuplicate possibleDuplicate;
        public GMPossibleDuplicate PossibleDuplicate { get { return possibleDuplicate; } set { possibleDuplicate = value; PossibleDuplicateObjectUpdated(); } }
        public void PossibleDuplicateObjectUpdated()
        {
            if (OnPossibleDuplicateUpdated != null)
            {
                OnPossibleDuplicateUpdated(this, EventArgs.Empty);
            }
        }
    }
}
