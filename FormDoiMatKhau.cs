using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVT;

namespace quanlyvattu
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.vw_NhanVienCoTaiKhoan' table. You can move, or remove it, as needed.
            this.vw_NhanVienCoTaiKhoanTableAdapter.Fill(this.qlvtDataSet.vw_NhanVienCoTaiKhoan);
            this.cmbNhanVien.Format += new ListControlConvertEventHandler(cmbNhanVien_Format);

            this.textPass1.Properties.UseSystemPasswordChar = true;
            this.textPass2.Properties.UseSystemPasswordChar = true;

        }

        private void cmbNhanVien_Format(object sender, ListControlConvertEventArgs e)
        {
            // Get the DataRowView for the current item
            DataRowView rowView = e.ListItem as DataRowView;
            if (rowView != null)
            {
                // Combine HO and TEN fields with an optional ID
                string ho = rowView["HO"].ToString();
                string ten = rowView["TEN"].ToString();
                int manv = Convert.ToInt32(rowView["MANV"]);

                e.Value = $"{ho} {ten} - {manv} ";
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String pass = this.textPass1.Text;
            String pass2 = this.textPass2.Text;
            String manv = cmbNhanVien.SelectedValue.ToString(); // Get selected employee ID
            if (pass != pass2)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }

            String cmd =
                $"use master; exec sp_DoiMatKhau @login = '{Program.mlogin}',@MatKhauCu = '{Program.password}',@MatKhauMoi = '{pass}'";
            int res = Program.ExecSqlNonQuery(cmd);
            if (res == 0)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công");
                if (manv == Program.manv)
                {
                    Program.password = pass;
                    Program.conn.Close();
                    Program.connectDB();
                }
                textPass1.Text = "";
                textPass2.Text = "";
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("delete");
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                String manv = cmbNhanVien.SelectedValue.ToString(); // Get selected employee ID
                String cmd = $"exec sp_XoaLoginVaUser @Username = '{manv}'";
                int res = Program.ExecSqlNonQuery(cmd);
                if (res == 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    this.vw_NhanVienCoTaiKhoanTableAdapter.Fill(this.qlvtDataSet.vw_NhanVienCoTaiKhoan);
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }      

            }
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhanVien.SelectedItem == null)
            {
                return; // Exit the method if no item is selected
            }
            String manv = cmbNhanVien.SelectedValue.ToString(); // Get selected employee ID
            Console.WriteLine("ma nv" + manv);
            if (manv.Equals(Program.manv))
            {
                this.deleteBtn.Visible = false;
            }
            else
            {
                this.deleteBtn.Visible = true;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            this.textPass1.Properties.UseSystemPasswordChar = !this.checkEdit1.Checked;
        }
    }
}
