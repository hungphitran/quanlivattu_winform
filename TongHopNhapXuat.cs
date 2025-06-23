using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.XtraReports.UI;
using QLVT;


namespace quanlyvattu
{
    public partial class TongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public TongHopNhapXuat(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            try
            {
                // Convert dates to proper SQL Server format (yyyy-MM-dd)
                string fromDateStr = fromDate.ToString("yyyy-MM-dd");
                string toDateStr = toDate.ToString("yyyy-MM-dd");

                // Set the parameters directly as strings in SQL Server date format
                this.sqlDataSource1.Queries[0].Parameters[0].Value = fromDateStr;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = toDateStr;

                // Add parameters to display on the report
                this.label1.Text = $"BÁO CÁO TỔNG HỢP NHẬP XUẤT TỪ {fromDate:dd/MM/yyyy} ĐẾN {toDate:dd/MM/yyyy}";


                // Format currency values and percentages
                this.tableCell8.TextFormatString = "{0:0.00%}"; // TyLeNhap
                this.tableCell10.TextFormatString = "{0:0.00%}"; // TyLeXuat

                
                // Fill the report to load data

                this.sqlDataSource1.Fill();


                this.userLbl.Text = Program.mHoten;

                //calculation total
                double totalNhap = 0.0;
                double totalXuat = 0.0;



            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message);
            }
        }

    }
}
