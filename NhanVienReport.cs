using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class NhanVienReport : DevExpress.XtraReports.UI.XtraReport
    {
        public NhanVienReport()
        {
            InitializeComponent();
            this.userLbl.Text = $"{Program.mHoten}";

        }

    }
}
