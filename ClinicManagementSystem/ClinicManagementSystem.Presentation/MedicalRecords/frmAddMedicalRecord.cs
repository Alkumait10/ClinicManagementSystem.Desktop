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
    public partial class frmAddMedicalRecord : Form
    {
        private int _AppointmentID;

        public frmAddMedicalRecord(int AppointmentID)
        {
            InitializeComponent();

            _AppointmentID = AppointmentID;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string VisitDescription = txtVisitDescription.Text;
            string Diagnosis = txtDiagnosis.Text;
            string AdditionalNotes = txtAdditionalNotes.Text;

            if (MessageBox.Show("Are you sure you want to add this medical record?", "Confirm add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            int MedicalRecordID = clsMedicalRecord.CreateMedicalRecord(VisitDescription, Diagnosis, AdditionalNotes);

            if (MedicalRecordID == -1)
            {
                MessageBox.Show("Failed to add medical record", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool linked = clsAppointment.AttachMedicalRecordToAppointment(_AppointmentID, MedicalRecordID);

            if (!linked)
            {
                MessageBox.Show("Medical record added but failed to link with appointment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show("Medical record added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
