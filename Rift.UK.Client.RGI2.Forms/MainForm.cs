using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rift.UK.Client.RGI2.UIControl;
using Rift.UK.Core.RGI2.REO;
using Rift.UK.Core.RGI2.REO.Logging;

namespace Rift.UK.Client.RGI2.Forms
{
    public partial class MainForm : Form
    {
        MainFormControl mainFormControl = new MainFormControl();
        PossibleDuplicateDetailsControl possibleDuplicateDetailsControl = new PossibleDuplicateDetailsControl();
        PossibleDuplicateListControl possibleDuplicateListControl = new PossibleDuplicateListControl();
        PossibleDuplicateOnControl possibleDuplicateOnControl = new PossibleDuplicateOnControl();
        User user = new User();

        GMPossibleDuplicate selectedPossibleDuplicate;
        public MainForm()
        {
            InitializeComponent();
            mainFormControl.ClearClientLog();
            LoginUser(Environment.GetEnvironmentVariable("USERNAME"));
            CheckAccesstoRGI2(user);

            AttachEvents();
            InitiatePanels();  
            recordCounter = 0;
            DisplayPaginationInformation();
        }

        private void CheckAccesstoRGI2(User user)
        {
            bool allowed = mainFormControl.CheckAccessToRGI2(user);
            DisplayAccessToRGI2(allowed);
        }

        private void DisplayAccessToRGI2(bool allowed)
        {
            if (!allowed)
            {
                MessageBox.Show("You are declined access to RGI2");
                Environment.Exit(1);
            }
        }

        private void LoginUser(string systemName)
        {
            user = mainFormControl.LoginUser(systemName);
            if (user != null | user.Forename != null | user.Surname != null)
            {
                DisplayUserDetails(user);
                ClientGlobalData.CurrentUser = user;
            }
            else
            {
                MessageBox.Show("No User found in RiftDB");
                Application.Exit();
            }
        }

        private void DisplayUserDetails(User user)
        {
            this.Text = "Goldmine Importer Possible Duplicates: V1.05 - " + user.Forename + " " + user.Surname;
        }

        private void AttachEvents()
        {
            possibleDuplicateListControl.OnPossibleDuplicatesUpdated += new PossibleDuplicateListControl.PossibleDuplicatesUpdated(possibleDuplicateListControl_OnPossibleDuplicatesUpdated);
            PDList.OnDuplicateListEmpty += new PossibleDuplicateList.DuplicateListEmpty(PDList_OnDuplicateListEmpty);
            PDList.OnSelectedPossibleDuplicateChanged += new PossibleDuplicateList.SelectedPossibleDuplicateChanged(PDList_OnSelectedPossibleDuplicateChanged);
        }

        void PDList_OnDuplicateListEmpty(object sender, EventArgs e)
        {
            PDDetails.ClearDetails();
        }

        void PDList_OnSelectedPossibleDuplicateChanged(object sender, EventArgs e)
        {
            selectedPossibleDuplicate = possibleDuplicateListControl.selectedPossibleDuplicate;
            // tell other controls the new selected possibleDuplicate
            possibleDuplicateOnControl.PossibleDuplicate = possibleDuplicateListControl.selectedPossibleDuplicate;
            possibleDuplicateDetailsControl.PossibleDuplicate = possibleDuplicateListControl.selectedPossibleDuplicate;
        }

        void possibleDuplicateListControl_OnPossibleDuplicatesUpdated(object sender, EventArgs e)
        {
            // redisplay list
            PDList.RedisplayList();
        }

        private void InitiatePanels()
        {
            PDList.Init(possibleDuplicateListControl, recordCounter);
            PDDetails.Init(possibleDuplicateDetailsControl);
            //PDOn.Init(possibleDuplicateOnControl);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (selectedPossibleDuplicate != null)
            {
                string returnRecId = mainFormControl.ImportContact(selectedPossibleDuplicate, user);
                DisplayImportResult(returnRecId);

                // update the list after processing
                PDList.RefreshList(recordCounter);
                DisplayPaginationInformation();
            }
        }

        private void DisplayImportResult(string returnRecId)
        {
            if (returnRecId != null | returnRecId != "")
            {
                MessageBox.Show("Import of contact: Successful");
            }
            else
            {
                MessageBox.Show("Import of contact: UnSuccessful");
            }
        }

        private void btnCreateHistoryRecord_Click(object sender, EventArgs e)
        {
            if (selectedPossibleDuplicate != null)
            {
                string riftId = string.Empty;
                RiftIdControl riftIdControl = new RiftIdControl();
                RiftIdForm riftIdForm = new RiftIdForm();
                riftIdForm.Init(riftIdControl);
                DialogResult dr = riftIdForm.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    riftId = riftIdControl.RiftId;
                    string historyRecordRecId = mainFormControl.CreateHistoryRecordForRiftId(selectedPossibleDuplicate, riftId, user);
                    DisplayHistoryRecordCreationResult(historyRecordRecId);
                }
                else
                {
                    // cancel clicked
                }

                // update the list after processing
                PDList.RefreshList(recordCounter);
                DisplayPaginationInformation();
            }
        }

        private void DisplayHistoryRecordCreationResult(string returnRecId)
        {
            if (returnRecId != null | returnRecId != "")
            {
                MessageBox.Show("Creation of History Record for contact: Successful");
            }
            else
            {
                MessageBox.Show("Creation of History Record for contact: UnSuccessful");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPossibleDuplicate != null)
            {
                AreYouSureMessageBox areYouSure = new AreYouSureMessageBox();
                DialogResult dr = areYouSure.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    bool success = mainFormControl.DeletePossibleDuplicate(selectedPossibleDuplicate, user);
                    DisplayDeletionSuccess(success);
                    // update the list after processing
                    PDList.RefreshList(recordCounter);
                    DisplayPaginationInformation();
                }
            }
        }

        private void DisplayDeletionSuccess(bool success)
        {
            if (success)
            {
                MessageBox.Show("Deletion Successful");
            }
            else
            {
                MessageBox.Show("Deletion Unsuccessful");
            }
        }

        private int recordCounter;
        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentCount = PDList.ListCount();
            if (currentCount > 9)
            {
                recordCounter = recordCounter + 10;
                PDList.Next10(recordCounter);
            }
            DisplayPaginationInformation();
        }

        private void DisplayPaginationInformation()
        {
            string paginationInformation = "Viewing " + recordCounter + " -> " + (recordCounter + 10) + " (Total: " + mainFormControl.GetPossibleDuplicateCount().ToString() + " )";
            lblPaginationInformation.Text = paginationInformation;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (recordCounter != 0)
            {
                recordCounter = recordCounter - 10;
                PDList.Previous10(recordCounter);
            }
            DisplayPaginationInformation();
        }
    }
}
