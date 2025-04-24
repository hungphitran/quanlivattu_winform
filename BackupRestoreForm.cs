using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using QLVT;

namespace quanlyvattu
{
    public partial class BackupRestoreForm : Form
    {
        private String deviceName = "device_qlvt";
        public BackupRestoreForm()
        {
            InitializeComponent();

            DataTable deviceTable = Program.ExecSqlDataTable("USE master; EXEC sp_helpdevice");
            if (deviceTable != null && deviceTable.Rows.Count >0)
            {
                createDeviceBtn.Visible = false;
                groupControl1.Visible = false;
                backupTableLoad();
            }
            else
            {
                createDeviceBtn.Visible = true;
                groupControl1.Visible= true;
                MessageBox.Show("Chưa có thiết bị nào, vui lòng tạo thiết bị trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.dtpDate.Visible = false;
            this.dtpTime.Visible = false;
            this.lblTime.Visible = false;
            this.restoreWithTimeBtn.Visible = false;
        }

        public void backupTableLoad()
        {

            DataTable backupTable = Program.ExecSqlDataTable($"EXEC sp_DanhSachBackUp 'qlvt', '{deviceName}'");
            if (backupTable != null)
            {
                createDeviceBtn.Visible = false;
                groupControl1.Visible = false;
                if (backupTable.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có bản sao lưu trên thiết bị này");
                    restoreBtn.Visible = false;

                }
                else
                {
                    restoreBtn.Visible = true;
                }
                this.sp_DanhSachBackUpDataGridView.DataSource = backupTable;
            }
            else
            {
                MessageBox.Show("Không thể tải lại danh sách sao lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormManager.switchForm(this, new Dashboard());
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void createDeviceBtn_Click(object sender, EventArgs e)
        {
            int res = Program.ExecSqlNonQuery($"USE master; EXEC sp_TaoDeviceSaoLuu '{deviceName}', 'C:\\backup\\{deviceName}.bak'");

            // Notify the user of the result
            if (res == 0)
            {

                MessageBox.Show("Tạo thiết bị thành công!");
                // Load the backup table for the newly created device
                backupTableLoad();
            }
            else
            {
                MessageBox.Show("Tạo thiết bị thất bại!");
            }
        }

        private void deviceCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load the backup table for the selected device
            backupTableLoad();

        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            if (this.sp_DanhSachBackUpDataGridView.Rows.Count > 0)
            {
                DateTime currentDate = DateTime.Now;
                DateTime latestBackup = Convert.ToDateTime(this.sp_DanhSachBackUpDataGridView.Rows[0].Cells[0].Value);
                if (currentDate < latestBackup.AddMinutes(1))
                {
                    MessageBox.Show("Chưa đủ thời gian để sao lưu lại, vui lòng thử lại sau 1 phút!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Execute the backup stored procedure
            if (checkEdit1.Checked)
            {
                int res = Program.ExecSqlNonQuery($"USE qlvt; EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}',1");
                // Notify the user of the result
                MessageBox.Show(res == 0 ? "Sao lưu thành công!" : "Sao lưu thất bại!");
            }
            else
            {
                int res = Program.ExecSqlNonQuery($"USE qlvt; EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}',0");   
                // Notify the user of the result
                MessageBox.Show(res == 0 ? "Sao lưu thành công!" : "Sao lưu thất bại!");
            }

            // Refresh the DataGridView by reloading the data
            backupTableLoad();
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            int index = sp_DanhSachBackUpDataGridView.CurrentCell.RowIndex;
            Console.WriteLine("index"+index);
            Console.WriteLine("devicename: "+deviceName);

            int res = Program.ExecSqlNonQuery($"USE master; EXEC sp_PhucHoiCSDL @path=N'C:\\backup\\{deviceName}.bak',@index={this.sp_DanhSachBackUpDataGridView.Rows.Count - index}");
            // Notify the user of the result
            if (res == 0)
            {
                MessageBox.Show("Phục hồi thành công!");
            }
            else
            {
                MessageBox.Show("Phục hồi thất bại!");
            }

            //Program.connectDB();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = this.checkEdit2.Checked;
            if (!isChecked)
            {
                this.dtpDate.Visible = false;
                this.dtpTime.Visible = false;
                this.lblTime.Visible = false;
                this.restoreWithTimeBtn.Visible = false;
            }
            else
            {
                this.dtpDate.Visible = true;
                this.dtpTime.Visible = true;
                this.lblTime.Visible = true;
                this.restoreWithTimeBtn.Visible = true;
            }
        }
    }
}
