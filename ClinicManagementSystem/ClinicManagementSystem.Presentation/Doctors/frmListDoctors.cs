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
    public partial class frmListDoctors : Form
    {
        private static DataTable _AllDoctors;

        public frmListDoctors()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListDoctors_Load(object sender, EventArgs e)
        {
            _AllDoctors = clsDoctor.GetAllDoctors();
            dgvDoctors.DataSource = _AllDoctors;

            cbFilterBy.SelectedIndex = 0;

            _ConfigureDoctorsGrid();


            lblRecordsCount.Text = _AllDoctors.Rows.Count.ToString();
        }

        private void _ConfigureDoctorsGrid()
        {
            // Header
            dgvDoctors.EnableHeadersVisualStyles = false;
            dgvDoctors.ColumnHeadersHeight = 36;
            dgvDoctors.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvDoctors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvDoctors.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDoctors.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(240, 240, 240);
            dgvDoctors.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Cells
            dgvDoctors.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvDoctors.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvDoctors.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.ReadOnly = true;
            dgvDoctors.MultiSelect = false;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Layout
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvDoctors.ScrollBars = ScrollBars.Vertical;

            dgvDoctors.RowHeadersVisible = false;
            dgvDoctors.BackgroundColor = Color.White;
            dgvDoctors.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmListDoctors_Shown(object sender, EventArgs e)
        {
            dgvDoctors.ClearSelection();
            dgvDoctors.CurrentCell = null;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
                txtFilterValue.Enabled = false;
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "DoctorID":
                    FilterColumn = "DoctorID";
                    break;
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "Specialization":
                    FilterColumn = "Specialization";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllDoctors.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDoctors.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "Name" && FilterColumn != "Specialization")
                _AllDoctors.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _AllDoctors.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _AllDoctors.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;
            int PersonID = (int)dgvDoctors.CurrentRow.Cells[1].Value;
            string Specialization = (string)dgvDoctors.CurrentRow.Cells[3].Value;

            frmDoctorDetails frm = new frmDoctorDetails(DoctorID, PersonID, Specialization);
            frm.ShowDialog();

            frmListDoctors_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow == null)
                return;

            int DoctorID = (int)dgvDoctors.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (clsDoctor.DeleteDoctor(DoctorID))
                {
                    MessageBox.Show("Doctor has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListDoctors_Load(null, null);
                }
                else
                    MessageBox.Show("Doctor is not deleted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
