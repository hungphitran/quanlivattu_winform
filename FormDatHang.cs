using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports;
using QLVT;
using static quanlyvattu.qlvtDataSet;

namespace quanlyvattu
{
    public partial class FormDatHang : Form
    {
        public Form formBaocao;
        public FormDatHang()
        {
            InitializeComponent();
            FormDatHang_Load();
        }

        private void FormDatHang_Load()
        {
            // TODO: This line of code loads data into the 'qlvtDataSet1.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            try
            {
                this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qlvtDataSet1.DatHang);

                this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Fill(this.qlvtDataSet1.sp_BaoCaoDonDatHangChuaNhap);
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.qlvtDataSet1.CTDDH);
                this.cTDDHDataGridView.DataSource = this.cTDDHBindingSource;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            // 1. Add a column to the DataTable
            if (!qlvtDataSet1.DatHang.Columns.Contains("status"))
            {
                qlvtDataSet1.DatHang.Columns.Add("status", typeof(string));
            }

            // 2. Set the DataPropertyName of the DataGridView column (in Designer or code)
            var newCol = new DataGridViewTextBoxColumn();
            newCol.DataPropertyName = "status";
            newCol.HeaderText = "Trạng thái";
            datHangDataGridView.Columns.Add(newCol);

            // 3. Set the value via the BindingSource
            foreach (DataRow row in qlvtDataSet1.DatHang.Rows)
            {
                if(sp_BaoCaoDonDatHangChuaNhapBindingSource.Find("MasoDDH", row["MasoDDH"]) != -1)
                {
                    row["status"] = "Chưa nhập";
                }
                else row["status"] = "Đã nhập";
            }
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this,new Dashboard());
        }

        private void notImportBtn_Click(object sender, EventArgs e)
        {
            this.notImportBtn.Enabled = false;
            if (formBaocao != null)
            {
                formBaocao.Close();
            }
            ddhChuaNhapRep rep = new ddhChuaNhapRep();
            formBaocao = new FormBaoCao(rep);

            if (rep.RowCount <= 0)
            {
                MessageBox.Show("Báo cáo không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.notImportBtn.Enabled = true;

            }
            else
            {
                formBaocao.FormClosed += (s, args) => this.notImportBtn.Enabled = true;
                formBaocao.Show();
            } 

        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if(this.datHangDataGridView.CurrentRow.Cells[4].Value.ToString() =="Đã nhập")
            {
                MessageBox.Show("Đơn đặt hàng đã nhập không thể tạo phiếu nhập");
                return;
            }
            FormManager.switchForm(this, new FormTaoPhieuNhap(this.datHangDataGridView.CurrentRow.Cells[0].Value.ToString()));// ma ddh
        }

        private void addDdhBtn_Click(object sender, EventArgs e)
        {

            FormManager.switchForm(this, new FormTaoDDH());
        }


        private void FormDatHang_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet1.sp_BaoCaoDonDatHangChuaNhap' table. You can move, or remove it, as needed.
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Fill(this.qlvtDataSet1.sp_BaoCaoDonDatHangChuaNhap);
            // TODO: This line of code loads data into the 'qlvtDataSet1.sp_BaoCaoDonDatHangChuaNhap' table. You can move, or remove it, as needed.
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Fill(this.qlvtDataSet1.sp_BaoCaoDonDatHangChuaNhap);
            // TODO: This line of code loads data into the 'qlvtDataSet1.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qlvtDataSet1.CTDDH);

        }

        private void editDDH_Click(object sender, EventArgs e)
        {
            //lấy ma ddh hien tai
            Console.WriteLine("Chỉnh sửa đơn đặt hàng "+ this.cTDDHDataGridView.CurrentRow.Index);
        }

        private string EscapeLikeValue(string value)
        {
            return value
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");
        }
        //   private void searchInput_EditValueChanged(object sender, EventArgs e)
        //   {
        //       string searchText = EscapeLikeValue(searchInput.Text.Trim());

        //       if (!string.IsNullOrEmpty(searchText))
        //       {
        //           datHangBindingSource.Filter =
        //$"CONVERT(MANV, 'System.String') LIKE '%{searchText}%' " +
        //$"OR NhaCC LIKE '%{searchText}%' " +
        //$"OR MasoDDH LIKE '%{searchText}%'";


        //       }
        //       else
        //       {
        //           datHangBindingSource.RemoveFilter();
        //       }

        //       labelNoResult.Visible = datHangBindingSource.Count == 0;
        //   }

        //   private void checkChuaNhap_CheckedChanged(object sender, EventArgs e)
        //   {

        //   }

        //   private void checkDaNhap_CheckedChanged(object sender, EventArgs e)
        //   {

        //   }

        private void ApplyFilter()
        {
            string searchText = EscapeLikeValue(searchInput.Text.Trim());
            List<string> conditions = new List<string>();

            // 1. Điều kiện tìm kiếm (luôn áp dụng)
            if (!string.IsNullOrEmpty(searchText))
            {
                conditions.Add($"CONVERT(MANV, 'System.String') LIKE '%{searchText}%'");
                conditions.Add($"NhaCC LIKE '%{searchText}%'");
                conditions.Add($"MasoDDH LIKE '%{searchText}%'");
            }

            string searchFilter = conditions.Count > 0 ? "(" + string.Join(" OR ", conditions) + ")" : null;

            // 2. Điều kiện trạng thái (chỉ khi có check)
            string statusFilter = null;
            if (checkChuaNhap.Checked && !checkDaNhap.Checked)
            {
                statusFilter = "status = 'Chưa nhập'";
            }
            else if (!checkChuaNhap.Checked && checkDaNhap.Checked)
            {
                statusFilter = "status = 'Đã nhập'";
            }
            // Nếu cả hai đều check hoặc đều không check thì không thêm điều kiện trạng thái

            // 3. Gộp điều kiện
            List<string> finalConditions = new List<string>();
            if (!string.IsNullOrEmpty(searchFilter)) finalConditions.Add(searchFilter);
            if (!string.IsNullOrEmpty(statusFilter)) finalConditions.Add(statusFilter);

            datHangBindingSource.Filter = finalConditions.Count > 0 ? string.Join(" AND ", finalConditions) : null;

            labelNoResult.Visible = datHangBindingSource.Count == 0;
        }


        private void searchInput_EditValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void checkChuaNhap_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void checkDaNhap_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }


    }
}
