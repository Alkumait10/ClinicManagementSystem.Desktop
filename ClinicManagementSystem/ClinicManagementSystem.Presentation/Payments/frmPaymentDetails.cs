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
    public partial class frmPaymentDetails : Form
    {
        private int _PaymentID;
        private clsPayment _Payment;

        public frmPaymentDetails(int PaymentID)
        {
            InitializeComponent();

            _PaymentID = PaymentID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPaymentDetails_Load(object sender, EventArgs e)
        {
            _Payment = clsPayment.FindPaymentByID(_PaymentID);

            txtPaymentID.Text = _PaymentID.ToString();
            txtPaymentDate.Text = _Payment.PaymentDate.ToString();
            txtPaymentMethod.Text = _Payment.PaymentMethod;
            txtAmountPaid.Text = _Payment.AmountPaid.ToString();
            txtAdditionalNotes.Text = _Payment.AdditionalNotes;

            btnClose.Focus();
        }
    }
}
