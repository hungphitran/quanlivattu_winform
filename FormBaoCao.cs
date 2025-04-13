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

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Lưu file");
            // check which option is selected

            // Save the report to a file in C directory
            string filePath = "report.pdf"; // Specify the file path and name
            DevExpress.XtraReports.UI.XtraReport report = (DevExpress.XtraReports.UI.XtraReport)documentViewer1.DocumentSource;
            report.ExportToPdf(filePath);
            // Show a message box to indicate that the report has been saved
            MessageBox.Show("Report saved to " + filePath);

        }
    }
}
