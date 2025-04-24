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
            string ngay = ngayInput.Value.ToString("yyyy-MM-dd");
            string masoDDH = masoDDHTextEdit.Text.Trim();
            int manv = int.Parse(manvInput.Text.Trim());

            // Ensure the connection to the database is established
            if (Program.connectDB() == 0)
            {
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
                return;
            }

            try
            {
 
                SqlCommand cmd = new SqlCommand("phieu_nhap_hang", Program.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MasoDDH", masoDDH);
                cmd.Parameters.AddWithValue("@NGAY", ngay);
                cmd.Parameters.AddWithValue("@MANV", manv);

   
                cmd.ExecuteNonQuery();

                MessageBox.Show("Phiếu nhập đã được tạo thành công!");

                this.phieuNhapTableAdapter.Fill(this.qlvtDataSet.PhieuNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập phiếu: " + ex.Message);
            }
            finally
            {
                // Close the connection if it's open
                if (Program.conn.State == ConnectionState.Open)
                    Program.conn.Close();
            }
        }

    }
}
