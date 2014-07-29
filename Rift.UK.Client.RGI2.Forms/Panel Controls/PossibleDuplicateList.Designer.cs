namespace Rift.UK.Client.RGI2.Forms
{
    partial class PossibleDuplicateList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPossibleDuplicates = new System.Windows.Forms.DataGridView();
            this.cONTACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gMPossibleDuplicateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleDuplicates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMPossibleDuplicateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPossibleDuplicates
            // 
            this.dgvPossibleDuplicates.AllowUserToAddRows = false;
            this.dgvPossibleDuplicates.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPossibleDuplicates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPossibleDuplicates.AutoGenerateColumns = false;
            this.dgvPossibleDuplicates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPossibleDuplicates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cONTACTDataGridViewTextBoxColumn});
            this.dgvPossibleDuplicates.DataSource = this.gMPossibleDuplicateBindingSource;
            this.dgvPossibleDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPossibleDuplicates.Location = new System.Drawing.Point(0, 0);
            this.dgvPossibleDuplicates.MultiSelect = false;
            this.dgvPossibleDuplicates.Name = "dgvPossibleDuplicates";
            this.dgvPossibleDuplicates.ReadOnly = true;
            this.dgvPossibleDuplicates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPossibleDuplicates.Size = new System.Drawing.Size(214, 571);
            this.dgvPossibleDuplicates.TabIndex = 0;
            this.dgvPossibleDuplicates.SelectionChanged += new System.EventHandler(this.dgvPossibleDuplicates_SelectionChanged);
            // 
            // cONTACTDataGridViewTextBoxColumn
            // 
            this.cONTACTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.cONTACTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT";
            this.cONTACTDataGridViewTextBoxColumn.Name = "cONTACTDataGridViewTextBoxColumn";
            this.cONTACTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gMPossibleDuplicateBindingSource
            // 
            this.gMPossibleDuplicateBindingSource.DataSource = typeof(Rift.UK.Core.RGI2.REO.GMPossibleDuplicate);
            // 
            // PossibleDuplicateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPossibleDuplicates);
            this.Name = "PossibleDuplicateList";
            this.Size = new System.Drawing.Size(214, 571);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleDuplicates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMPossibleDuplicateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPossibleDuplicates;
        private System.Windows.Forms.BindingSource gMPossibleDuplicateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTDataGridViewTextBoxColumn;
    }
}
