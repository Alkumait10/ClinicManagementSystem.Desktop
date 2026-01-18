using System;
using System.Data;
using ClinicManagementSystem.DataAccess;


namespace ClinicManagementSystem.BuisnessLogic
{
    public class clsDoctor
    {
        public int DoctorID { get; set; }

        public int PersonID { get; set; }
        public clsPerson Person { get; set; }

        public string Specialization { get; set; }

        public clsDoctor()
        {
            this.DoctorID = -1;
            this.PersonID = -1;
            this.Specialization = "";
        }

        private clsDoctor(int DoctorID, int PersonID, string Specialization)
        {
            this.DoctorID = DoctorID;

            this.PersonID = PersonID;
            this.Person = clsPerson.FindPersonByID(PersonID);

            this.Specialization = Specialization;

        }

        public static bool AddNewDoctor(int PersonID, string Specialization)
        {
            int ID = clsDoctorData.AddDoctor(PersonID, Specialization);

            return (ID != -1);
        }

        public static DataTable GetAllDoctors()
        {
            return clsDoctorData.GetAllDoctors();
        }

        public static bool DeleteDoctor(int ID)
        {
            return clsDoctorData.DeleteDoctor(ID);
        }

        public static bool IsDoctorExist(int PersonID)
        {
            return clsDoctorData.IsDoctorExist(PersonID);
        }
    }
}