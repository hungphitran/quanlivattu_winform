using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class BaoCaoChiTietNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoChiTietNhap(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = denNgay;
            Console.WriteLine(new DevExpress.DataAccess.Expression($"'{tuNgay}'", typeof(DateTime)));

            this.sqlDataSource1.Fill();
            this.titlelbl.Text+= $" từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}";
            this.userlbl.Text = Program.mHoten;
        }

    }
}
