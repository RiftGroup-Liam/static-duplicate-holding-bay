using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rift.UK.Client.RGI2.UIControl;

namespace Rift.UK.Client.RGI2.Forms
{
    public partial class RiftIdForm : Form
    {
        RiftIdControl formControl;
        public RiftIdForm()
        {
            InitializeComponent();
        }

        public void Init(RiftIdControl givenRiftIdControl)
        {
            formControl = givenRiftIdControl;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            formControl.RiftId = txtRiftId.Text.Trim();
        }
    }
}
