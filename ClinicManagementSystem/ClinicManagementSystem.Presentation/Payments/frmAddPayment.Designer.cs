namespace ClinicManagementSystem.Presentation
{
    partial class frmAddPayment
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
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtAdditionalNotes = new System.Windows.Forms.TextBox();
            this.lblAdditionalNotes = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(235, 75);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(196, 22);
            this.txtAmountPaid.TabIndex = 1;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAmountPaid.Location = new System.Drawing.Point(29, 71);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(125, 25);
            this.lblAmountPaid.TabIndex = 44;
            this.lblAmountPaid.Text = "AmountPaid:";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(235, 33);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(196, 22);
            this.txtPaymentMethod.TabIndex = 0;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPaymentMethod.Location = new System.Drawing.Point(29, 29);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(161, 25);
            this.lblPaymentMethod.TabIndex = 42;
            this.lblPaymentMethod.Text = "PaymentMethod:";
            // 
            // txtAdditionalNotes
            // 
            this.txtAdditionalNotes.Location = new System.Drawing.Point(235, 122);
            this.txtAdditionalNotes.Multiline = true;
            this.txtAdditionalNotes.Name = "txtAdditionalNotes";
            this.txtAdditionalNotes.Size = new System.Drawing.Size(196, 105);
            this.txtAdditionalNotes.TabIndex = 3;
            // 
            // lblAdditionalNotes
            // 
            this.lblAdditionalNotes.AutoSize = true;
            this.lblAdditionalNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdditionalNotes.Location = new System.Drawing.Point(29, 118);
            this.lblAdditionalNotes.Name = "lblAdditionalNotes";
            this.lblAdditionalNotes.Size = new System.Drawing.Size(155, 25);
            this.lblAdditionalNotes.TabIndex = 47;
            this.lblAdditionalNotes.Text = "AdditionalNotes:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Location = new System.Drawing.Point(34, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 53);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(324, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 53);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 317);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdditionalNotes);
            this.Controls.Add(this.lblAdditionalNotes);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtAdditionalNotes;
        private System.Windows.Forms.Label lblAdditionalNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}