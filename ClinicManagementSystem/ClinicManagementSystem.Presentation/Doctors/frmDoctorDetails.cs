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
    public partial class frmDoctorDetails : Form
    {
        private int _DoctorID;
        private int _PersonID;
        private string _Specialization;

        public frmDoctorDetails(int DoctorID, int PersonID, string Specialization)
        {
            InitializeComponent();

            _DoctorID = DoctorID;
            _PersonID = PersonID;
            _Specialization = Specialization;
        }

        private void frmDoctorDetails_Load(object sender, EventArgs e)
        {
            txtDoctorID.Text = _DoctorID.ToString();

            ctrlPersonDetails1.LoadPersonInfo(_PersonID);

            txtSpecialization.Text = _Specialization;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
