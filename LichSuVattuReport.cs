using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class LichSuVattuReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LichSuVattuReport(string mavt, string tenvt)
        {
            InitializeComponent();
            // Bind the report parameter to the SQL query parameter
            this.Parameters["MAVT"].Value = mavt + ": "; // Directly assign the string value
            this.Parameters["MAVT"].Visible = false;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = new DevExpress.DataAccess.Expression($"'{mavt}'", typeof(string)); // Set the parameter for the SQL query
            Console.WriteLine(this.sqlDataSource1.Queries[0].Parameters[0].Value.ToString());
            userLbl.Text = Program.mHoten;
            this.tenLbl.Text = tenvt;
        }

    }
}
