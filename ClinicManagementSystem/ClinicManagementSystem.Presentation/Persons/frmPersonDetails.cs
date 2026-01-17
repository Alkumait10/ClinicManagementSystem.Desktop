using System;
using System.Windows.Forms;
using ClinicManagementSystem.BuisnessLogic;


namespace ClinicManagementSystem.Presentation
{
    public partial class frmPersonDetails : Form
    {
        private int _PersonID;
        private clsPerson _Person;

        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            _Person = clsPerson.FindPersonByID(_PersonID);

            txtPersonID.Text = _PersonID.ToString();
            txtName.Text = _Person.Name.ToString();
            txtDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            txtPhoneNumber.Text = _Person.PhoneNumber.ToString();
            txtEmail.Text = _Person.Email.ToString();
            txtAddress.Text = _Person.Address.ToString();

            if (_Person.Gender == 'M')
                txtGender.Text = "Male";
            else
                txtGender.Text = "Female";

            btnEdit.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(txtPersonID.Text);

            frmAddEditPerson frm = new frmAddEditPerson(PersonID);
            frm.ShowDialog();

            frmPersonDetails_Load(null, null);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}