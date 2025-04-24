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
        public TongHopNhapXuat()
        {
            InitializeComponent();
        }

        public TongHopNhapXuat(DateTime fromDate, DateTime toDate) : this()
        {

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
                this.tableCell7.TextFormatString = "{0:#,##0}"; // Nhap
                this.tableCell8.TextFormatString = "{0:0.00%}"; // TyLeNhap
                this.tableCell9.TextFormatString = "{0:#,##0}"; // Xuat
                this.tableCell10.TextFormatString = "{0:0.00%}"; // TyLeXuat


                // Fill the report to load data
                this.sqlDataSource1.Fill();
    
                // Bind events for calculating totals
                this.BeforePrint += TongHopNhapXuat_BeforePrint;
                Console.WriteLine("Ho ten: "+Program.mHoten);
                this.userLbl.Text = "Người lập báo cáo: " + Program.mHoten;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message);
            }
        }

        private void TongHopNhapXuat_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e)
            {
            // Calculate totals
            CalculateTotals();
            }

        private void CalculateTotals()
        {
            try
            {
                // Access the data source
                ResultTable data =sqlDataSource1.Result[0] as ResultTable;


                decimal tongNhap = 0;
                decimal tongXuat = 0;

                // Sum up all Nhap and Xuat values
                foreach (ResultRow row in data)
                {
                    tongNhap += Convert.ToDecimal(row.ToArray()[1]);
                    tongXuat += Convert.ToDecimal(row.ToArray()[3]);
                }

                // Set the total values to the report labels
                // Add this line to format the TongNhap parameter display
                this.xrLabel1.TextFormatString = "{0:#,##0}";

                // You may also want to format TongXuat the same way
                this.xrLabel2.TextFormatString = "{0:#,##0}";
                this.TongNhap.Value = tongNhap;
                this.TongXuat.Value = tongXuat;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi khi tính tổng: " + ex.Message);
            }
        }
    }
}
