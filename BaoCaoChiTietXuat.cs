using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class BaoCaoChiTietXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoChiTietXuat(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denNgay;
            this.sqlDataSource1.Fill();
            userlbl.Text = Program.mHoten;
            this.titlelbl.Text += $" từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}";
        }

    }
}
