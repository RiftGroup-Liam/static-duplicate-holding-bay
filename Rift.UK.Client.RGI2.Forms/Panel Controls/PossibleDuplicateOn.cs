using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rift.UK.Client.RGI2.UIControl;
using Rift.UK.Core.RGI2.REO;

namespace Rift.UK.Client.RGI2.Forms
{
    public partial class PossibleDuplicateOn : UserControl
    {
        PossibleDuplicateOnControl panelControl;
        public PossibleDuplicateOn()
        {
            InitializeComponent();
        }

        public void Init(PossibleDuplicateOnControl givenPossibleDuplicateOnControl)
        {
            panelControl = givenPossibleDuplicateOnControl;
            panelControl.OnPossibleDuplicateUpdated += new PossibleDuplicateOnControl.PossibleDuplicateUpdated(panelControl_OnPossibleDuplicateUpdated);
        }

        void panelControl_OnPossibleDuplicateUpdated(object sender, EventArgs e)
        {
            // fetch which duplicate details
            MatchingDetails matchingDetails = panelControl.RetrieveMatchingDetails(panelControl.PossibleDuplicate);
            // Display which duplicate details
            DisplayMatchingDetails(matchingDetails);
        }

        private void DisplayMatchingDetails(MatchingDetails matchingDetails)
        {
            DisplayPhone1Match(matchingDetails.PHONE1Match);
            DisplayPhone2Match(matchingDetails.PHONE2Match);
            DisplayEmailMatch(matchingDetails.UEMAILADDRMatch);
            DisplayPostCodeMatch(matchingDetails.PostCodeMatch);
        }

        private void DisplayPostCodeMatch(bool postCodeMatch)
        {
            if (postCodeMatch)
            {
                cbPostCodeMatch.Checked = true;
            }
            else
            {
                cbPostCodeMatch.Checked = false;
            }
        }

        private void DisplayEmailMatch(bool emailMatch)
        {
            if (emailMatch)
            {
                cbEmailMatch.Checked = true;
            }
            else
            {
                cbEmailMatch.Checked = false;
            }
        }

        private void DisplayPhone2Match(bool PHONE2Match)
        {
            if (PHONE2Match)
            {
                cbPhone2Match.Checked = true;
            }
            else
            {
                cbPhone2Match.Checked = false;
            }
        }

        private void DisplayPhone1Match(bool PHONE1Match)
        {
            if (PHONE1Match)
            {
                cbPhone1Match.Checked = true;
            }
            else
            {
                cbPhone1Match.Checked = false;
            }
        }
    }
}
