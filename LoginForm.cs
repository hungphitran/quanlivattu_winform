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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = this.txtUser.Text;
            String pass = this.txtPass.Text;

            Program.mlogin = userName;
            Program.password = pass;

            
            int success= Program.connectDB();

            if (success ==1)
            {
                MessageBox.Show("Đăng nhập thành công");
                SqlDataReader reader = Program.ExecSqlDataReader("use qlvt\r\nselect Nhanvien.HO , Nhanvien.TEN\r\nfrom sys.sysusers u, sys.syslogins l,NhanVien\r\nwhere u.sid = l.sid and l.loginname ='"+Program.mlogin+"' and Nhanvien.CMND= u.name");
                if (reader.HasRows)  // Kiểm tra có dữ liệu không
                {
                    Console.WriteLine(reader);

                    while (reader.Read())  // Duyệt từng dòng dữ liệu
                    {
                        //Program.mGroup = reader[""].ToString(); // Đọc dữ liệu an toàn
                        Program.mHoten = reader["HO"].ToString()+" "+reader["TEN"].ToString();
                        //String cmnd = reader["name"].ToString();

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

    }
}
