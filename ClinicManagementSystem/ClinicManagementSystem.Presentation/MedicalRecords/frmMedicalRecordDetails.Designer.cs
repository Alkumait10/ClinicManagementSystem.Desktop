namespace ClinicManagementSystem.Presentation
{
    partial class frmMedicalRecordDetails
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
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtVisitDescription = new System.Windows.Forms.TextBox();
            this.lblVisitDescription = new System.Windows.Forms.Label();
            this.txtMedicalRecordID = new System.Windows.Forms.TextBox();
            this.lblMedicalRecordID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(240, 281);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.ReadOnly = true;
            this.txtAdditionalNotes.Size = new System.Drawing.Size(196, 105);
            this.txtAdditionalNotes.TabIndex = 35;
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdditionalNotes.Location = new System.Drawing.Point(34, 277);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(155, 25);
            this.lblAdditionalNotes.TabIndex = 36;
            this.lblAdditionalNotes.Text = "AdditionalNotes:";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(240, 200);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.ReadOnly = true;
            this.txtDiagnosis.Size = new System.Drawing.Size(196, 58);
            this.txtDiagnosis.TabIndex = 33;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiagnosis.Location = new System.Drawing.Point(34, 196);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(104, 25);
            this.lblDiagnosis.TabIndex = 34;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // txtVisitDescription
            // 
            this.txtVisitDescription.Location = new System.Drawing.Point(240, 73);
            this.txtVisitDescription.Multiline = true;
            this.txtVisitDescription.Name = "txtVisitDescription";
            this.txtVisitDescription.ReadOnly = true;
            this.txtVisitDescription.Size = new System.Drawing.Size(196, 105);
            this.txtVisitDescription.TabIndex = 31;
            // 
            // lblVisitDescription
            // 
            this.lblVisitDescription.AutoSize = true;
            this.lblVisitDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVisitDescription.Location = new System.Drawing.Point(34, 69);
            this.lblVisitDescription.Name = "lblVisitDescription";
            this.lblVisitDescription.Size = new System.Drawing.Size(152, 25);
            this.lblVisitDescription.TabIndex = 32;
            this.lblVisitDescription.Text = "VisitDescription:";
            // 
            // txtMedicalRecordID
            // 
            this.txtMedicalRecordID.Enabled = false;
            this.txtMedicalRecordID.Location = new System.Drawing.Point(240, 30);
            this.txtMedicalRecordID.Name = "txtMedicalRecordID";
            this.txtMedicalRecordID.ReadOnly = true;
            this.txtMedicalRecordID.Size = new System.Drawing.Size(196, 22);
            this.txtMedicalRecordID.TabIndex = 30;
            // 
            // lblMedicalRecordID
            // 
            this.lblMedicalRecordID.AutoSize = true;
            this.lblMedicalRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMedicalRecordID.Location = new System.Drawing.Point(34, 26);
            this.lblMedicalRecordID.Name = "lblMedicalRecordID";
            this.lblMedicalRecordID.Size = new System.Drawing.Size(167, 25);
            this.lblMedicalRecordID.TabIndex = 29;
            this.lblMedicalRecordID.Text = "MedicalRecordID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(329, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 53);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMedicalRecordDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 484);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAdditionalNotes);
            this.Controls.Add(this.lblAdditionalNotes);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.txtVisitDescription);
            this.Controls.Add(this.lblVisitDescription);
            this.Controls.Add(this.txtMedicalRecordID);
            this.Controls.Add(this.lblMedicalRecordID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMedicalRecordDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MedicalRecord Details";
            this.Load += new System.EventHandler(this.frmMedicalRecordDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtVisitDescription;
        private System.Windows.Forms.Label lblVisitDescription;
        private System.Windows.Forms.TextBox txtMedicalRecordID;
        private System.Windows.Forms.Label lblMedicalRecordID;
        private System.Windows.Forms.Button btnClose;
    }
}