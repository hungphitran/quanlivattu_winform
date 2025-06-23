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
using System.Windows.Forms.VisualStyles;
using DevExpress.Office.Crypto;
using QLVT;

namespace quanlyvattu
{
    public partial class FormTaoAcc : Form
    {
        public FormTaoAcc()
        {
            InitializeComponent();
            this.txtUsername.Properties.MaxLength = 20;
            this.txtUsername.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToLowercase_NoSpace;
            this.txtPass.Properties.MaxLength = 20;
            this.txtPass.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToLowercase_NoSpace;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.adminBtn.Checked = true; // Default to not admin
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string pass = this.txtPass.Text;
            bool isAdmin = this.adminBtn.Checked;
            String manv = cmbNhanVien.SelectedValue.ToString(); // Get selected employee ID

            Console.WriteLine(cmbNhanVien.SelectedValue);
            String cmd="";
            // Your existing code for creating the account
            if (isAdmin)
            {
                cmd = $"use master; exec sp_TaoLogin @loginName = '{username}',@password = '{pass}',@manv = '{manv}', @isAdmin=1";
            }
            else
            {
                cmd = $"use master; exec sp_TaoLogin @loginName = '{username}',@password = '{pass}',@manv = '{manv}', @isAdmin=0";

            }
            int res = Program.ExecSqlNonQuery(cmd);
            if (res==0)
            {
                MessageBox.Show("Tạo tài khoản thành công");
                this.cmbNhanVien.DataSource = null; // Clear the data source
                this.vw_NhanVienChuaCoTaiKhoanTableAdapter.Fill(this.qlvtDataSet.vw_NhanVienChuaCoTaiKhoan); // Reload the data
                this.cmbNhanVien.DataSource = vw_NhanVienChuaCoTaiKhoanBindingSource; // Reassign the data source
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void FormTaoAcc_Load(object sender, EventArgs e)
        {
            // The existing line that loads data into the vw_NhanVienChuaCoTaiKhoan table
            this.vw_NhanVienChuaCoTaiKhoanTableAdapter.Connection = Program.conn;
            this.vw_NhanVienChuaCoTaiKhoanTableAdapter.Fill(this.qlvtDataSet.vw_NhanVienChuaCoTaiKhoan);

            // First option: Format the display by handling the Format event
            cmbNhanVien.DataSource = vw_NhanVienChuaCoTaiKhoanBindingSource;
            cmbNhanVien.DisplayMember = "TEN"; // This will be overridden by the Format event handler
            cmbNhanVien.ValueMember = "MANV";  // Changed from CMND to MANV as it's likely the primary key

            // Add a Format event handler to customize the display
            cmbNhanVien.Format += new ListControlConvertEventHandler(cmbNhanVien_Format);
            this.txtUsername.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToLowercase_NoSpace;
            this.txtPass.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToLowercase_NoSpace;
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



        private void groupBoxAccountInfo_Enter(object sender, EventArgs e)
        {

        }

        

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Properties.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}
