using System;
using System.Collections;
using System.ComponentModel;
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
            userLbl.Text = Program.mHoten;
        }

    }
}
