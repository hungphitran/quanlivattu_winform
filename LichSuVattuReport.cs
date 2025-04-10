using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;

namespace quanlyvattu
{
    public partial class LichSuVattuReport : DevExpress.XtraReports.UI.XtraReport
    {
        public LichSuVattuReport(string mavt)
        {
            InitializeComponent();

            // Create and configure the MAVT parameter
            DevExpress.XtraReports.Parameters.Parameter mavtParameter = new DevExpress.XtraReports.Parameters.Parameter
            {
                Name = "MAVT", // Parameter name in the report
                Type = typeof(string), // Parameter type
                Value = mavt, // Assign the value passed to the constructor
                Visible = false // Optional: Hide the parameter in the UI
            };

            // Add the parameter to the report
            this.Parameters.Add(mavtParameter);

            // Bind the report parameter to the SQL query parameter
            this.sqlDataSource1.Queries[0].Parameters[0].Value = mavt; // Directly assign the string value
        }



    }
}
