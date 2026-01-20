namespace ClinicManagementSystem.Presentation
{
    partial class frmAddMedicalRecord
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtVisitDescription = new System.Windows.Forms.TextBox();
            this.lblVisitDescription = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitle.Location = new System.Drawing.Point(185, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 36);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Add New";
            // 
            // txtVisitDescription
            // 
            this.txtVisitDescription.Location = new System.Drawing.Point(288, 89);
            this.txtVisitDescription.Multiline = true;
            this.txtVisitDescription.Name = "txtVisitDescription";
            this.txtVisitDescription.Size = new System.Drawing.Size(196, 105);
            this.txtVisitDescription.TabIndex = 0;
            // 
            // lblVisitDescription
            // 
            this.lblVisitDescription.AutoSize = true;
            this.lblVisitDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVisitDescription.Location = new System.Drawing.Point(82, 85);
            this.lblVisitDescription.Name = "lblVisitDescription";
            this.lblVisitDescription.Size = new System.Drawing.Size(152, 25);
            this.lblVisitDescription.TabIndex = 24;
            this.lblVisitDescription.Text = "VisitDescription:";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(288, 216);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(196, 58);
            this.txtDiagnosis.TabIndex = 1;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiagnosis.Location = new System.Drawing.Point(82, 212);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(104, 25);
            this.lblDiagnosis.TabIndex = 26;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(288, 297);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.Size = new System.Drawing.Size(196, 105);
            this.txtAdditionalNotes.TabIndex = 2;
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdditionalNotes.Location = new System.Drawing.Point(82, 293);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(155, 25);
            this.lblAdditionalNotes.TabIndex = 28;
            this.lblAdditionalNotes.Text = "AdditionalNotes:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(377, 423);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 53);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(87, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 53);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddMedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 507);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdditionalNotes);
            this.Controls.Add(this.lblAdditionalNotes);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.txtVisitDescription);
            this.Controls.Add(this.lblVisitDescription);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMedicalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add MedicalRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtVisitDescription;
        private System.Windows.Forms.Label lblVisitDescription;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}