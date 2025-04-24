using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace quanlyvattu
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao(DevExpress.XtraReports.UI.XtraReport report)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = report;
            // Create the document
            report.CreateDocument();
            
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the report
                DevExpress.XtraReports.UI.XtraReport report = (DevExpress.XtraReports.UI.XtraReport)documentViewer1.DocumentSource;

                // Create a SaveFileDialog to let the user choose where to save the file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Report";
                saveFileDialog.InitialDirectory = "C:\\"; // Set initial directory to C drive
                saveFileDialog.FileName = "report.pdf";

                // Show the SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = saveFileDialog.FileName;

                    // Export the report to PDF
                    report.ExportToPdf(filePath);

                    // Show a success message
                    MessageBox.Show($"Report saved to {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the file (optional)
                    if (MessageBox.Show("Do you want to open the file?", "Open File",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
