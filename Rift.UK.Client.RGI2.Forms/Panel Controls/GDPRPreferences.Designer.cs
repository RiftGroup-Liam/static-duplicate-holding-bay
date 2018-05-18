namespace Rift.UK.Client.RGI2.Forms.Panel_Controls
{
    partial class GDPRPreferences
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGDPRPreferences = new System.Windows.Forms.Label();
            this.lblGDPREmail = new System.Windows.Forms.Label();
            this.lblGDPRSMS = new System.Windows.Forms.Label();
            this.lblGDPRPost = new System.Windows.Forms.Label();
            this.lblGDPRPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGDPRPreferences
            // 
            this.lblGDPRPreferences.AutoSize = true;
            this.lblGDPRPreferences.Location = new System.Drawing.Point(14, 15);
            this.lblGDPRPreferences.Name = "lblGDPRPreferences";
            this.lblGDPRPreferences.Size = new System.Drawing.Size(98, 13);
            this.lblGDPRPreferences.TabIndex = 0;
            this.lblGDPRPreferences.Text = "GDPR Preferences";
            // 
            // lblGDPREmail
            // 
            this.lblGDPREmail.AutoSize = true;
            this.lblGDPREmail.Location = new System.Drawing.Point(14, 47);
            this.lblGDPREmail.Name = "lblGDPREmail";
            this.lblGDPREmail.Size = new System.Drawing.Size(35, 13);
            this.lblGDPREmail.TabIndex = 1;
            this.lblGDPREmail.Text = "Email:";
            // 
            // lblGDPRSMS
            // 
            this.lblGDPRSMS.AutoSize = true;
            this.lblGDPRSMS.Location = new System.Drawing.Point(14, 70);
            this.lblGDPRSMS.Name = "lblGDPRSMS";
            this.lblGDPRSMS.Size = new System.Drawing.Size(33, 13);
            this.lblGDPRSMS.TabIndex = 2;
            this.lblGDPRSMS.Text = "SMS:";
            // 
            // lblGDPRPost
            // 
            this.lblGDPRPost.AutoSize = true;
            this.lblGDPRPost.Location = new System.Drawing.Point(14, 94);
            this.lblGDPRPost.Name = "lblGDPRPost";
            this.lblGDPRPost.Size = new System.Drawing.Size(31, 13);
            this.lblGDPRPost.TabIndex = 3;
            this.lblGDPRPost.Text = "Post:";
            // 
            // lblGDPRPhone
            // 
            this.lblGDPRPhone.AutoSize = true;
            this.lblGDPRPhone.Location = new System.Drawing.Point(14, 118);
            this.lblGDPRPhone.Name = "lblGDPRPhone";
            this.lblGDPRPhone.Size = new System.Drawing.Size(41, 13);
            this.lblGDPRPhone.TabIndex = 4;
            this.lblGDPRPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(53, 67);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.ReadOnly = true;
            this.txtSMS.Size = new System.Drawing.Size(100, 20);
            this.txtSMS.TabIndex = 6;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(53, 91);
            this.txtPost.Name = "txtPost";
            this.txtPost.ReadOnly = true;
            this.txtPost.Size = new System.Drawing.Size(100, 20);
            this.txtPost.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(53, 115);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // GDPRPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtSMS);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblGDPRPhone);
            this.Controls.Add(this.lblGDPRPost);
            this.Controls.Add(this.lblGDPRSMS);
            this.Controls.Add(this.lblGDPREmail);
            this.Controls.Add(this.lblGDPRPreferences);
            this.Name = "GDPRPreferences";
            this.Size = new System.Drawing.Size(181, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGDPRPreferences;
        private System.Windows.Forms.Label lblGDPREmail;
        private System.Windows.Forms.Label lblGDPRSMS;
        private System.Windows.Forms.Label lblGDPRPost;
        private System.Windows.Forms.Label lblGDPRPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.TextBox txtPhone;
    }
}
