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
    public partial class frmRescheduleAppointment : Form
    {
        private int _AppointmentID;
        private DateTime _CurrentDate;

        public frmRescheduleAppointment(int AppointmentID, DateTime CurrentDate)
        {
            InitializeComponent();

            _AppointmentID = AppointmentID;
            _CurrentDate = CurrentDate;
        }

        private void frmRescheduleAppointment_Load(object sender, EventArgs e)
        {
            txtAppointmentID.Text = _AppointmentID.ToString();
            txtCurrentDate.Text = _CurrentDate.ToString();

            dtpNewDate.Value = _CurrentDate;

            btnSave.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime NewDate = dtpNewDate.Value;

            if (MessageBox.Show("Are you sure you want to reschedule this appointment?", "Confirm Reschedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (clsAppointment.RescheduleAppointment(_AppointmentID, NewDate))
            {
                MessageBox.Show("Appointment rescheduled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to reschedule appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
