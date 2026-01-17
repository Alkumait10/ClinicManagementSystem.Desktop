using ClinicManagementSystem.BuisnessLogic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem.Presentation
{
    public partial class frmAddEditPerson : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _PersonID = -1;
        clsPerson _person;

        public frmAddEditPerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                this.Text = "Add New Person";
                _person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";
            }

            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            cbMale.Checked = false;
            cbFemale.Checked = false;
            dtpDateOfBirth.Value = DateTime.Now;
        }

        private void _LoadData()
        {
            _person = clsPerson.FindPersonByID(_PersonID);


            if (_person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            txtPersonID.Text = _person.PersonID.ToString();
            txtName.Text = _person.Name;
            dtpDateOfBirth.Value = _person.DateOfBirth;
            txtPhoneNumber.Text = _person.PhoneNumber;
            txtEmail.Text = _person.Email;
            txtAddress.Text = _person.Address;

            if (_person.Gender == 'M')
            {
                cbMale.Checked = true;
                cbFemale.Checked = false;
            }
            else
            {
                cbFemale.Checked = true;
                cbMale.Checked = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _person.Name = txtName.Text;
            _person.DateOfBirth = dtpDateOfBirth.Value;
            _person.PhoneNumber = txtPhoneNumber.Text;
            _person.Email = txtEmail.Text;
            _person.Address = txtAddress.Text;

            if (cbMale.Checked)
                _person.Gender = 'M';
            else
                _person.Gender = 'F';

            if (_person.Save())
            {
                txtPersonID.Text = _person.PersonID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update Person";
                this.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }
    }
}
