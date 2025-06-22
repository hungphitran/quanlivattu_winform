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

                // Load dữ liệu từ bảng Nhanvien
                this.nhanvienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanvienTableAdapter.Fill(this.qlvtDataSet1.Nhanvien);

                // Load dữ liệu từ bảng Vattu
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.qlvtDataSet1.Vattu);

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

            // Thêm cột tên nhân viên
            if (!qlvtDataSet1.DatHang.Columns.Contains("TenNhanVien"))
            {
                qlvtDataSet1.DatHang.Columns.Add("TenNhanVien", typeof(string));
            }

            // Thêm cột tên vật tư vào bảng CTDDH
            if (!qlvtDataSet1.CTDDH.Columns.Contains("TenVatTu"))
            {
                qlvtDataSet1.CTDDH.Columns.Add("TenVatTu", typeof(string));
            }

            // 2. Set the DataPropertyName of the DataGridView column (in Designer or code)
            var newCol = new DataGridViewTextBoxColumn();
            newCol.DataPropertyName = "status";
            newCol.HeaderText = "Trạng thái";
            datHangDataGridView.Columns.Add(newCol);

            // Thêm cột tên nhân viên vào DataGridView
            var tenNhanVienCol = new DataGridViewTextBoxColumn();
            tenNhanVienCol.DataPropertyName = "TenNhanVien";
            tenNhanVienCol.HeaderText = "Tên Nhân Viên";
            tenNhanVienCol.MinimumWidth = 6;
            tenNhanVienCol.Name = "tenNhanVienColumn";
            tenNhanVienCol.ReadOnly = true;
            tenNhanVienCol.Width = 200;
            datHangDataGridView.Columns.Add(tenNhanVienCol);

            // Thêm cột tên vật tư vào DataGridView CTDDH
            var tenVatTuCol = new DataGridViewTextBoxColumn();
            tenVatTuCol.DataPropertyName = "TenVatTu";
            tenVatTuCol.HeaderText = "Tên Vật Tư";
            tenVatTuCol.MinimumWidth = 6;
            tenVatTuCol.Name = "tenVatTuColumn";
            tenVatTuCol.ReadOnly = true;
            tenVatTuCol.Width = 200;
            cTDDHDataGridView.Columns.Add(tenVatTuCol);

            // 3. Set the value via the BindingSource
            foreach (DataRow row in qlvtDataSet1.DatHang.Rows)
            {
                if(sp_BaoCaoDonDatHangChuaNhapBindingSource.Find("MasoDDH", row["MasoDDH"]) != -1)
                {
                    row["status"] = "Chưa nhập";
                }
                else row["status"] = "Đã nhập";

                // Lấy tên nhân viên từ bảng Nhanvien
                int manv = Convert.ToInt32(row["MANV"]);
                row["TenNhanVien"] = GetTenNhanVien(manv);
            }

            // Cập nhật tên vật tư cho bảng CTDDH
            foreach (DataRow row in qlvtDataSet1.CTDDH.Rows)
            {
                string mavt = row["MAVT"].ToString();
                row["TenVatTu"] = GetTenVatTu(mavt);
            }

            // Ẩn cột MANV và hiển thị cột tên nhân viên
            dataGridViewTextBoxColumn5.Visible = false;

            // Ẩn cột MAVT trong CTDDH và hiển thị cột tên vật tư
            dataGridViewTextBoxColumn7.Visible = false;
        }

        // Phương thức helper để lấy tên nhân viên từ MANV
        private string GetTenNhanVien(int manv)
        {
            var nhanVienRow = qlvtDataSet1.Nhanvien.FindByMANV(manv);
            if (nhanVienRow != null)
            {
                string ho = nhanVienRow.HO ?? "";
                string ten = nhanVienRow.TEN ?? "";
                return $"{ho} {ten}".Trim();
            }
            return "Không tìm thấy";
        }

        // Phương thức helper để lấy tên vật tư từ MAVT
        private string GetTenVatTu(string mavt)
        {
            var vatTuRow = qlvtDataSet1.Vattu.FindByMAVT(mavt);
            if (vatTuRow != null)
            {
                return vatTuRow.TENVT ?? "Không có tên";
            }
            return "Không tìm thấy";
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
            // Tìm cột trạng thái bằng tên
            int statusColumnIndex = -1;
            for (int i = 0; i < datHangDataGridView.Columns.Count; i++)
            {
                if (datHangDataGridView.Columns[i].DataPropertyName == "status")
                {
                    statusColumnIndex = i;
                    break;
                }
            }

            if (statusColumnIndex != -1 && this.datHangDataGridView.CurrentRow.Cells[statusColumnIndex].Value.ToString() == "Đã nhập")
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

            // Cập nhật lại tên nhân viên khi form được load lại
            if (qlvtDataSet1.DatHang.Columns.Contains("TenNhanVien"))
            {
                foreach (DataRow row in qlvtDataSet1.DatHang.Rows)
                {
                    int manv = Convert.ToInt32(row["MANV"]);
                    row["TenNhanVien"] = GetTenNhanVien(manv);
                }
            }

            // Cập nhật lại tên vật tư khi form được load lại
            if (qlvtDataSet1.CTDDH.Columns.Contains("TenVatTu"))
            {
                foreach (DataRow row in qlvtDataSet1.CTDDH.Rows)
                {
                    string mavt = row["MAVT"].ToString();
                    row["TenVatTu"] = GetTenVatTu(mavt);
                }
            }
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
