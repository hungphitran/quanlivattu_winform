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
            //Console.WriteLine(tu.ToString()+ den.ToString());
            InitializeComponent();
            this.Parameters["TuNgay"].Value = tu;
            this.Parameters["DenNgay"].Value = den;
            this.Parameters["TuNgay"].Visible = false;
            this.Parameters["DenNgay"].Visible = false;

        }

    }
}
