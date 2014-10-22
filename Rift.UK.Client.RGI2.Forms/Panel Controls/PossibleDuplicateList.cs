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
    public partial class PossibleDuplicateList : UserControl
    {
        public delegate void SelectedPossibleDuplicateChanged(object sender, EventArgs e);
        public event SelectedPossibleDuplicateChanged OnSelectedPossibleDuplicateChanged;

        public delegate void DuplicateListEmpty(object sender, EventArgs e);
        public event DuplicateListEmpty OnDuplicateListEmpty;

        PossibleDuplicateListControl panelControl;
        private GMPossibleDuplicate selectedPossibleDuplicate;
        public GMPossibleDuplicate SelectedPossibleDuplicate { get { return selectedPossibleDuplicate; } set { selectedPossibleDuplicate = value; SelectedPossibleDuplicateObjectChanged(); } }

        public PossibleDuplicateList()
        {
            InitializeComponent();
        }

        private void SelectedPossibleDuplicateObjectChanged()
        {
            if (OnSelectedPossibleDuplicateChanged != null)
            {
                OnSelectedPossibleDuplicateChanged(this, EventArgs.Empty);
            }
        }

        public void Init(PossibleDuplicateListControl givenPossibleDuplicateListControl, int initialRecordCounter)
        {
            panelControl = givenPossibleDuplicateListControl;
            panelControl.OnPossibleDuplicatesUpdated += new PossibleDuplicateListControl.PossibleDuplicatesUpdated(panelControl_OnPossibleDuplicatesUpdated);
            RetrieveList(initialRecordCounter);            
        }

        void panelControl_OnPossibleDuplicatesUpdated(object sender, EventArgs e)
        {
            DisplayList();
        }

        private void DisplayList()
        {
            if (panelControl.PossibleDuplicates.Count != 0)
            {
                dgvPossibleDuplicates.DataSource = null;
                dgvPossibleDuplicates.DataSource = panelControl.PossibleDuplicates.OrderByDescending(X=>X.Created).ToList();
            }
            else
            {
                dgvPossibleDuplicates.DataSource = null;
                dgvPossibleDuplicates.DataSource = panelControl.PossibleDuplicates;
                DuplicateListEmptyEvent();
            }             
        }

        private void DuplicateListEmptyEvent()
        {
            if (OnDuplicateListEmpty != null)
            {
                OnDuplicateListEmpty(this, EventArgs.Empty);
            }
        }

        private void RetrieveList(int recordCounter)
        {
            panelControl.RetrieveList(recordCounter);
        }

        private void dgvPossibleDuplicates_SelectionChanged(object sender, EventArgs e)
        {
            GMPossibleDuplicate selectedPossibleDuplicate = dgvPossibleDuplicates.CurrentRow.DataBoundItem as GMPossibleDuplicate;
            if (selectedPossibleDuplicate != null)
            {
                panelControl.selectedPossibleDuplicate = selectedPossibleDuplicate;
                SelectedPossibleDuplicateObjectChanged();
            }
        }

        public void RedisplayList()
        {
            DisplayList();
        }

        public void RefreshList(int recordCounter)
        {
            panelControl.RetrieveList(recordCounter);
            DisplayList();
        }

        public void Next10(int recordCounter)
        {
            panelControl.GetNext10(recordCounter);
            //RedisplayList();
        }

        public void Previous10(int recordCounter)
        {
            panelControl.GetPrevious10(recordCounter);
            //RedisplayList();
        }

        public int ListCount()
        {
            return panelControl.PossibleDuplicates.Count();
        }
    }
}
