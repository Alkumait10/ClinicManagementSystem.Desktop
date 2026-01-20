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
    public partial class frmListPrescriptions : Form
    {
        private static DataTable _AllPrescriptions;

        public frmListPrescriptions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListPrescriptions_Load(object sender, EventArgs e)
        {
            _AllPrescriptions = clsPrescription.GetAllPrescriptions();
            dgvPrescriptions.DataSource = _AllPrescriptions;

            _ConfigurePrescriptionsGrid();


            lblRecordsCount.Text = _AllPrescriptions.Rows.Count.ToString();
        }

        private void _ConfigurePrescriptionsGrid()
        {
            // Header
            dgvPrescriptions.EnableHeadersVisualStyles = false;
            dgvPrescriptions.ColumnHeadersHeight = 36;
            dgvPrescriptions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvPrescriptions.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPrescriptions.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPrescriptions.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(240, 240, 240);
            dgvPrescriptions.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Cells
            dgvPrescriptions.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvPrescriptions.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvPrescriptions.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior
            dgvPrescriptions.AllowUserToAddRows = false;
            dgvPrescriptions.ReadOnly = true;
            dgvPrescriptions.MultiSelect = false;
            dgvPrescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Layout
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPrescriptions.ScrollBars = ScrollBars.Vertical;

            dgvPrescriptions.RowHeadersVisible = false;
            dgvPrescriptions.BackgroundColor = Color.White;
            dgvPrescriptions.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmListPrescriptions_Shown(object sender, EventArgs e)
        {
            dgvPrescriptions.ClearSelection();
            dgvPrescriptions.CurrentCell = null;
        }
    }
}
