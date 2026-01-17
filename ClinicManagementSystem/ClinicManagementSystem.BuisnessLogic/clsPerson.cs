using System;
using System.Data;
using ClinicManagementSystem.DataAccess;


namespace ClinicManagementSystem.BuisnessLogic
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsPerson()
        {
            this.PersonID = -1;
            this.Name = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = ' ';
            this.PhoneNumber = "";
            this.Email = "";
            this.Address = "";

            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string Name, DateTime DateOfBirth, char Gender, string PhoneNumber, string Email, string Address)
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber, this.Email, this.Address);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.Name, this.DateOfBirth, this.Gender, this.PhoneNumber, this.Email, this.Address);
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonData.GetAllPersons();
        }

        public static clsPerson FindPersonByID(int PersonID)
        {
            string Name = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = ' ';
            string PhoneNumber = "";
            string Email = "";
            string Address = "";

            bool IsFound = clsPersonData.GetPersonByID(PersonID, ref Name, ref DateOfBirth, ref Gender, ref PhoneNumber, ref Email, ref Address);

            if (IsFound)
                return new clsPerson(PersonID, Name, DateOfBirth, Gender, PhoneNumber, Email, Address);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();

            }

            return false;
        }

        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

    }
}
