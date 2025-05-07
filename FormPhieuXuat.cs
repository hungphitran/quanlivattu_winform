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

    public partial class FormPhieuXuat : Form
    {
        public FormPhieuXuat()
        {
            InitializeComponent();
 
        }





        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuXuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlvtDataSet);

        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            // Load Vattu first
            this.vattuTableAdapter.Fill(this.qlvtDataSet.Vattu);

            // Then load other data
            this.nhanvienTableAdapter.Fill(this.qlvtDataSet.Nhanvien);
            this.phieuXuatTableAdapter.Fill(this.qlvtDataSet.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.qlvtDataSet.CTPX);
            this.ngayInput.Value = DateTime.Now;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void btnAddCtpx_Click(object sender, EventArgs e)
        {

        }

        //private void reloadBtn_Click(object sender, EventArgs e)
        //{
        //    Console.WriteLine("reload");
        //    this.phieuXuatTableAdapter.Fill(this.qlvtDataSet.PhieuXuat);
        //    phieuXuatBindingSource.RemoveFilter();
        //    this.cTPXTableAdapter.Fill(this.qlvtDataSet.CTPX);
        //    cTPXBindingSource.RemoveFilter();
        //}
        private bool ValidatePhieuXuatInputs(string mapx, string hotenKH, int? manv, DateTime ngay)
        {
            // Validate MAPX (Primary Key, nChar(8))
            if (string.IsNullOrWhiteSpace(mapx))
            {
                MessageBox.Show("Mã phiếu xuất không được để trống!");
                return false;
            }
            if (mapx.Length > 8)
            {
                MessageBox.Show("Mã phiếu xuất không được vượt quá 8 ký tự!");
                return false;
            }

            // Validate HOTENKH (nvarchar(100))
            if (string.IsNullOrWhiteSpace(hotenKH))
            {
                MessageBox.Show("Họ tên khách hàng không được để trống!");
                return false;
            }
            if (hotenKH.Length > 100)
            {
                MessageBox.Show("Họ tên khách hàng không được vượt quá 100 ký tự!");
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

        private bool ValidateCTPXInputs(string mapx, string mavt, int soluong, float dongia)
        {
            // Validate MAPX (Foreign Key, nChar(8))
            if (string.IsNullOrWhiteSpace(mapx))
            {
                MessageBox.Show("Mã phiếu xuất không được để trống!");
                return false;
            }
            if (mapx.Length > 8)
            {
                MessageBox.Show("Mã phiếu xuất không được vượt quá 8 ký tự!");
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

        private void addPhieuXuatBtn_Click(object sender, EventArgs e)
        {
            string mapx = mapxInput.Text.Trim();
            string ngay = ngayInput.Value.ToString("yyyy-MM-dd");
            string hotenkh = hotenkhInput.Text.Trim();
            string manv = manvInput.Text.Trim();

            if (Program.connectDB() == 0)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                return;
            }

            DataTable ctpxTable = new DataTable();
            ctpxTable.Columns.Add("MAVT", typeof(string));
            ctpxTable.Columns.Add("SOLUONG", typeof(int));
            ctpxTable.Columns.Add("DONGIA", typeof(double));

            foreach (DataGridViewRow row in tempDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string mavt = row.Cells["MAVT"].Value.ToString();
                    int soluong = int.Parse(row.Cells["SOLUONG"].Value.ToString());
                    double dongia = double.Parse(row.Cells["DONGIA"].Value.ToString());

                    ctpxTable.Rows.Add(mavt, soluong, dongia);
                }
            }


            if (ctpxTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một vật tư vào phiếu xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("phieu_xuat_hang", Program.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MAPX", mapx);
                    cmd.Parameters.AddWithValue("@NGAY", ngay);
                    cmd.Parameters.AddWithValue("@HOTENKH", hotenkh);
                    cmd.Parameters.AddWithValue("@MANV", manv);

                    SqlParameter ctpxParam = cmd.Parameters.AddWithValue("@CTPX", ctpxTable);
                    ctpxParam.SqlDbType = SqlDbType.Structured;
                    ctpxParam.TypeName = "dbo.Type_CTPX";

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm phiếu xuất thành công!");
                mapxInput.Text = "";
                hotenkhInput.Text = "";
                manvInput.Text = "";
                tempDataGridView.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu xuất: " + ex.Message);
            }
        }


        private void addvattuBtn_Click(object sender, EventArgs e)
        {
            string tenVT = vattuComboBox.Text;
            string soLuongText = soluongInput.Text;
            string donGiaText = dongiaInput.Text;
            string mavt = mAVTTextBox.Text.Trim();

            if (string.IsNullOrEmpty(tenVT) || string.IsNullOrEmpty(soLuongText) || string.IsNullOrEmpty(donGiaText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(soLuongText, out int soLuong))
            {
                MessageBox.Show("Số lượng phải là số nguyên!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(donGiaText, out float donGia))
            {
                MessageBox.Show("Đơn giá phải là số thực!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float thanhTien = soLuong * donGia;


            tempDataGridView.Rows.Add(mavt, tenVT, soLuong, donGia, thanhTien);

            UpdateTotalAmount();

            soluongInput.Text = "";
            dongiaInput.Text = "";
            vattuComboBox.SelectedIndex = -1;
            mAVTTextBox.Text = "";
        }


        private void UpdateTotalAmount()
        {
            float totalAmount = 0;

            foreach (DataGridViewRow row in tempDataGridView.Rows)
            {
                if (row.Cells[4].Value != null) 
                {
                    totalAmount += Convert.ToSingle(row.Cells[4].Value);
                }
            }

            totalAmoutBox.Text = totalAmount.ToString("N0"); 
        }

        private void deleteVTbtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (tempDataGridView.SelectedRows.Count > 0)
            {
                // Xóa dòng đầu tiên trong danh sách các dòng được chọn
                tempDataGridView.Rows.RemoveAt(tempDataGridView.SelectedRows[0].Index);

                // Cập nhật lại tổng thành tiền sau khi xóa
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vật tư cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tempDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng sửa ở cột số lượng (2) hoặc đơn giá (3)
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                DataGridViewRow row = tempDataGridView.Rows[e.RowIndex];

                // Lấy giá trị số lượng và đơn giá từ dòng đang chỉnh sửa
                if (float.TryParse(row.Cells[2].Value?.ToString(), out float soLuong) &&
                    float.TryParse(row.Cells[3].Value?.ToString(), out float donGia))
                {
                    // Tính lại thành tiền
                    float thanhTien = soLuong * donGia;
                    row.Cells[4].Value = thanhTien;

                    // Cập nhật lại tổng thành tiền
                    UpdateTotalAmount();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng số lượng và đơn giá là số hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng xác nhận xóa hết
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tất cả vật tư đã thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa hết các dòng trong DataGridView
                tempDataGridView.Rows.Clear();

                // Cập nhật lại tổng tiền về 0
                UpdateTotalAmount();
            }
        }
    }
}