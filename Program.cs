using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using quanlyvattu;
using System.Text;
using DevExpress.DataAccess.Sql;



namespace QLVT
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "localhost";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "qlvt";

        public static String mGroup = "";
        public static String mHoten = "";
        public static String manv = "";


        public static int connectDB()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Console.WriteLine(Program.connstr);
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            try
            {
                da.Fill(dt);
                Program.conn.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole(); // Hàm mở console

        [STAThread]

        public static bool hasData(DevExpress.XtraReports.UI.XtraReport report)
        {

            try
            {
                Console.WriteLine(report.DataSource.GetType());
                if (report.DataSource == null) return false;
                else if (report.DataSource is DataSet)
                {
                    
                    DataSet ds = (DataSet)report.DataSource;
                    foreach (DataTable dt in ds.Tables)
                    {
                        if (dt.Rows.Count > 0) return true;
                    }
                }
                else if (report.DataSource is DataTable)
                {
                    DataTable dt = (DataTable)report.DataSource;
                    if (dt.Rows.Count > 0) return true;
                }
                else if(report.DataSource is DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource)
                {
                    try
                    {
                        sqlDataSource.Fill();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error filling SqlDataSource: " + ex.Message);
                    }

                    // Check if Result is not null and has tables with data
                    if (sqlDataSource.Result != null)
                    {
                        foreach (DevExpress.DataAccess.Native.Sql.ResultTable table in sqlDataSource.Result)
                        {
                            if (table.Count > 0)
                                return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AllocConsole();
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Application.Run(new LoginForm());
        }
    }
}
