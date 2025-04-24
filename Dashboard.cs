using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.labelName.Text = Program.mHoten;
            if (Program.mGroup.Equals("NhanVienRole"))
            {
                this.backupBtn.Visible = false;
                this.creatAccBtn.Visible = false;
                this.changePassBtn.Visible = false;
                this.tongHopNhapXuatBtn.Visible = false;

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.mlogin = "";
            Program.password = "";
            Program.mGroup = "";
            Program.mHoten = "";
            Program.conn.Close();
            FormManager.switchForm(this, new LoginForm());

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormNhanVien());
        }

        private void VattuBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormVatTu());
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }


        private void importBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormPhieuNhap());
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormDatHang());
        }

        private void creatAccBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormTaoAcc());
        }

        private void ImAndExportBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormSelectDetail());
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormPhieuXuat());
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new BackupRestoreForm());
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormDoiMatKhau());
        }

        private void tongHopNhapXuatBtn_Click(object sender, EventArgs e)
        {
            // Create date range selection form
            Form dateRangeForm = new Form();
            dateRangeForm.Text = "Chọn khoảng thời gian";
            dateRangeForm.Size = new Size(400, 200);
            dateRangeForm.StartPosition = FormStartPosition.CenterScreen;
            dateRangeForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            dateRangeForm.MaximizeBox = false;
            dateRangeForm.MinimizeBox = false;

            // Create from date picker
            Label fromLabel = new Label();
            fromLabel.Text = "Từ ngày:";
            fromLabel.Location = new Point(30, 30);
            fromLabel.Size = new Size(80, 20);

            DateTimePicker fromDatePicker = new DateTimePicker();
            fromDatePicker.Format = DateTimePickerFormat.Custom;
            fromDatePicker.Location = new Point(120, 30);
            fromDatePicker.Size = new Size(200, 20);
            fromDatePicker.CustomFormat = "dd/MM/yyyy";
            fromDatePicker.MaxDate = DateTime.Now;  // Set max date to today
            fromDatePicker.MinDate = new DateTime(2020, 1, 1); // Set min date to a reasonable value
            fromDatePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Set default to first day of current month

            // Create to date picker
            Label toLabel = new Label();
            toLabel.Text = "Đến ngày:";
            toLabel.Location = new Point(30, 70);
            toLabel.Size = new Size(80, 20);

            DateTimePicker toDatePicker = new DateTimePicker();
            toDatePicker.Format = DateTimePickerFormat.Custom;  // Changed from Short to Custom
            toDatePicker.Location = new Point(120, 70);
            toDatePicker.Size = new Size(200, 20);
            toDatePicker.CustomFormat = "dd/MM/yyyy";
            toDatePicker.MaxDate = DateTime.Now;  // Set max date to today
            toDatePicker.MinDate = new DateTime(2020, 1, 1); // Set min date to a reasonable value
            toDatePicker.Value = DateTime.Now; // Set default to today



            // Set default date range (current month)
            DateTime now = DateTime.Now;
            fromDatePicker.Value = new DateTime(now.Year, now.Month, 1);
            toDatePicker.Value = now;

            // Create submit button
            Button submitBtn = new Button();
            submitBtn.Text = "Xem báo cáo";
            submitBtn.Location = new Point(150, 120);
            submitBtn.Size = new Size(100, 30);
            submitBtn.Click += (s, ev) =>
            {
                if (fromDatePicker.Value > toDatePicker.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Create report with selected date range
                    TongHopNhapXuat report = new TongHopNhapXuat(fromDatePicker.Value, toDatePicker.Value);
                    if (!Program.hasData(report))
                    {
                        MessageBox.Show("Không có dữ liệu trong khoảng thời gian này",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    FormBaoCao baocao=new FormBaoCao(report);
                    baocao.Show();

                    dateRangeForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Add controls to the form
            dateRangeForm.Controls.Add(fromLabel);
            dateRangeForm.Controls.Add(fromDatePicker);
            dateRangeForm.Controls.Add(toLabel);
            dateRangeForm.Controls.Add(toDatePicker);
            dateRangeForm.Controls.Add(submitBtn);

            // Show the form
            dateRangeForm.ShowDialog();
        }

    }
}
