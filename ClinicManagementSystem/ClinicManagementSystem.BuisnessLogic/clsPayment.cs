using System;
using System.Data;
using ClinicManagementSystem.DataAccess;


namespace ClinicManagementSystem.BuisnessLogic
{
    public class clsPayment
    {
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public string AdditionalNotes { get; set; }

        public clsPayment()
        {
            this.PaymentID = -1;
            this.PaymentDate = DateTime.Now;
            this.PaymentMethod = "";
            this.AmountPaid = 0;
            this.AdditionalNotes = "";
        }

        private clsPayment(int PaymentID, DateTime PaymentDate, string PaymentMethod,decimal AmountPaid, string AdditionalNotes)
        {
            this.PaymentID = PaymentID;
            this.PaymentDate = PaymentDate;
            this.PaymentMethod = PaymentMethod;
            this.AmountPaid = AmountPaid;
            this.AdditionalNotes = AdditionalNotes;
        }

        public static int AddPayment(DateTime PaymentDate, string PaymentMethod, decimal AmountPaid, string AdditionalNotes)
        {
            int PaymentID = clsPaymentData.AddPayment(PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);

            return PaymentID;
        }

        public static clsPayment FindPaymentByID(int PaymentID)
        {
            DateTime PaymentDate = DateTime.Now;
            string PaymentMethod = "";
            decimal AmountPaid = 0;
            string AdditionalNotes = "";

            bool IsFound = clsPaymentData.GetPaymentByID(PaymentID, ref PaymentDate, ref PaymentMethod, ref AmountPaid, ref AdditionalNotes);

            if (IsFound)
                return new clsPayment(PaymentID, PaymentDate, PaymentMethod, AmountPaid, AdditionalNotes);
            else
                return null;
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }
    }
}