namespace ClinicManagementSystem.Presentation
{
    partial class frmListAppointments
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
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMedicalRecordDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rescheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPrescriptionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(336, 118);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(194, 22);
            this.txtFilterValue.TabIndex = 26;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilterBy.Location = new System.Drawing.Point(19, 120);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(82, 25);
            this.lblFilterBy.TabIndex = 25;
            this.lblFilterBy.Text = "Filter By";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "AppointmentID",
            "PatientID",
            "PatientName",
            "DoctorID",
            "DoctorName"});
            this.cbFilterBy.Location = new System.Drawing.Point(123, 118);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(207, 24);
            this.cbFilterBy.TabIndex = 24;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(1450, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 46);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(100, 341);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lblRecordsCount.TabIndex = 22;
            this.lblRecordsCount.Text = "??";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecords.ForeColor = System.Drawing.Color.Black;
            this.lblRecords.Location = new System.Drawing.Point(18, 341);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(86, 20);
            this.lblRecords.TabIndex = 21;
            this.lblRecords.Text = "# Records";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(500, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(527, 58);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Manage Appointments";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddNewAppointment.Location = new System.Drawing.Point(1461, 107);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(68, 46);
            this.btnAddNewAppointment.TabIndex = 19;
            this.btnAddNewAppointment.Text = "Add";
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 159);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(1517, 179);
            this.dgvAppointments.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMedicalRecordToolStripMenuItem,
            this.showMedicalRecordDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addPrescriptionToolStripMenuItem,
            this.showPrescriptionDetailsToolStripMenuItem,
            this.toolStripSeparator4,
            this.addPaymentToolStripMenuItem,
            this.showPaymentDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.rescheduleToolStripMenuItem,
            this.toolStripSeparator3,
            this.cancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(273, 248);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addMedicalRecordToolStripMenuItem
            // 
            this.addMedicalRecordToolStripMenuItem.Name = "addMedicalRecordToolStripMenuItem";
            this.addMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.addMedicalRecordToolStripMenuItem.Text = "Add Medical Record";
            this.addMedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.addMedicalRecordToolStripMenuItem_Click);
            // 
            // showMedicalRecordDetailsToolStripMenuItem
            // 
            this.showMedicalRecordDetailsToolStripMenuItem.Name = "showMedicalRecordDetailsToolStripMenuItem";
            this.showMedicalRecordDetailsToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.showMedicalRecordDetailsToolStripMenuItem.Text = "Show Medical Record Details";
            this.showMedicalRecordDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMedicalRecordDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.addPaymentToolStripMenuItem.Text = "Add Payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.addPaymentToolStripMenuItem_Click);
            // 
            // showPaymentDetailsToolStripMenuItem
            // 
            this.showPaymentDetailsToolStripMenuItem.Name = "showPaymentDetailsToolStripMenuItem";
            this.showPaymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.showPaymentDetailsToolStripMenuItem.Text = "Show Payment Details";
            this.showPaymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPaymentDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // rescheduleToolStripMenuItem
            // 
            this.rescheduleToolStripMenuItem.Name = "rescheduleToolStripMenuItem";
            this.rescheduleToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.rescheduleToolStripMenuItem.Text = "Reschedule";
            this.rescheduleToolStripMenuItem.Click += new System.EventHandler(this.rescheduleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(269, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // addPrescriptionToolStripMenuItem
            // 
            this.addPrescriptionToolStripMenuItem.Name = "addPrescriptionToolStripMenuItem";
            this.addPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.addPrescriptionToolStripMenuItem.Text = "Add Prescription";
            this.addPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.addPrescriptionToolStripMenuItem_Click);
            // 
            // showPrescriptionDetailsToolStripMenuItem
            // 
            this.showPrescriptionDetailsToolStripMenuItem.Name = "showPrescriptionDetailsToolStripMenuItem";
            this.showPrescriptionDetailsToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.showPrescriptionDetailsToolStripMenuItem.Text = "Show Prescription Details";
            this.showPrescriptionDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPrescriptionDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(269, 6);
            // 
            // frmListAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 425);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Appointments";
            this.Load += new System.EventHandler(this.frmListAppointments_Load);
            this.Shown += new System.EventHandler(this.frmListAppointments_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMedicalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMedicalRecordDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPrescriptionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}