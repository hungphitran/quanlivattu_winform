using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class reportVattu : DevExpress.XtraReports.UI.XtraReport
    {
        public reportVattu()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
            this.Detail.BeforePrint += SortBeforePrint;
            userLbl.Text = Program.mHoten;
        }

        private void SortBeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //sort the data by TENVT in ascending order
            if (this.DataSource is DataSet ds && ds.Tables.Count > 0)
            {
                DataTable table = ds.Tables[0];
                if (table != null)
                {
                    table.DefaultView.Sort = "TENVT ASC";
                    this.DataSource = table.DefaultView.ToTable();
                }
            }
            else if (this.DataSource is DataView dv)
            {
                dv.Sort = "TENVT ASC";
                this.DataSource = dv.ToTable();
            }
        }

    }
}
