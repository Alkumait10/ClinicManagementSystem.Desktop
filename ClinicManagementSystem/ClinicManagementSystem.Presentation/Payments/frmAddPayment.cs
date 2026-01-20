using ClinicManagementSystem.BuisnessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Presentation
{
    public partial class frmAddPayment : Form
    {
        private int _AppointmentID;

        public frmAddPayment(int AppointmentID)
        {
            InitializeComponent();

            _AppointmentID = AppointmentID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime PaymentDate = DateTime.Now;
            string PaymentMethod = txtPaymentMethod.Text;
            decimal AmountPaid = Convert.ToDecimal(txtAmountPaid.Text);
            string AdditionalNotes = txtAdditionalNotes.Text;

            if (MessageBox.Show("Are you sure you want to add this payment?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int PaymentID = clsPayment.AddPayment(PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);

            if (PaymentID == -1)
            {
                MessageBox.Show("Failed to add payment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool linked = clsAppointment.AttachPaymentToAppointment(_AppointmentID, PaymentID);

            if (!linked)
            {
                MessageBox.Show("Payment added but failed to link with appointment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show("Payment added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clsAppointment.ChangeAppointmentStatus(_AppointmentID, "Completed");

            this.Close();
        }
    }
}
