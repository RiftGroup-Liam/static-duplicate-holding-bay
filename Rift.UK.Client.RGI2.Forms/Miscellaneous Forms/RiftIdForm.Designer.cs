namespace Rift.UK.Client.RGI2.Forms
{
    partial class RiftIdForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRiftId = new System.Windows.Forms.Label();
            this.txtRiftId = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRiftId
            // 
            this.lblRiftId.AutoSize = true;
            this.lblRiftId.Location = new System.Drawing.Point(12, 36);
            this.lblRiftId.Name = "lblRiftId";
            this.lblRiftId.Size = new System.Drawing.Size(186, 13);
            this.lblRiftId.TabIndex = 0;
            this.lblRiftId.Text = "Rift Id to associate history record with:";
            // 
            // txtRiftId
            // 
            this.txtRiftId.Location = new System.Drawing.Point(204, 33);
            this.txtRiftId.Name = "txtRiftId";
            this.txtRiftId.Size = new System.Drawing.Size(115, 20);
            this.txtRiftId.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Location = new System.Drawing.Point(163, 80);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(244, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RiftIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 115);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtRiftId);
            this.Controls.Add(this.lblRiftId);
            this.Name = "RiftIdForm";
            this.Text = "Rift Id";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRiftId;
        private System.Windows.Forms.TextBox txtRiftId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button2;
    }
}