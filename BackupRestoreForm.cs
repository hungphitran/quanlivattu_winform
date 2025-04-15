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
        public BackupRestoreForm()
        {
            InitializeComponent();

            DataTable deviceTable = Program.ExecSqlDataTable("EXEC sp_helpdevice");
            if (deviceTable != null)
            {
                this.deviceCb.DataSource = deviceTable;
                this.deviceCb.DisplayMember = "name";
                this.deviceCb.ValueMember = "device_name";
                this.deviceCb.SelectedIndex = 0; // Select the first device by default
            }


            // Trigger the SelectedIndexChanged event manually for the first load
            if (this.deviceCb.SelectedValue != null)
            {
                String deviceName = this.deviceCb.SelectedValue.ToString();
                
                backupTableLoad(deviceName);
                
                this.deviceCb.SelectedIndexChanged += deviceCb_SelectedIndexChanged;
            }
        }

        public void backupTableLoad(String deviceName)
        {

            DataTable backupTable = Program.ExecSqlDataTable($"EXEC sp_DanhSachBackUp 'qlvt', '{deviceName}'");
            if (backupTable != null)
            {
                 
                if (backupTable.Rows.Count == 0)
                {
                    Console.WriteLine("1");
                    MessageBox.Show("Chưa có bản sao lưu trên thiết bị này");
                    restoreBtn.Enabled = false;

                }
                else
                {
                    Console.WriteLine("2");
                    restoreBtn.Enabled = true;
                }
                this.sp_DanhSachBackUpDataGridView.DataSource = backupTable;
            }
            else
            {
                MessageBox.Show("Không thể tải lại danh sách sao lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void createDeviceBtn_Click(object sender, EventArgs e)
        {
            // Check if the device name and path are provided
            if (string.IsNullOrWhiteSpace(this.deviceNameInput.Text) || string.IsNullOrWhiteSpace(this.deviceNameInput.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị và đường dẫn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int res = Program.ExecSqlNonQuery($"EXEC sp_TaoDeviceSaoLuu '{this.deviceNameInput.Text}', 'C:\\backup\\{this.deviceNameInput.Text}.bak'");

            // Notify the user of the result
            if (res == 0)
            {

                // Refresh the device list
                DataTable deviceTable = Program.ExecSqlDataTable("EXEC sp_helpdevice");
                if (deviceTable != null)
                {
                    this.deviceCb.DataSource = deviceTable;
                    this.deviceCb.DisplayMember = "name";
                    this.deviceCb.ValueMember = "device_name";
                    this.deviceCb.SelectedIndex = 0; // Select the first device by default
                }
                MessageBox.Show("Tạo thiết bị thành công!");
                // Load the backup table for the newly created device
                String deviceName = this.deviceCb.SelectedValue.ToString();
                backupTableLoad(deviceName);
            }
            else
            {
                MessageBox.Show("Tạo thiết bị thất bại!");
            }
        }

        private void deviceCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String deviceName = this.deviceCb.SelectedValue.ToString();
            // Load the backup table for the selected device
            backupTableLoad(deviceName);

        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            String deviceName = this.deviceCb.SelectedValue.ToString();

            // Execute the backup stored procedure
            int res = Program.ExecSqlNonQuery($"USE qlvt EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}'");

            // Notify the user of the result
            MessageBox.Show(res == 0 ? "Sao lưu thành công!" : "Sao lưu thất bại!");

            // Refresh the DataGridView by reloading the data
            backupTableLoad(deviceName);
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            int index = sp_DanhSachBackUpDataGridView.CurrentCell.RowIndex;
            String deviceName = this.deviceCb.SelectedValue.ToString();


            int res = Program.ExecSqlNonQuery($"USE master; EXEC sp_PhucHoiCSDL 'qlvt', '{deviceName}', '{sp_DanhSachBackUpDataGridView.Rows[index].Cells[0].Value.ToString()}'");
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
    }
}
