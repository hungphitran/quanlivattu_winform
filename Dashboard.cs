using System;
using System.Windows.Forms;
using QLVT;

namespace quanlyvattu
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.toolStripStatusLabel1.Text = Program.mHoten;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.mlogin = "";
            Program.password = "";
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

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
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
    }
}
