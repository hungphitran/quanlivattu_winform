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
using QLVT;

namespace quanlyvattu
{
    public partial class FormTaoAcc : Form
    {
        public FormTaoAcc()
        {
            InitializeComponent();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string pass = this.txtPass.Text;
            bool isAdmin = this.adminBtn.Checked;
            String cmnd = cmbNhanVien.SelectedValue.ToString(); // Get selected employee ID

            Console.WriteLine(cmbNhanVien.SelectedValue);
            String cmd="";
            // Your existing code for creating the account
            if (isAdmin)
            {
                cmd = $"EXEC sp_TaoLoginAdmin '{username}', '{pass}' , '{cmnd}' ";
            }
            else
            {
                cmd = $"EXEC sp_TaoLoginNhanVien '{username}', '{pass}' , '{cmnd}' ";

            }
            int res = Program.ExecSqlNonQuery(cmd);
            if (res==0)
            {
                MessageBox.Show("thành công");
            }
            else
            {
                MessageBox.Show("thất bại");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormNhanVien());
        }

        private void FormTaoAcc_Load(object sender, EventArgs e)
        {
            // The existing line that loads data into the vw_NhanVienChuaCoTaiKhoan table
            this.vw_NhanVienChuaCoTaiKhoanTableAdapter.Fill(this.qlvtDataSet.vw_NhanVienChuaCoTaiKhoan);

            // First option: Format the display by handling the Format event
            cmbNhanVien.DataSource = vw_NhanVienChuaCoTaiKhoanBindingSource;
            cmbNhanVien.DisplayMember = "TEN"; // This will be overridden by the Format event handler
            cmbNhanVien.ValueMember = "CMND";  // Changed from CMND to MANV as it's likely the primary key

            // Add a Format event handler to customize the display
            cmbNhanVien.Format += new ListControlConvertEventHandler(cmbNhanVien_Format);
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


    }
}
