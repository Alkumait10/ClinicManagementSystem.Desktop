using System;
using System.Data;
using ClinicManagementSystem.DataAccess;


namespace ClinicManagementSystem.BuisnessLogic
{
    public class clsAppointment
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string AppointmentStatus { get; set; }
        public int MedicalRecordID { get; set; }
        public int PaymentID { get; set; }


        public clsAppointment()
        {
            this.AppointmentID = -1;
            this.PatientID = -1;
            this.DoctorID = -1;
            this.AppointmentDateTime = DateTime.Now;
            this.AppointmentStatus = "";
            this.MedicalRecordID = -1;
            this.PaymentID = -1;
        }

        private clsAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDateTime, string AppointmentStatus, int MedicalRecordID, int PaymentID)
        {
            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.AppointmentDateTime = AppointmentDateTime;
            this.AppointmentStatus = AppointmentStatus;
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;
        }

        public static bool CreateNewAppointment(int PatientID, int DoctorID, DateTime AppointmentDateTime)
        {
            int AppointmentID = clsAppointmentData.AddAppointment(PatientID, DoctorID, AppointmentDateTime);

            return (AppointmentID != -1);
        }

        public static bool ChangeAppointmentStatus(int AppointmentID, string AppointmentStatus)
        {
            return clsAppointmentData.UpdateAppointmentStatus(AppointmentID, AppointmentStatus);
        }

        public static bool RescheduleAppointment(int AppointmentID, DateTime AppointmentDateTime)
        {
            return clsAppointmentData.UpdateAppointmentDate(AppointmentID, AppointmentDateTime);
        }

        public static DataTable GetAllAppointments()
        {
            return clsAppointmentData.GetAllAppointments();
        }

        public static clsAppointment FindAppointmentByID(int AppointmentID)
        {
            int PatientID = -1;
            int DoctorID = -1;
            DateTime AppointmentDateTime = DateTime.Now;
            string AppointmentStatus = "";
            int MedicalRecordID = -1;
            int PaymentID = -1;

            bool IsFound = clsAppointmentData.GetAppointmentByID(AppointmentID, ref PatientID, ref DoctorID, ref AppointmentDateTime, ref AppointmentStatus, ref MedicalRecordID, ref PaymentID);

            if (IsFound)
                return new clsAppointment(AppointmentID, PatientID, DoctorID, AppointmentDateTime, AppointmentStatus, MedicalRecordID, PaymentID);
            else
                return null;
        }

        public static bool IsAppointmentExists(int AppointmentID)
        {
            return clsAppointmentData.IsAppointmentExists(AppointmentID);
        }
    }
}