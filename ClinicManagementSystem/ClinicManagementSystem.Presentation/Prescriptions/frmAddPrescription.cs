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
    public partial class frmAddPrescription : Form
    {
        private int _MedicalRecordID;

        public frmAddPrescription(int MedicalRecordID)
        {
            InitializeComponent();

            _MedicalRecordID = MedicalRecordID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MedicationName = txtMedicationName.Text;
            string Dosage = txtDosage.Text;
            string Frequency = txtFrequency.Text;
            DateTime StartDate = dtpStartDate.Value;
            DateTime EndDate = dtpEndDate.Value;
            string SpecialInstructions = txtSpecialInstructions.Text;

            if (MessageBox.Show("Are you sure you want to add this prescription?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int PrescriptionID = clsPrescription.AddPrescription(_MedicalRecordID, MedicationName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions);

            if (PrescriptionID == -1)
            {
                MessageBox.Show("Failed to add prescription", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Prescription added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            dtpStartDate.MinDate = DateTime.Now;
            dtpStartDate.MaxDate = DateTime.Now.AddDays(3);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(5);
            dtpEndDate.MaxDate = dtpStartDate.Value.AddMonths(1);
        }
    }
}
