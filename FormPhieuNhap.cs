using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLVT;

namespace quanlyvattu
{
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }
        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (vw_PhieuNhapDataGridView.CurrentRow != null)
            {
                try
                {
                    // Get the correct column name
                    string maPN = vw_PhieuNhapDataGridView.CurrentRow.Cells[0].Value.ToString(); // Temporarily use index 0

                    // Filter data for CTPN
                    DataView dv = new DataView(qlvtDataSet.CTPN);
                    dv.RowFilter = $"MAPN = '{maPN}'";

                    // Update DataSource for dgvCTPN
                    cTPNDataGridView.DataSource = dv;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Debug info - Available columns: {string.Join(", ", vw_PhieuNhapDataGridView.Columns.Cast<DataGridViewColumn>().Select(c => c.Name))}");
                    throw;
                }
            }
        }



        private void FormPhieuNhap_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.vw_PhieuNhap' table. You can move, or remove it, as needed.
            this.vw_PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vw_PhieuNhapTableAdapter.Fill(this.qlvtDataSet.vw_PhieuNhap);
            // TODO: This line of code loads data into the 'qlvtDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qlvtDataSet.CTPN);
            // TODO: This line of code loads data into the 'qlvtDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDataSet.PhieuNhap);

            // Format the DateEdit control if it exists
            if (nGAYDateEdit != null)
            {
                nGAYDateEdit.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
                nGAYDateEdit.Properties.EditFormat.FormatString = "dd-MM-yyyy";
                nGAYDateEdit.Properties.Mask.EditMask = "dd-MM-yyyy";
            }

            vw_PhieuNhapDataGridView.SelectionChanged += dgvPhieuNhap_SelectionChanged;

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }
    }
}