namespace ClinicManagementSystem.Presentation
{
    partial class frmListMedicalRecords
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvMedicalRecords = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPrescriptionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(1206, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 46);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(111, 295);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lblRecordsCount.TabIndex = 30;
            this.lblRecordsCount.Text = "??";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecords.ForeColor = System.Drawing.Color.Black;
            this.lblRecords.Location = new System.Drawing.Point(29, 295);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(86, 20);
            this.lblRecords.TabIndex = 29;
            this.lblRecords.Text = "# Records";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(332, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(593, 58);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Manage Medical Records";
            // 
            // dgvMedicalRecords
            // 
            this.dgvMedicalRecords.AllowUserToAddRows = false;
            this.dgvMedicalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicalRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalRecords.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMedicalRecords.EnableHeadersVisualStyles = false;
            this.dgvMedicalRecords.Location = new System.Drawing.Point(23, 113);
            this.dgvMedicalRecords.MultiSelect = false;
            this.dgvMedicalRecords.Name = "dgvMedicalRecords";
            this.dgvMedicalRecords.ReadOnly = true;
            this.dgvMedicalRecords.RowHeadersVisible = false;
            this.dgvMedicalRecords.RowHeadersWidth = 51;
            this.dgvMedicalRecords.RowTemplate.Height = 24;
            this.dgvMedicalRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMedicalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicalRecords.Size = new System.Drawing.Size(1262, 179);
            this.dgvMedicalRecords.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPrescriptionToolStripMenuItem,
            this.showPrescriptionDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addPrescriptionToolStripMenuItem
            // 
            this.addPrescriptionToolStripMenuItem.Name = "addPrescriptionToolStripMenuItem";
            this.addPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.addPrescriptionToolStripMenuItem.Text = "Add Prescription";
            this.addPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.addPrescriptionToolStripMenuItem_Click);
            // 
            // showPrescriptionDetailsToolStripMenuItem
            // 
            this.showPrescriptionDetailsToolStripMenuItem.Name = "showPrescriptionDetailsToolStripMenuItem";
            this.showPrescriptionDetailsToolStripMenuItem.Size = new System.Drawing.Size(246, 24);
            this.showPrescriptionDetailsToolStripMenuItem.Text = "Show Prescription Details";
            this.showPrescriptionDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPrescriptionDetailsToolStripMenuItem_Click);
            // 
            // frmListMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 382);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvMedicalRecords);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListMedicalRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List MedicalRecords";
            this.Load += new System.EventHandler(this.frmListMedicalRecords_Load);
            this.Shown += new System.EventHandler(this.frmListMedicalRecords_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPrescriptionDetailsToolStripMenuItem;
    }
}