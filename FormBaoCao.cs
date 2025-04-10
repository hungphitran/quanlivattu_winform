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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao(DevExpress.XtraReports.UI.XtraReport report)
        {
            InitializeComponent();
            // Set the report as the document source for the DocumentViewer
            documentViewer1.DocumentSource = report;
            // Create the document
            report.CreateDocument();
        }
    }
}
