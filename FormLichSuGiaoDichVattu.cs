using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyvattu
{
    public partial class FormLichSuGiaoDichVattu : Form
    {
        public FormLichSuGiaoDichVattu(String mavt)
        {
            InitializeComponent();
            LichSuVattuReport lsRp = new LichSuVattuReport(mavt);
            documentViewer1.DocumentSource = lsRp;
            lsRp.CreateDocument();
        }
    }
}
