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
    public partial class frmAddAppointment : Form
    {
        private int _PatientID;
        private string _Name;

        public frmAddAppointment(int PatientID, string Name)
        {
            InitializeComponent();

            _PatientID = PatientID;
            _Name = Name;
        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            txtPatientID.Text = _PatientID.ToString();
            txtName.Text = _Name;

            List<Tuple<int, string>> doctors = clsDoctor.GetDoctors();

            cbDoctors.DataSource = doctors;

            cbDoctors.DisplayMember = "Item2";
            cbDoctors.ValueMember = "Item1";

            cbDoctors.SelectedIndex = 0;

            dtpDate.MinDate = DateTime.Now;
            dtpDate.MaxDate = DateTime.Now.AddYears(2);

            btnAdd.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)cbDoctors.SelectedValue;

            DateTime dt = dtpDate.Value;
            DateTime cleanDate = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0, 0);

            if (clsAppointment.CreateNewAppointment(_PatientID, DoctorID, cleanDate))
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
