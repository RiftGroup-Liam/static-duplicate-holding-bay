namespace Rift.UK.Client.RGI2.Forms
{
    partial class MainForm
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCreateHistoryRecord = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPaginationInformation = new System.Windows.Forms.Label();
            this.PDDetails = new Rift.UK.Client.RGI2.Forms.PossibleDuplicateDetails();
            this.PDList = new Rift.UK.Client.RGI2.Forms.PossibleDuplicateList();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(988, 585);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(134, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCreateHistoryRecord
            // 
            this.btnCreateHistoryRecord.Location = new System.Drawing.Point(988, 614);
            this.btnCreateHistoryRecord.Name = "btnCreateHistoryRecord";
            this.btnCreateHistoryRecord.Size = new System.Drawing.Size(134, 23);
            this.btnCreateHistoryRecord.TabIndex = 4;
            this.btnCreateHistoryRecord.Text = "Create History Record";
            this.btnCreateHistoryRecord.UseVisualStyleBackColor = true;
            this.btnCreateHistoryRecord.Click += new System.EventHandler(this.btnCreateHistoryRecord_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(988, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(31, 336);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(128, 336);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPaginationInformation
            // 
            this.lblPaginationInformation.AutoSize = true;
            this.lblPaginationInformation.Location = new System.Drawing.Point(61, 314);
            this.lblPaginationInformation.Name = "lblPaginationInformation";
            this.lblPaginationInformation.Size = new System.Drawing.Size(125, 13);
            this.lblPaginationInformation.TabIndex = 8;
            this.lblPaginationInformation.Text = "Viewing <> -> <> (Total: )";
            // 
            // PDDetails
            // 
            this.PDDetails.Location = new System.Drawing.Point(248, 13);
            this.PDDetails.Name = "PDDetails";
            this.PDDetails.Size = new System.Drawing.Size(874, 621);
            this.PDDetails.TabIndex = 1;
            // 
            // PDList
            // 
            this.PDList.Location = new System.Drawing.Point(13, 13);
            this.PDList.Name = "PDList";
            this.PDList.SelectedPossibleDuplicate = null;
            this.PDList.Size = new System.Drawing.Size(214, 281);
            this.PDList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 646);
            this.Controls.Add(this.lblPaginationInformation);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateHistoryRecord);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.PDDetails);
            this.Controls.Add(this.PDList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1140, 674);
            this.MinimumSize = new System.Drawing.Size(1140, 674);
            this.Name = "MainForm";
            this.Text = "Goldmine Importer Possible Duplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PossibleDuplicateList PDList;
        private PossibleDuplicateDetails PDDetails;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCreateHistoryRecord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPaginationInformation;
    }
}

