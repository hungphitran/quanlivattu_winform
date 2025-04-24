using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class ddhChuaNhapRep : DevExpress.XtraReports.UI.XtraReport
    {
        public ddhChuaNhapRep()
        {
            InitializeComponent();
            xrLabel1.Text = $"Người lập: {Program.mHoten}";
        }

    }
}
