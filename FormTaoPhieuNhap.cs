using DevExpress.XtraCharts.Native;
using QLVT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyvattu
{
    public partial class FormTaoPhieuNhap : Form
    {
        public FormTaoPhieuNhap()
        {
            InitializeComponent();
        }

        private bool ValidatePhieuNhapInputs(string mapn, string masoDDH, int? manv, DateTime ngay)
        {
            // Validate MAPN (Primary Key, nChar(8))
            if (string.IsNullOrWhiteSpace(mapn))
            {
                MessageBox.Show("Mã phiếu nhập không được để trống!");
                return false;
            }
            if (mapn.Length > 8)
            {
                MessageBox.Show("Mã phiếu nhập không được vượt quá 8 ký tự!");
                return false;
            }

            // Validate MasoDDH (Foreign Key, Unique, nvarchar(8))
            if (string.IsNullOrWhiteSpace(masoDDH))
            {
                MessageBox.Show("Mã số đơn đặt hàng không được để trống!");
                return false;
            }
            if (masoDDH.Length > 8)
            {
                MessageBox.Show("Mã số đơn đặt hàng không được vượt quá 8 ký tự!");
                return false;
            }

            // Validate MANV (Foreign Key, int)
            if (!manv.HasValue || manv <= 0)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!");
                return false;
            }

            // Validate NGAY (Date)
            if (ngay > DateTime.Now)
            {
                MessageBox.Show("Ngày không thể là ngày trong tương lai!");
                return false;
            }

            return true;
        }

        private bool ValidateCTPNInputs(string mapn, string mavt, int soluong, float dongia)
        {
            // Validate MAPN (Foreign Key, nChar(8))
            if (string.IsNullOrWhiteSpace(mapn))
            {
                MessageBox.Show("Mã phiếu nhập không được để trống!");
                return false;
            }
            if (mapn.Length > 8)
            {
                MessageBox.Show("Mã phiếu nhập không được vượt quá 8 ký tự!");
                return false;
            }

            // Validate MAVT (Foreign Key, nChar(4))
            if (string.IsNullOrWhiteSpace(mavt))
            {
                MessageBox.Show("Mã vật tư không được để trống!");
                return false;
            }
            if (mavt.Length > 4)
            {
                MessageBox.Show("Mã vật tư không được vượt quá 4 ký tự!");
                return false;
            }

            // Validate SOLUONG (int, > 0)
            if (soluong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                return false;
            }

            // Validate DONGIA (float, >= 0)
            if (dongia < 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn hoặc bằng 0!");
                return false;
            }

            return true;
        }

        private void NhapVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qlvtDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qlvtDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qlvtDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'qlvtDataSet.sp_BaoCaoDonDatHangChuaNhap' table. You can move, or remove it, as needed.
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Fill(this.qlvtDataSet.sp_BaoCaoDonDatHangChuaNhap);
            
            this.ngayInput.Value = DateTime.Now;
            this.manvInput.Text = Program.manv;
            this.manvInput.Enabled = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void ngayInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string mapn = mapnInput.Text.Trim();
            string masoDDH = masoDDHTextEdit.Text.Trim();
            int? manv = int.TryParse(manvInput.Text.Trim(), out int parsedManv) ? parsedManv : (int?)null;
            DateTime ngay = ngayInput.Value;

            if (!ValidatePhieuNhapInputs(mapn, masoDDH, manv, ngay))
            {
                return; // Stop execution if validation fails
            }

            DataTable ctphieuNhapTable = new DataTable();
            ctphieuNhapTable.Columns.Add("MAVT", typeof(string));
            ctphieuNhapTable.Columns.Add("SOLUONG", typeof(int));
            ctphieuNhapTable.Columns.Add("DONGIA", typeof(float));

            foreach (DataGridViewRow row in ctphieuNhapTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    string mavt = row.Cells["MAVT"].Value.ToString();
                    int soluong = int.Parse(row.Cells["SOLUONG"].Value.ToString());
                    float dongia = float.Parse(row.Cells["DONGIA"].Value.ToString());

                    if (!ValidateCTPNInputs(mapn, mavt, soluong, dongia))
                    {
                        return; // Stop execution if validation fails
                    }

                    ctphieuNhapTable.Rows.Add(mavt, soluong, dongia);
                }
            }

            if (ctphieuNhapTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một vật tư vào phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("phieu_nhap_hang", Program.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAPN", mapn);
                    cmd.Parameters.AddWithValue("@NGAY", ngay.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MasoDDH", masoDDH);
                    cmd.Parameters.AddWithValue("@MANV", manv);

                    SqlParameter ctphieuNhapParam = cmd.Parameters.AddWithValue("@CTPN", ctphieuNhapTable);
                    ctphieuNhapParam.SqlDbType = SqlDbType.Structured;
                    ctphieuNhapParam.TypeName = "dbo.Type_CTPN";

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Phiếu nhập đã được tạo thành công!");
                mapnInput.Text = "";
                masoDDHTextEdit.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
            }
        }


    }
}
