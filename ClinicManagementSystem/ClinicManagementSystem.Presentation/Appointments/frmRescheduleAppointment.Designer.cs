namespace ClinicManagementSystem.Presentation
{
    partial class frmRescheduleAppointment
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
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Location = new System.Drawing.Point(236, 32);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.ReadOnly = true;
            this.txtAppointmentID.Size = new System.Drawing.Size(196, 22);
            this.txtAppointmentID.TabIndex = 41;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAppointmentID.Location = new System.Drawing.Point(30, 28);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(147, 25);
            this.lblAppointmentID.TabIndex = 40;
            this.lblAppointmentID.Text = "AppointmentID:";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCurrentDate.Location = new System.Drawing.Point(30, 70);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(124, 25);
            this.lblCurrentDate.TabIndex = 47;
            this.lblCurrentDate.Text = "CurrentDate:";
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(236, 73);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(196, 22);
            this.txtCurrentDate.TabIndex = 48;
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.CustomFormat = "mm:HH dd/MM/yyyy";
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewDate.Location = new System.Drawing.Point(236, 119);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(196, 22);
            this.dtpNewDate.TabIndex = 50;
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNewDate.Location = new System.Drawing.Point(30, 117);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(98, 25);
            this.lblNewDate.TabIndex = 49;
            this.lblNewDate.Text = "NewDate:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(333, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(35, 170);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 50);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmRescheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.lblNewDate);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.txtAppointmentID);
            this.Controls.Add(this.lblAppointmentID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRescheduleAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reschedule Appointment";
            this.Load += new System.EventHandler(this.frmRescheduleAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}