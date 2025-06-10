using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class BaoCaoChiTietXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public BaoCaoChiTietXuat(DateTime tu, DateTime den)
        {
            Console.WriteLine(tu.ToString()+ den.ToString());
            InitializeComponent();

            this.sqlDataSource1.Queries[0].Parameters[0].Value = new DevExpress.DataAccess.Expression($"'{tu:yyyy-MM-dd}'", typeof(DateTime));
            this.sqlDataSource1.Queries[0].Parameters[1].Value = new DevExpress.DataAccess.Expression($"'{den:yyyy-MM-dd}'", typeof(DateTime));

            this.Parameters["TuNgay"].Value = $"{tu:dd-MM-yyyy}";
            this.Parameters["DenNgay"].Value = $"{den:dd-MM-yyyy}";
            this.Parameters["TuNgay"].Visible = false;
            this.Parameters["DenNgay"].Visible = false;
            
            this.cellSoLuong.TextFormatString = "{0:n0}";
            this.cellTongTien.TextFormatString = "{0:#,##0} ₫";
            this.cellTongTien.TextFormatString = "{0:#,##0} ₫";
            this.tongNamLbl.TextFormatString = "{0:n0}";
            this.tongTienNamLbl.TextFormatString = "{0:#,##0}₫";

            this.userLbl.Text= $"Người lập: {Program.mHoten}";

        }

    }
}
