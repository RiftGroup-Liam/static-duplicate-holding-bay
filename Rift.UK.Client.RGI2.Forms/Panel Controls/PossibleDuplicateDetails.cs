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
    public partial class PossibleDuplicateDetails : UserControl
    {
        PossibleDuplicateDetailsControl panelControl;
        public PossibleDuplicateDetails()
        {
            InitializeComponent();
        }

        public void Init(PossibleDuplicateDetailsControl givenPossibleDuplicateDetailsControl)
        {
            panelControl = givenPossibleDuplicateDetailsControl;
            panelControl.OnPossibleDuplicateUpdated += new PossibleDuplicateDetailsControl.PossibleDuplicateUpdated(panelControl_OnPossibleDuplicateUpdated);
        }

        void panelControl_OnPossibleDuplicateUpdated(object sender, EventArgs e)
        {
            // display duplicate details

            DisplayDuplicateDetails(panelControl.PossibleDuplicate);
        }

        private void DisplayDuplicateDetails(GMPossibleDuplicate gMPossibleDuplicate)
        {            
            SetREPDetailsGroupBoxVisibility(gMPossibleDuplicate);
            SetBasicDetails(gMPossibleDuplicate);
            if (gMPossibleDuplicate.CREATEBY != "" && gMPossibleDuplicate.CREATEBY != UIControl.UI_Config_Reader.ConfigReader.ReadServiceImportUserUSERNAME())
            {
                SetRepDetails(gMPossibleDuplicate);
            }
            SetCommentsArea(gMPossibleDuplicate);
            SetMatchedDetails(gMPossibleDuplicate);            
        }

        private void SetMatchedDetails(GMPossibleDuplicate gMPossibleDuplicate)
        {
            SetMatchedPhone1(gMPossibleDuplicate.MatchedPHONE1);
            SetMatchedPhone2(gMPossibleDuplicate.MatchedPHONE2);
            SetMatchedEmail(gMPossibleDuplicate.MatchedEMAIL);
            SetMatchedPostCode(gMPossibleDuplicate.MatchedPostCode);
        }

        private void SetMatchedPostCode(int? matchedPostCode)
        {
            if (matchedPostCode != null)
            {
                if (matchedPostCode == 1)
                {
                    cbPostCodeMatch.Checked = true;
                }
                else
                {
                    cbPostCodeMatch.Checked = false;
                }
            }
            else
            {
                cbPostCodeMatch.Checked = false;
            }
        }

        private void SetMatchedEmail(int? matchedEmail)
        {
            if (matchedEmail != null)
            {
                if (matchedEmail == 1)
                {
                    cbEmailMatch.Checked = true;
                }
                else
                {
                    cbEmailMatch.Checked = false;
                }
            }
            else
            {
                cbEmailMatch.Checked = false;
            }
        }

        private void SetMatchedPhone2(int? matchedPhone2)
        {
            if (matchedPhone2 != null)
            {
                if (matchedPhone2 == 1)
                {
                    cbPhone2Match.Checked = true;
                }
                else
                {
                    cbPhone2Match.Checked = false;
                }
            }
            else
            {
                cbPhone2Match.Checked = false;
            }
        }

        private void SetMatchedPhone1(int? matchedPhone1)
        {
            if (matchedPhone1 != null)
            {
                if (matchedPhone1 == 1)
                {
                    cbPhone1Match.Checked = true;
                }
                else
                {
                    cbPhone1Match.Checked = false;
                }
            }
            else
            {
                cbPhone1Match.Checked = false;
            }
        }

        private void SetCommentsArea(GMPossibleDuplicate gMPossibleDuplicate)
        {
            txtComments.Text = gMPossibleDuplicate.COMMENTS;
        }

        private void SetRepDetails(GMPossibleDuplicate gMPossibleDuplicate)
        {
            SetFullyQualified(gMPossibleDuplicate.FullyQualified);
            SetTransport(gMPossibleDuplicate.TransportCar, gMPossibleDuplicate.TransportPublicTransport);
            txtNoOfYears.Text = gMPossibleDuplicate.NoOfYears.ToString();
            SetVIP(gMPossibleDuplicate.VIP);
            SetRapidRefund(gMPossibleDuplicate.RapidRefund);
            txtUCURSITE.Text = gMPossibleDuplicate.UCURSITE;
            txtUCUREmployer.Text = gMPossibleDuplicate.UCUREMPLOY;
            txtRepName.Text = gMPossibleDuplicate.CREATEBY;
            txtReceivedDate.Text = gMPossibleDuplicate.Created.ToString();
        }

        private void SetRapidRefund(int rapidRefundFlag)
        {
            if (rapidRefundFlag == 1)
            {
                cbRapidRefund.Checked = true;
            }
            else
            {
                cbRapidRefund.Checked = false;
            }
        }

        private void SetVIP(int VIPFlag)
        {
            if (VIPFlag == 1)
            {
                cbVIP.Checked = true;
            }
            else
            {
                cbVIP.Checked = false;
            }
        }

        private void SetTransport(int carFlag, int publicTransportFlag)
        {
            if (carFlag == 1)
            {
                cbPrivateCar.Checked = true;
            }
            else
            {
                cbPrivateCar.Checked = false;
            }

            if (publicTransportFlag == 1)
            {
                cbPublicTransport.Checked = true;
            }
            else
            {
                cbPublicTransport.Checked = false;
            }
        }

        private void SetFullyQualified(int fullyQualifiedFlag)
        {
            if (fullyQualifiedFlag == 1)
            {
                cbFullyQualified.Checked = true;
            }
            else
            {
                cbFullyQualified.Checked = false;
            }
        }

        private void SetBasicDetails(GMPossibleDuplicate gMPossibleDuplicate)
        {
            if (gMPossibleDuplicate != null)
            {
                txtId.Text = gMPossibleDuplicate.Id.ToString();
                txtDEAR.Text = gMPossibleDuplicate.DEAR;
                txtSECR.Text = gMPossibleDuplicate.SECR;
                txtLASTNAME.Text = gMPossibleDuplicate.LASTNAME;
                txtPHONE1.Text = gMPossibleDuplicate.PHONE1;
                txtPHONE2.Text = gMPossibleDuplicate.PHONE2;
                txtUEMAILADDR.Text = gMPossibleDuplicate.UEMAILADDR;
                txtADDRESS1.Text = gMPossibleDuplicate.ADDRESS1;
                txtADDRESS2.Text = gMPossibleDuplicate.ADDRESS2;
                txtZIP.Text = gMPossibleDuplicate.ZIP;
                txtSTATE.Text = gMPossibleDuplicate.STATE;
                txtCOUNTRY.Text = gMPossibleDuplicate.COUNTRY;
                txtCITY.Text = gMPossibleDuplicate.CITY;
                txtAreaOfEmployment.Text = gMPossibleDuplicate.TITLE;
                txtCreatedDate.Text = gMPossibleDuplicate.Created.ToString();
                txtCallTime.Text = gMPossibleDuplicate.CallTime;
                txtGrade.Text = gMPossibleDuplicate.TITLE;
                txtSector.Text = gMPossibleDuplicate.Sector;
            }
        }

        private void SetREPDetailsGroupBoxVisibility(GMPossibleDuplicate gMPossibleDuplicate)
        {
            if (gMPossibleDuplicate.EmailTypeEnum == EmailEnums.EmailType.Rep)
            {
                gbRepExtraDetails.Visible = true;
            }
            else
            {
                gbRepExtraDetails.Visible = false;
            }
        }

        private void ComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            // ignore
        }

        public void ClearDetails()
        {
            HideREPDetailsGroupBoxVisibility();
            ClearBasicDetails();            
            ClearRepDetails();            
            ClearCommentsArea();
            UnCheckMatchedDetails(); 
        }

        private void UnCheckMatchedDetails()
        {
            cbEmailMatch.Checked = false;
            cbPhone1Match.Checked = false;
            cbPhone2Match.Checked = false;
            cbPostCodeMatch.Checked = false;
        }

        private void ClearCommentsArea()
        {
            txtComments.Text = string.Empty;
        }

        private void ClearRepDetails()
        {
            cbFullyQualified.Checked = false;
            cbPrivateCar.Checked = false;
            cbPublicTransport.Checked = false;
            txtNoOfYears.Text = string.Empty;
            cbVIP.Checked = false;
            cbRapidRefund.Checked = false;
            txtUCURSITE.Text = string.Empty;
            txtUCUREmployer.Text = string.Empty;            
        }

        private void ClearBasicDetails()
        {
            txtId.Text = string.Empty;
            txtDEAR.Text = string.Empty;
            txtSECR.Text = string.Empty;
            txtLASTNAME.Text = string.Empty;
            txtPHONE1.Text = string.Empty;
            txtPHONE2.Text = string.Empty;
            txtUEMAILADDR.Text = string.Empty;
            txtADDRESS1.Text = string.Empty;
            txtADDRESS2.Text = string.Empty;
            txtZIP.Text = string.Empty;
            txtSTATE.Text = string.Empty;
            txtCOUNTRY.Text = string.Empty;
            txtCITY.Text = string.Empty;
            txtAreaOfEmployment.Text = string.Empty;
            txtCallTime.Text = string.Empty;
            txtSector.Text = string.Empty;
            txtGrade.Text = string.Empty;
        }

        private void HideREPDetailsGroupBoxVisibility()
        {
            gbRepExtraDetails.Visible = false;
        }
    }
}
