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
    public partial class frmListPayments : Form
    {
        private static DataTable _AllPayments;

        public frmListPayments()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListPayments_Load(object sender, EventArgs e)
        {
            _AllPayments = clsPayment.GetAllPayments();
            dgvPayments.DataSource = _AllPayments;

            _ConfigurePaymentsGrid();


            lblRecordsCount.Text = _AllPayments.Rows.Count.ToString();
        }

        private void _ConfigurePaymentsGrid()
        {
            // Header
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.ColumnHeadersHeight = 36;
            dgvPayments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPayments.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPayments.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(240, 240, 240);
            dgvPayments.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            // Cells
            dgvPayments.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvPayments.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvPayments.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.ReadOnly = true;
            dgvPayments.MultiSelect = false;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Layout
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPayments.ScrollBars = ScrollBars.Vertical;

            dgvPayments.RowHeadersVisible = false;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmListPayments_Shown(object sender, EventArgs e)
        {
            dgvPayments.ClearSelection();
            dgvPayments.CurrentCell = null;
        }
    }
}
