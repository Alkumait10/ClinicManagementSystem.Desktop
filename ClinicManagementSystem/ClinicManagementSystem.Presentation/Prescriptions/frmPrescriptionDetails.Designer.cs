namespace ClinicManagementSystem.Presentation
{
    partial class frmPrescriptionDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtMedicationName = new System.Windows.Forms.TextBox();
            this.lblMedicationName = new System.Windows.Forms.Label();
            this.txtMedicalRecordID = new System.Windows.Forms.TextBox();
            this.lblMedicalRecordID = new System.Windows.Forms.Label();
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(324, 441);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 53);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.Location = new System.Drawing.Point(235, 316);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.ReadOnly = true;
            this.txtSpecialInstructions.Size = new System.Drawing.Size(196, 105);
            this.txtSpecialInstructions.TabIndex = 69;
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSpecialInstructions.Location = new System.Drawing.Point(29, 312);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(182, 25);
            this.lblSpecialInstructions.TabIndex = 76;
            this.lblSpecialInstructions.Text = "SpecialInstructions:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndDate.Location = new System.Drawing.Point(29, 267);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(94, 25);
            this.lblEndDate.TabIndex = 75;
            this.lblEndDate.Text = "EndDate:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartDate.Location = new System.Drawing.Point(29, 227);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 25);
            this.lblStartDate.TabIndex = 74;
            this.lblStartDate.Text = "StartDate:";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(235, 187);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ReadOnly = true;
            this.txtFrequency.Size = new System.Drawing.Size(196, 22);
            this.txtFrequency.TabIndex = 66;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFrequency.Location = new System.Drawing.Point(29, 187);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(111, 25);
            this.lblFrequency.TabIndex = 73;
            this.lblFrequency.Text = "Frequency:";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(235, 147);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.ReadOnly = true;
            this.txtDosage.Size = new System.Drawing.Size(196, 22);
            this.txtDosage.TabIndex = 65;
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDosage.Location = new System.Drawing.Point(29, 147);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(86, 25);
            this.lblDosage.TabIndex = 72;
            this.lblDosage.Text = "Dosage:";
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(235, 108);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.ReadOnly = true;
            this.txtMedicationName.Size = new System.Drawing.Size(196, 22);
            this.txtMedicationName.TabIndex = 64;
            // 
            // lblMedicationName
            // 
            this.lblMedicationName.AutoSize = true;
            this.lblMedicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMedicationName.Location = new System.Drawing.Point(29, 108);
            this.lblMedicationName.Name = "lblMedicationName";
            this.lblMedicationName.Size = new System.Drawing.Size(165, 25);
            this.lblMedicationName.TabIndex = 71;
            this.lblMedicationName.Text = "MedicationName:";
            // 
            // txtMedicalRecordID
            // 
            this.txtMedicalRecordID.Location = new System.Drawing.Point(235, 67);
            this.txtMedicalRecordID.Name = "txtMedicalRecordID";
            this.txtMedicalRecordID.ReadOnly = true;
            this.txtMedicalRecordID.Size = new System.Drawing.Size(196, 22);
            this.txtMedicalRecordID.TabIndex = 78;
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMedicalRecordID.Location = new System.Drawing.Point(29, 67);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(167, 25);
            this.lblMedicalRecordID.TabIndex = 79;
            this.lblMedicalRecordID.Text = "MedicalRecordID:";
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(235, 28);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.ReadOnly = true;
            this.txtPrescriptionID.Size = new System.Drawing.Size(196, 22);
            this.txtPrescriptionID.TabIndex = 80;
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrescriptionID.Location = new System.Drawing.Point(29, 28);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(139, 25);
            this.lblPrescriptionID.TabIndex = 81;
            this.lblPrescriptionID.Text = "PrescriptionID:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(235, 230);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(196, 22);
            this.txtStartDate.TabIndex = 82;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(235, 270);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(196, 22);
            this.txtEndDate.TabIndex = 83;
            // 
            // frmPrescriptionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 520);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtPrescriptionID);
            this.Controls.Add(this.lblPrescriptionID);
            this.Controls.Add(this.txtMedicalRecordID);
            this.Controls.Add(this.lblMedicalRecordID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSpecialInstructions);
            this.Controls.Add(this.lblSpecialInstructions);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.lblDosage);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.lblMedicationName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrescriptionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prescription Details";
            this.Load += new System.EventHandler(this.frmPrescriptionDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtMedicationName;
        private System.Windows.Forms.Label lblMedicationName;
        private System.Windows.Forms.TextBox txtMedicalRecordID;
        private System.Windows.Forms.Label lblMedicalRecordID;
        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
    }
}