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
using DevExpress.DataAccess.Sql;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using QLVT;
using Siticone.Desktop.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace quanlyvattu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUser.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToLowercase_NoSpace;
            txtPass.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToLowercase_NoSpace;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = this.txtUser.Text;
            String pass = this.txtPass.Text;



            Program.mlogin = userName;
            Program.password = pass;
            int manv=0;


            int success= Program.connectDB();

            if (success ==1)
            {
                var msg = new SiticoneMessageDialog();
                msg.Text = "Đăng nhập thành công";
                msg.Caption = "Thông báo";
                msg.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.Error;  
                msg.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Light;
                msg.Show();

                // lấy user của login
                SqlDataReader reader = Program.ExecSqlDataReader($"USE qlvt;\n" +
                    "select dp.name AS UserName \n"+
                    "FROM sys.database_principals dp \n" +
                    "LEFT JOIN sys.server_principals sp ON dp.sid = sp.sid \n"+
                    $"WHERE sp.name = '{userName}'; \n");

                if (reader.HasRows)  // Kiểm tra có dữ liệu không
                {
                    Console.WriteLine(reader);

                    while (reader.Read())  // Duyệt từng dòng dữ liệu
                    {
                        string user= reader["Username"].ToString(); // login_manv
                        manv =  int.Parse(user.Split('_')[1]);
                    }
                }
                reader.Close();
                // lấy thông tin người dùng
                reader = Program.ExecSqlDataReader($"USE qlvt;\n " +
                    "select HO, TEN, MANV\n" +
                    "FROM Nhanvien nv\n" +
                    $"WHERE MANV = '{manv}';\n ");
                if (reader.HasRows)  // Kiểm tra có dữ liệu không
                {
                    Console.WriteLine(reader);

                    while (reader.Read())  // Duyệt từng dòng dữ liệu
                    {
                        Program.mHoten = reader["HO"].ToString()+" "+reader["TEN"].ToString();
                        Program.manv = reader["MANV"].ToString();
                        Console.WriteLine("Ho ten: " + Program.mHoten);
                        Console.WriteLine("Ma NV: " + Program.manv);
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }
                reader.Close();
                reader = Program.ExecSqlDataReader($"SELECT \n    sp.name AS LoginName,\n    sr.name AS ServerRole\nFROM \n    sys.server_principals sp\n    LEFT JOIN sys.server_role_members srm ON sp.principal_id = srm.member_principal_id\n    LEFT JOIN sys.server_principals sr ON srm.role_principal_id = sr.principal_id\nWHERE \n    sp.name = '{Program.mlogin}';");
                if (reader.HasRows)  // Kiểm tra có dữ liệu không
                {
                    Console.WriteLine(reader);

                    while (reader.Read())  // Duyệt từng dòng dữ liệu
                    {
                        if (reader["ServerRole"].ToString().Equals("AdminRole") ||
                            reader["ServerRole"].ToString().Equals("NhanVienRole"))
                        {
                            Program.mGroup = reader["ServerRole"].ToString();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }
                reader.Close();
                Console.WriteLine("group of " + Program.mlogin + " is " + Program.mGroup);
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {

                
                MessageBox.Show("Không thể đăng nhập");

            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
