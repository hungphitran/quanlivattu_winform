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
            if (Program.mGroup == "AdminRole")
            {
                this.vw_NhanVienCoTaiKhoanTableAdapter.Fill(this.qlvtDataSet.vw_NhanVienCoTaiKhoan);
                this.cmbNhanVien.Format += new ListControlConvertEventHandler(cmbNhanVien_Format);
            }
            else
            {
                Console.WriteLine($"Current MANV: {Program.manv}");

                this.vw_NhanVienCoTaiKhoanTableAdapter.Fill(this.qlvtDataSet.vw_NhanVienCoTaiKhoan);
                this.vw_NhanVienCoTaiKhoanBindingSource.Filter = $"MANV = {Program.manv}";
                this.cmbNhanVien.DataSource = this.vw_NhanVienCoTaiKhoanBindingSource;
                this.cmbNhanVien.Format += new ListControlConvertEventHandler(cmbNhanVien_Format);
                this.cmbNhanVien.ValueMember = "MANV";

                if (vw_NhanVienCoTaiKhoanBindingSource.Count > 0)
                {
                    this.cmbNhanVien.SelectedIndex = 0; // Select the first (and only) item
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên hiện tại trong danh sách.");
                }

                this.cmbNhanVien.Enabled = false; // Disable the combo box
            }


            this.textPass1.Properties.UseSystemPasswordChar = true;
            this.textPass2.Properties.UseSystemPasswordChar = true;

        }
        public static string GetLoginByUser(string userId)
        {
            try
            {
                String login = "";
                // Query to get the login name for the given user ID
                string query = $@"use qlvt;
                SELECT dp.name AS [UserName], sp.name AS [LoginName]
                FROM sys.database_principals dp
                JOIN sys.server_principals sp ON dp.sid = sp.sid
                WHERE dp.type_desc = 'SQL_USER'
                AND dp.name LIKE '%[_]{userId}[_]%';";

                // Execute the query
                SqlDataReader reader = Program.ExecSqlDataReader(query);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Return the login name
                         login=reader["LoginName"].ToString();
                    }
                }
                else
                {
                    Console.WriteLine("No login found for the given user.");
                }

                reader.Close();
                return login; // Return the login name
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching login for user {userId}: {ex.Message}");
            }

            return null; // Return null if no login is found
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
            String login = GetLoginByUser(manv); // Get the login name for the selected user
            if (pass.Length == 0 || pass2.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật kháu.");
                return;
            }
            if (login == null|| login.Length==0)
            {
                MessageBox.Show("Không tìm thấy login cho nhân viên này.");
                return;
            }

            if (pass != pass2)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }

            String cmd =
                $"use master; exec sp_DoiMatKhau @login = '{login}',@MatKhauMoi = '{pass}'";
            Console.WriteLine(cmd);
            int res = Program.ExecSqlNonQuery(cmd);
            if (res == 0)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công cho user "+manv+" với login "+login);

                if (manv == Program.manv)
                {
                    Console.WriteLine($"Current MANV: {Program.manv}");
                    Program.conn.Close();
                    Program.password = pass;

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
                String cmd = $"use master; exec sp_XoaLoginVaUser '_{manv}_'";
                Console.WriteLine(cmd);
                int res = Program.ExecSqlNonQuery(cmd);
                Console.WriteLine("res: " + res);// 
                if (res == 0)//thanh cong
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
