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
    public partial class ctrlPersonDetails : UserControl
    {
        private int _PersonID;
        private clsPerson _Person;

        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }
        public clsPerson Person
        {
            get
            {
                return _Person;
            }
        }

        public ctrlPersonDetails()
        {
            InitializeComponent();
        }


        public void LoadPersonInfo(int PersonID)
        {
            _PersonID = PersonID;
            _Person = clsPerson.FindPersonByID(_PersonID);

            txtPersonID.Text = _PersonID.ToString();
            txtName.Text = _Person.Name.ToString();
            txtDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            txtGender.Text = _Person.Gender.ToString();
            txtPhoneNumber.Text = _Person.PhoneNumber.ToString();
            txtEmail.Text = _Person.Email.ToString();
            txtAddress.Text = _Person.Address.ToString();
        }
    }
}
