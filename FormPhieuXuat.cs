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
            this.nvInput.Text = Program.mHoten;
            this.mapxInput.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToUppercase_NoSpace;
            this.soluongInput.KeyPress += KeyPressConstraint.KeyPress_OnlyDigits;
            this.dongiaInput.KeyPress += KeyPressConstraint.KeyPress_OnlyDigits;
            this.mapxInput.Properties.MaxLength = 8;
            this.soluongInput.Properties.MaxLength = 10;
            this.dongiaInput.Properties.MaxLength = 10;

            // Chỉ cho nhập chữ, không cho số, không cho 2 dấu cách liên tiếp, sau dấu cách tự động viết hoa cho hotenkhInput
            this.hotenkhInput.KeyPress += hotenkhInput_KeyPress;
            this.hotenkhInput.TextChanged += hotenkhInput_TextChanged;

            // Định dạng hiển thị cho cột Đơn Giá và Thành Tiền
            if (tempDataGridView.Columns["DONGIA"] != null)
            {
                tempDataGridView.Columns["DONGIA"].DefaultCellStyle.Format = "#,0 đ";
                tempDataGridView.Columns["DONGIA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (tempDataGridView.Columns["THANHTIEN"] != null)
            {
                tempDataGridView.Columns["THANHTIEN"].DefaultCellStyle.Format = "#,0 đ";
                tempDataGridView.Columns["THANHTIEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void hotenkhInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập chữ cái, dấu cách, và phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
            // Không cho nhập 2 dấu cách liên tiếp
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string text = textBox.Text;
            if (e.KeyChar == ' ')
            {
                if (text.Length == 0 || text.EndsWith(" "))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void hotenkhInput_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string text = textBox.Text;
            if (string.IsNullOrEmpty(text)) return;
            // Không cho 2 dấu cách liên tiếp
            while (text.Contains("  "))
                text = text.Replace("  ", " ");
            // Viết hoa chữ cái đầu tiên và sau mỗi dấu cách, còn lại chuyển về thường
            var sb = new StringBuilder();
            bool capitalize = true;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c))
                {
                    if (capitalize)
                    {
                        sb.Append(char.ToUpper(c));
                        capitalize = false;
                    }
                    else
                    {
                        sb.Append(char.ToLower(c));
                    }
                }
                else
                {
                    sb.Append(c);
                    if (c == ' ')
                        capitalize = true;
                }
            }
            string newText = sb.ToString();
            if (textBox.Text != newText)
            {
                int selStart = textBox.SelectionStart;
                int diff = textBox.Text.Length - newText.Length;
                textBox.Text = newText;
                textBox.SelectionStart = Math.Max(0, selStart - diff);
            }
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuXuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlvtDataSet);
            
            // Cập nhật tên nhân viên sau khi lưu
            UpdateTenNhanVien();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            // Load Vattu first
            this.vattuTableAdapter.Fill(this.qlvtDataSet.Vattu);

            // Then load other data
            this.nhanvienTableAdapter.Fill(this.qlvtDataSet.Nhanvien);
            this.phieuXuatTableAdapter.Fill(this.qlvtDataSet.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.qlvtDataSet.CTPX);

            // Thêm cột tên vật tư vào bảng CTPX
            if (!qlvtDataSet.CTPX.Columns.Contains("TenVatTu"))
            {
                qlvtDataSet.CTPX.Columns.Add("TenVatTu", typeof(string));
            }

            // Thêm cột tên vật tư vào DataGridView CTPX
            var tenVatTuCol = new DataGridViewTextBoxColumn();
            tenVatTuCol.DataPropertyName = "TenVatTu";
            tenVatTuCol.HeaderText = "Tên Vật Tư";
            tenVatTuCol.MinimumWidth = 6;
            tenVatTuCol.Name = "tenVatTuColumn";
            tenVatTuCol.ReadOnly = true;
            tenVatTuCol.Width = 200;
            cTPXDataGridView.Columns.Add(tenVatTuCol);

            // Cập nhật tên vật tư cho bảng CTPX
            foreach (DataRow row in qlvtDataSet.CTPX.Rows)
            {
                string mavt = row["MAVT"].ToString();
                row["TenVatTu"] = GetTenVatTu(mavt);
            }

            // Ẩn cột MAVT trong CTPX và hiển thị cột tên vật tư
            MAVT.Visible = false;

            // Thêm cột tên nhân viên vào bảng PhieuXuat
            if (!qlvtDataSet.PhieuXuat.Columns.Contains("TenNhanVien"))
            {
                qlvtDataSet.PhieuXuat.Columns.Add("TenNhanVien", typeof(string));
            }

            // Thêm cột tên nhân viên vào DataGridView PhieuXuat
            var tenNhanVienCol = new DataGridViewTextBoxColumn();
            tenNhanVienCol.DataPropertyName = "TenNhanVien";
            tenNhanVienCol.HeaderText = "Tên Nhân Viên";
            tenNhanVienCol.MinimumWidth = 6;
            tenNhanVienCol.Name = "tenNhanVienColumn";
            tenNhanVienCol.ReadOnly = true;
            tenNhanVienCol.Width = 150;
            phieuXuatDataGridView1.Columns.Add(tenNhanVienCol);

            // Cập nhật tên nhân viên cho bảng PhieuXuat
            UpdateTenNhanVien();

            // Ẩn cột MANV trong PhieuXuat và hiển thị cột tên nhân viên
            dataGridViewTextBoxColumn4.Visible = false;

            this.ngayInput.Value = DateTime.Now;
        }

        // Phương thức helper để lấy tên vật tư từ MAVT
        private string GetTenVatTu(string mavt)
        {
            var vatTuRow = qlvtDataSet.Vattu.FindByMAVT(mavt);
            if (vatTuRow != null)
            {
                return vatTuRow.TENVT ?? "Không có tên";
            }
            return "Không tìm thấy";
        }

        // Phương thức helper để lấy tên nhân viên từ MANV
        private string GetTenNhanVien(int manv)
        {
            var nhanVienRow = qlvtDataSet.Nhanvien.FindByMANV(manv);
            if (nhanVienRow != null)
            {
                string ho = nhanVienRow.HO ?? "";
                string ten = nhanVienRow.TEN ?? "";
                return $"{ho} {ten}".Trim();
            }
            return "Không tìm thấy";
        }

        // Phương thức cập nhật tên nhân viên cho tất cả các phiếu xuất
        private void UpdateTenNhanVien()
        {
            foreach (DataRow row in qlvtDataSet.PhieuXuat.Rows)
            {
                int manv = Convert.ToInt32(row["MANV"]);
                row["TenNhanVien"] = GetTenNhanVien(manv);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void btnAddCtpx_Click(object sender, EventArgs e)
        {

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("reload");
            this.phieuXuatTableAdapter.Fill(this.qlvtDataSet.PhieuXuat);
            phieuXuatBindingSource.RemoveFilter();
            this.cTPXTableAdapter.Fill(this.qlvtDataSet.CTPX);
            cTPXBindingSource.RemoveFilter();
            
            // Cập nhật tên nhân viên sau khi reload
            UpdateTenNhanVien();
            
            // Cập nhật tên vật tư cho CTPX
            foreach (DataRow row in qlvtDataSet.CTPX.Rows)
            {
                string mavt = row["MAVT"].ToString();
                row["TenVatTu"] = GetTenVatTu(mavt);
            }
        }
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
            string manv = Program.manv.ToString();

            // Validate inputs before proceeding
            if (string.IsNullOrWhiteSpace(mapx) || string.IsNullOrWhiteSpace(hotenkh) ||
                string.IsNullOrWhiteSpace(manv))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phiếu xuất.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                if (!row.IsNewRow && row.Cells["MAVT"].Value != null)
                {
                    string mavt = row.Cells["MAVT"].Value.ToString();
                    int soluong = Convert.ToInt32(row.Cells["SOLUONG"].Value);
                    double dongia = Convert.ToDouble(row.Cells["DONGIA"].Value);
                    Console.WriteLine("mavt: " + mavt + ", soluong: " + soluong + ", dongia: " + dongia);
                    ctpxTable.Rows.Add(mavt, soluong, dongia);
                }
            }

            if (ctpxTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một vật tư vào phiếu xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    Console.WriteLine("command: " + cmd.CommandText);

                    SqlParameter ctpxParam = cmd.Parameters.AddWithValue("@CTPX", ctpxTable);
                    ctpxParam.SqlDbType = SqlDbType.Structured;
                    ctpxParam.TypeName = "dbo.Type_CTPX";
                    Program.conn.InfoMessage += (s, ev) =>
                    {
                        foreach (SqlError err in ev.Errors)
                        {
                            Console.WriteLine("SQL Message: " + err.Message);
                        }
                    };

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("rowsAffected: " + rowsAffected);

                    MessageBox.Show("Thêm phiếu xuất thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Program.ExecSqlNonQuery("exec sp_TaoBackupLog 'qlvt' ;");

                    // Clear form fields
                    mapxInput.Text = "";
                    hotenkhInput.Text = "";
                    nvInput.Text = Program.mHoten;  // Reset to current user
                    tempDataGridView.Rows.Clear();

                    // Reset comboboxes and total amount
                    UpdateTotalAmount();
                    updateComboBox();

                    // Refresh the datasets to show the newly added record
                    this.phieuXuatTableAdapter.Fill(this.qlvtDataSet.PhieuXuat);
                    this.cTPXTableAdapter.Fill(this.qlvtDataSet.CTPX);
                    
                    // Cập nhật tên nhân viên sau khi refresh
                    UpdateTenNhanVien();
                    
                    // Cập nhật tên vật tư cho CTPX
                    foreach (DataRow row in qlvtDataSet.CTPX.Rows)
                    {
                        string mavt = row["MAVT"].ToString();
                        row["TenVatTu"] = GetTenVatTu(mavt);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL khi thêm phiếu xuất: " + sqlEx.Message +
                    "\nError Code: " + sqlEx.Number, "Lỗi Database",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu xuất: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateComboBox()
        {
            // Check if there are any rows to filter
            if (tempDataGridView.Rows.Count == 0 ||
                tempDataGridView.Rows[0].Cells["MAVT"].Value == null)
            {
                vattuBindingSource2.RemoveFilter();
                return;
            }

            // Build a list of MAVT values
            List<string> mavtValues = new List<string>();
            foreach (DataGridViewRow row in tempDataGridView.Rows)
            {
                if (row.Cells["MAVT"].Value != null)
                {
                    mavtValues.Add(row.Cells["MAVT"].Value.ToString());
                }
            }

            // Create a properly formatted filter string
            if (mavtValues.Count > 0)
            {
                string filter = "MAVT NOT IN (";
                foreach (string mavt in mavtValues)
                {
                    filter += "'" + mavt + "',";
                }
                // Remove the last comma and close the parenthesis
                filter = filter.TrimEnd(',') + ")";
                vattuBindingSource2.Filter = filter;
                if(vattuBindingSource2.Count == 0)
                {
                    this.addvattuBtn.Enabled = false;
                    vattuComboBox.SelectedIndex = -1; // No selection
                }
                else
                {
                    this.addvattuBtn.Enabled = true;
                    vattuComboBox.SelectedIndex = 0;
                }
            }
            else
            {
                vattuBindingSource2.RemoveFilter();
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


            var vattu = qlvtDataSet.Vattu.FindByMAVT(mavt);

            if (vattu == null)
            {
                MessageBox.Show("Không tìm thấy vật tư!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(vattu.Soluongton < soLuong)
            {
                MessageBox.Show("Vật tư không đúng số lượng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if(soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            float thanhTien = soLuong * donGia;


            tempDataGridView.Rows.Add(mavt, tenVT, soLuong, donGia, thanhTien);

            UpdateTotalAmount();
            updateComboBox();
            soluongInput.Text = "1";
            dongiaInput.Text = "1";

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
                updateComboBox();

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
                    updateComboBox();
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
                // Cập nhật lại ComboBox vật tư
                vattuBindingSource2.RemoveFilter();
            }
        }

        private void searchInput_EditValueChanged(object sender, EventArgs e)
        {
            string searchText = searchInput.Text.Trim().Replace("'", "''"); // tránh lỗi khi nhập dấu nháy đơn  

            if (string.IsNullOrEmpty(searchText))
            {
                phieuXuatBindingSource.RemoveFilter();
                return;
            }

            // Lọc theo MAPX, HOTENKH và MANV (MANV cần convert sang chuỗi)  
            string filter = $"MAPX LIKE '%{searchText}%' OR HOTENKH LIKE '%{searchText}%' OR CONVERT(MANV, 'System.String') LIKE '%{searchText}%'";
            phieuXuatBindingSource.Filter = filter;

            // Nếu không tìm thấy kết quả theo filter thông thường, tìm kiếm theo tên nhân viên  
            if (phieuXuatBindingSource.Count == 0)
            {
                // Tìm kiếm theo tên nhân viên  
                var matchingRows = qlvtDataSet.PhieuXuat.AsEnumerable()
                    .Where(row => GetTenNhanVien(Convert.ToInt32(row["MANV"]))
                        .IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                if (matchingRows.Count > 0)
                {
                    // Tạo filter mới dựa trên MAPX của các dòng tìm được  
                    var mapxList = matchingRows.Select(row => $"'{row["MAPX"]}'").ToArray();
                    string mapxFilter = string.Join(",", mapxList);
                    phieuXuatBindingSource.Filter = $"MAPX IN ({mapxFilter})";
                }
            }

            labelNoResult.Visible = phieuXuatBindingSource.Count == 0;
        }

    }
}