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
            // Bind the report parameter to the SQL query parameter
            this.Parameters["MAVT"].Value = mavt; // Directly assign the string value
            this.Parameters["MAVT"].Visible = false;
        }

    }
}
