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
    public partial class frmPrescriptionDetails : Form
    {
        private int _MedicalRecordID;
        private clsPrescription _Prescription;

        public frmPrescriptionDetails(int MedicalRecordID)
        {
            InitializeComponent();

            _MedicalRecordID = MedicalRecordID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrescriptionDetails_Load(object sender, EventArgs e)
        {
            _Prescription = clsPrescription.FindPrescriptionByMedicalRecordID(_MedicalRecordID);

            txtPrescriptionID.Text = _Prescription.PrescriptionID.ToString();
            txtMedicalRecordID.Text = _MedicalRecordID.ToString();
            txtMedicationName.Text = _Prescription.MedicationName;
            txtDosage.Text = _Prescription.Dosage;
            txtFrequency.Text = _Prescription.Frequency;
            txtStartDate.Text = _Prescription.StartDate.ToShortDateString();
            txtEndDate.Text = _Prescription.EndDate.ToShortDateString();
            txtSpecialInstructions.Text = _Prescription.SpecialInstructions;

            btnClose.Focus();
        }
    }
}
