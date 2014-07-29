namespace Rift.UK.Client.RGI2.Forms
{
    partial class PossibleDuplicateOn
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
            this.lblPossibleDuplicateOnHeader = new System.Windows.Forms.Label();
            this.cbPhone1Match = new System.Windows.Forms.CheckBox();
            this.cbPhone2Match = new System.Windows.Forms.CheckBox();
            this.cbEmailMatch = new System.Windows.Forms.CheckBox();
            this.cbPostCodeMatch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPossibleDuplicateOnHeader
            // 
            this.lblPossibleDuplicateOnHeader.AutoSize = true;
            this.lblPossibleDuplicateOnHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossibleDuplicateOnHeader.Location = new System.Drawing.Point(-3, 0);
            this.lblPossibleDuplicateOnHeader.Name = "lblPossibleDuplicateOnHeader";
            this.lblPossibleDuplicateOnHeader.Size = new System.Drawing.Size(112, 13);
            this.lblPossibleDuplicateOnHeader.TabIndex = 0;
            this.lblPossibleDuplicateOnHeader.Text = "Possible duplicate On:";
            // 
            // cbPhone1Match
            // 
            this.cbPhone1Match.AutoCheck = false;
            this.cbPhone1Match.AutoSize = true;
            this.cbPhone1Match.Location = new System.Drawing.Point(14, 26);
            this.cbPhone1Match.Name = "cbPhone1Match";
            this.cbPhone1Match.Size = new System.Drawing.Size(66, 17);
            this.cbPhone1Match.TabIndex = 4;
            this.cbPhone1Match.Text = "Phone 1";
            this.cbPhone1Match.UseVisualStyleBackColor = true;
            // 
            // cbPhone2Match
            // 
            this.cbPhone2Match.AutoCheck = false;
            this.cbPhone2Match.AutoSize = true;
            this.cbPhone2Match.Location = new System.Drawing.Point(14, 49);
            this.cbPhone2Match.Name = "cbPhone2Match";
            this.cbPhone2Match.Size = new System.Drawing.Size(66, 17);
            this.cbPhone2Match.TabIndex = 5;
            this.cbPhone2Match.Text = "Phone 2";
            this.cbPhone2Match.UseVisualStyleBackColor = true;
            // 
            // cbEmailMatch
            // 
            this.cbEmailMatch.AutoCheck = false;
            this.cbEmailMatch.AutoSize = true;
            this.cbEmailMatch.Location = new System.Drawing.Point(14, 72);
            this.cbEmailMatch.Name = "cbEmailMatch";
            this.cbEmailMatch.Size = new System.Drawing.Size(92, 17);
            this.cbEmailMatch.TabIndex = 6;
            this.cbEmailMatch.Text = "Email Address";
            this.cbEmailMatch.UseVisualStyleBackColor = true;
            // 
            // cbPostCodeMatch
            // 
            this.cbPostCodeMatch.AutoCheck = false;
            this.cbPostCodeMatch.AutoSize = true;
            this.cbPostCodeMatch.Location = new System.Drawing.Point(14, 95);
            this.cbPostCodeMatch.Name = "cbPostCodeMatch";
            this.cbPostCodeMatch.Size = new System.Drawing.Size(72, 17);
            this.cbPostCodeMatch.TabIndex = 7;
            this.cbPostCodeMatch.Text = "PostCode";
            this.cbPostCodeMatch.UseVisualStyleBackColor = true;
            // 
            // PossibleDuplicateOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPostCodeMatch);
            this.Controls.Add(this.cbEmailMatch);
            this.Controls.Add(this.cbPhone2Match);
            this.Controls.Add(this.cbPhone1Match);
            this.Controls.Add(this.lblPossibleDuplicateOnHeader);
            this.Name = "PossibleDuplicateOn";
            this.Size = new System.Drawing.Size(113, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPossibleDuplicateOnHeader;
        private System.Windows.Forms.CheckBox cbPhone1Match;
        private System.Windows.Forms.CheckBox cbPhone2Match;
        private System.Windows.Forms.CheckBox cbEmailMatch;
        private System.Windows.Forms.CheckBox cbPostCodeMatch;
    }
}
