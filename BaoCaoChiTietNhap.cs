using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace quanlyvattu
{
    public partial class BaoCaoChiTietNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoChiTietNhap(DateTime tu,DateTime den)
        {
            InitializeComponent();
            Console.WriteLine(tu.ToString()+ den.ToString());
            this.sqlDataSource1.Queries[0].Parameters[0].Value = new DevExpress.DataAccess.Expression($"'{tu:yyyy-MM-dd}'", typeof(DateTime));
            this.sqlDataSource1.Queries[0].Parameters[1].Value = new DevExpress.DataAccess.Expression($"'{den:yyyy-MM-dd}'", typeof(DateTime));

            this.Parameters["TuNgay"].Value = $"{tu:dd-MM-yyyy}";
            this.Parameters["DenNgay"].Value = $"{den:dd-MM-yyyy}";
            this.Parameters["TuNgay"].Visible = false;
            this.Parameters["DenNgay"].Visible = false;




            this.cellSoLuong.TextFormatString = "{0:n0}";
            this.cellTongTien.TextFormatString = "{0:#,##0} ₫";
            //this.tongThangLbl.TextFormatString = "{0:n0}";
            //this.cellTongTien.TextFormatString = "{0:#,##0} ₫";
            //this.tongNamLbl.TextFormatString = "{0:n0}";
            //this.tongTienNamLbl.TextFormatString = "{0:#,##0}₫";
        }

    }
}
