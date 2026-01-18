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
    public partial class frmPatientDetails : Form
    {
        private int _PatientID;
        private int _PersonID;

        public frmPatientDetails(int PatientID, int PersonID)
        {
            InitializeComponent();

            _PatientID = PatientID;
            _PersonID = PersonID;
        }

        private void frmPatientDetails_Load(object sender, EventArgs e)
        {
            txtPatientID.Text = _PatientID.ToString();

            ctrlPersonDetails1.LoadPersonInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
