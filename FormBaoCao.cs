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


        private void pdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the report
                DevExpress.XtraReports.UI.XtraReport report = (DevExpress.XtraReports.UI.XtraReport)documentViewer1.DocumentSource;

                // Create a SaveFileDialog to let the user choose where to save the file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Lưu báo cáo";
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
                    MessageBox.Show($"Báo cáo đã lưu vào {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the file (optional)
                    if (MessageBox.Show("Bạn có muốn mở file không?", "Mở File",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy báo cáo từ DocumentViewer
                DevExpress.XtraReports.UI.XtraReport report = (DevExpress.XtraReports.UI.XtraReport)documentViewer1.DocumentSource;

                // Tạo SaveFileDialog để người dùng chọn nơi lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Lưu báo cáo";
                saveFileDialog.InitialDirectory = "C:\\"; // Thư mục mặc định
                saveFileDialog.FileName = "report.xlsx";

                // Hiển thị SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Xuất báo cáo ra file Excel
                    report.ExportToXlsx(filePath);

                    // Thông báo thành công
                    MessageBox.Show($"Báo cáo đã lưu vào {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở file nếu người dùng muốn
                    if (MessageBox.Show("Bạn có muốn mở file?", "Mở File",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu báo cáo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
