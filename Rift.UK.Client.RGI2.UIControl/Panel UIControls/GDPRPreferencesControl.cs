using Rift.UK.Core.RGI2.REO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rift.UK.Client.RGI2.UIControl
{
    public class GDPRPreferencesControl
    {
        public delegate void PossibleDuplicateUpdated(object sender, EventArgs e);
        public event PossibleDuplicateUpdated OnPossibleDuplicateUpdated;

        private GMPossibleDuplicate possibleDuplicate;
        private GDPRPreferencesControl localControl;
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
