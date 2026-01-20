namespace ClinicManagementSystem.Presentation
{
    partial class frmPaymentDetails
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
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Enabled = false;
            this.txtPaymentID.Location = new System.Drawing.Point(234, 33);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.ReadOnly = true;
            this.txtPaymentID.Size = new System.Drawing.Size(196, 22);
            this.txtPaymentID.TabIndex = 32;
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaymentID.Location = new System.Drawing.Point(28, 29);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(114, 25);
            this.lblPaymentID.TabIndex = 31;
            this.lblPaymentID.Text = "PaymentID:";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Enabled = false;
            this.txtPaymentDate.Location = new System.Drawing.Point(234, 75);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(196, 22);
            this.txtPaymentDate.TabIndex = 34;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaymentDate.Location = new System.Drawing.Point(28, 71);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(136, 25);
            this.lblPaymentDate.TabIndex = 33;
            this.lblPaymentDate.Text = "PaymentDate:";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Enabled = false;
            this.txtPaymentMethod.Location = new System.Drawing.Point(234, 117);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(196, 22);
            this.txtPaymentMethod.TabIndex = 36;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaymentMethod.Location = new System.Drawing.Point(28, 113);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(161, 25);
            this.lblPaymentMethod.TabIndex = 35;
            this.lblPaymentMethod.Text = "PaymentMethod:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Enabled = false;
            this.txtAmountPaid.Location = new System.Drawing.Point(234, 159);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(196, 22);
            this.txtAmountPaid.TabIndex = 38;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAmountPaid.Location = new System.Drawing.Point(28, 155);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(125, 25);
            this.lblAmountPaid.TabIndex = 37;
            this.lblAmountPaid.Text = "AmountPaid:";
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(234, 205);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.ReadOnly = true;
            this.txtAdditionalNotes.Size = new System.Drawing.Size(196, 105);
            this.txtAdditionalNotes.TabIndex = 39;
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdditionalNotes.Location = new System.Drawing.Point(28, 201);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(155, 25);
            this.lblAdditionalNotes.TabIndex = 40;
            this.lblAdditionalNotes.Text = "AdditionalNotes:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(323, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 53);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 414);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAdditionalNotes);
            this.Controls.Add(this.lblAdditionalNotes);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.txtPaymentDate);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.lblPaymentID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Details";
            this.Load += new System.EventHandler(this.frmPaymentDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Button btnClose;
    }
}