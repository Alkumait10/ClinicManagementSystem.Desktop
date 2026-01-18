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
    public partial class frmAddDoctor : Form
    {
        private int _PersonID;
        private string _Name;

        public frmAddDoctor(int PersonID, string Name)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Name = Name;
        }

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            txtPersonID.Text = _PersonID.ToString();
            txtName.Text = _Name;

            txtSpecialization.Focus();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            string Specialization = txtSpecialization.Text;

            if (MessageBox.Show("Are you sure you want to register this person as a doctor?", "Confirm registery", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsDoctor.AddNewDoctor(_PersonID, Specialization))
                    MessageBox.Show("Doctor registered successfully", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to make this person as doctor", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
