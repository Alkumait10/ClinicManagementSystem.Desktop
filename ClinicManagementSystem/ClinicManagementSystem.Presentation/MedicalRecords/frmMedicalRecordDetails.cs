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
    public partial class frmMedicalRecordDetails : Form
    {
        private int _MedicalRecordID;
        private clsMedicalRecord _MedicalRecord;

        public frmMedicalRecordDetails(int MedicalRecordID)
        {
            InitializeComponent();

            _MedicalRecordID = MedicalRecordID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMedicalRecordDetails_Load(object sender, EventArgs e)
        {
            _MedicalRecord = clsMedicalRecord.FindMedicalRecordByID(_MedicalRecordID);

            txtMedicalRecordID.Text = _MedicalRecordID.ToString();
            txtVisitDescription.Text = _MedicalRecord.VisitDescription;
            txtDiagnosis.Text = _MedicalRecord.Diagnosis;
            txtAdditionalNotes.Text = _MedicalRecord.AdditionalNotes;

            btnClose.Focus();
        }
    }
}
