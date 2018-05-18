using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rift.UK.Client.RGI2.UIControl;

namespace Rift.UK.Client.RGI2.Forms.Panel_Controls
{
    public partial class GDPRPreferences : UserControl
    {
        GDPRPreferencesControl _localControl;
        public GDPRPreferences()
        {
            InitializeComponent();
        }

        public void Init(GDPRPreferencesControl control)
        {
            _localControl = control;
            control.OnPossibleDuplicateUpdated += Control_OnPossibleDuplicateUpdated;
        }

        private void Control_OnPossibleDuplicateUpdated(object sender, EventArgs e)
        {
            txtEmail.Text = _localControl.PossibleDuplicate.UCPEMAIL;
            txtPhone.Text = _localControl.PossibleDuplicate.UCPPHONE;
            txtSMS.Text = _localControl.PossibleDuplicate.UCPSMS;
            txtPost.Text = _localControl.PossibleDuplicate.UCPPOST;
        }
    }
}
