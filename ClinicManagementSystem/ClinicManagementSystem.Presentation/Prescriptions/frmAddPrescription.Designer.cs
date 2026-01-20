namespace ClinicManagementSystem.Presentation
{
    partial class frmAddPrescription
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
            this.txtMedicationName = new System.Windows.Forms.TextBox();
            this.lblMedicationName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.lblDosage = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(315, 125);
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(196, 22);
            this.txtMedicationName.TabIndex = 0;
            // 
            // lblMedicationName
            // 
            this.lblMedicationName.AutoSize = true;
            this.lblMedicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMedicationName.Location = new System.Drawing.Point(109, 125);
            this.lblMedicationName.Name = "lblMedicationName";
            this.lblMedicationName.Size = new System.Drawing.Size(165, 25);
            this.lblMedicationName.TabIndex = 49;
            this.lblMedicationName.Text = "MedicationName:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(137, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 46);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Add Prescription";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(315, 164);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(196, 22);
            this.txtDosage.TabIndex = 1;
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDosage.Location = new System.Drawing.Point(109, 164);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(86, 25);
            this.lblDosage.TabIndex = 52;
            this.lblDosage.Text = "Dosage:";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(315, 204);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(196, 22);
            this.txtFrequency.TabIndex = 2;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFrequency.Location = new System.Drawing.Point(109, 204);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(111, 25);
            this.lblFrequency.TabIndex = 54;
            this.lblFrequency.Text = "Frequency:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(315, 247);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(196, 22);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartDate.Location = new System.Drawing.Point(109, 244);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 25);
            this.lblStartDate.TabIndex = 56;
            this.lblStartDate.Text = "StartDate:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(315, 287);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(196, 22);
            this.dtpEndDate.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndDate.Location = new System.Drawing.Point(109, 284);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(94, 25);
            this.lblEndDate.TabIndex = 58;
            this.lblEndDate.Text = "EndDate:";
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.Location = new System.Drawing.Point(315, 333);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.Size = new System.Drawing.Size(196, 105);
            this.txtSpecialInstructions.TabIndex = 5;
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSpecialInstructions.Location = new System.Drawing.Point(109, 329);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(182, 25);
            this.lblSpecialInstructions.TabIndex = 61;
            this.lblSpecialInstructions.Text = "SpecialInstructions:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(114, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 53);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(404, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 576);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSpecialInstructions);
            this.Controls.Add(this.lblSpecialInstructions);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.lblDosage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMedicationName);
            this.Controls.Add(this.lblMedicationName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Prescription";
            this.Load += new System.EventHandler(this.frmAddPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedicationName;
        private System.Windows.Forms.Label lblMedicationName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}