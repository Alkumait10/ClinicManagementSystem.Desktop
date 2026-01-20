using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmListPersons());
            //Application.Run(new frmListPatients());
            //Application.Run(new frmListDoctors());
            Application.Run(new frmListAppointments());
            //Application.Run(new frmListMedicalRecords());
            //Application.Run(new frmListPayments());
            //Application.Run(new frmListPrescriptions());
        }
    }
}
