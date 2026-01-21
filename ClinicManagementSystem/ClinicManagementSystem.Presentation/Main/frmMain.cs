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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAppointments frm = new frmListAppointments();
            frm.ShowDialog();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDoctors frm = new frmListDoctors();
            frm.ShowDialog();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPatients frm = new frmListPatients();
            frm.ShowDialog();
        }

        private void peToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPersons frm = new frmListPersons();
            frm.ShowDialog();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPersons frm = new frmListPersons();
            frm.ShowDialog();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPersons frm = new frmListPersons();
            frm.ShowDialog();
        }

        private void medicalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMedicalRecords frm = new frmListMedicalRecords();
            frm.ShowDialog();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPrescriptions frm = new frmListPrescriptions();
            frm.ShowDialog();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPayments frm = new frmListPayments();
            frm.ShowDialog();
        }
    }
}
