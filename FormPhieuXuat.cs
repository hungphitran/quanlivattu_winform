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

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("reload");
            this.phieuXuatTableAdapter.Fill(this.qlvtDataSet.PhieuXuat);
            phieuXuatBindingSource.RemoveFilter();
            this.cTPXTableAdapter.Fill(this.qlvtDataSet.CTPX);
            cTPXBindingSource.RemoveFilter();
        }

        private void addPhieuXuatBtn_Click(object sender, EventArgs e)
        {
            string mapx = mapxInput.Text.Trim();
            string ngay = ngayInput.Value.ToString("yyyy-MM-dd");
            string hotenkh = makhInput.Text.Trim();
            string manv = nhanvienInput.Text.Trim();

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
                makhInput.Text = "";
                nhanvienInput.Text = "";
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


            tempDataGridView.Rows.Add(tenVT, soLuong, donGia, mavt);

         
            soluongInput.Text = "";
            dongiaInput.Text = "";
            vattuComboBox.SelectedIndex = -1;
            mAVTTextBox.Text = "";
        }



    }
}