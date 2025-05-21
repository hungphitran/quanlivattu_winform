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
            // Set default values for date/time pickers
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;

            // Initially hide the point-in-time restore controls
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


        private void restoreWithTimeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Combine date and time for point-in-time recovery
                DateTime selectedDate = dtpDate.Value.Date;
                DateTime selectedTime = dtpTime.Value;

                // Create a combined DateTime with the selected date and time
                DateTime pointInTime = new DateTime(
                    selectedDate.Year,
                    selectedDate.Month,
                    selectedDate.Day,
                    selectedTime.Hour,
                    selectedTime.Minute,
                    selectedTime.Second);

                // Validate the selected time
                if (!IsValidRestoreTime(pointInTime))
                    return;

                DateTime oldestbackupTime = Convert.ToDateTime(sp_DanhSachBackUpDataGridView.Rows[sp_DanhSachBackUpDataGridView.Rows.Count-1].Cells[0].Value);
                Console.WriteLine(oldestbackupTime);

                //Ensure the restore time is after the backup time
                if (pointInTime < oldestbackupTime)
                {
                    MessageBox.Show(
                        $"Thời điểm phục hồi phải sau thời điểm sao lưu ({oldestbackupTime:dd/MM/yyyy HH:mm:ss}).",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Ensure the restore time is at least 1 minute before the current time
                if (pointInTime > DateTime.Now.AddMinutes(-1))
                {
                    Console.WriteLine(pointInTime + " " + DateTime.Now.AddMinutes(-1));
                    MessageBox.Show(
                        "Thời điểm phục hồi phải trước thời điểm hiện tại ít nhất 1 phút.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Format the datetime in SQL Server format (YYYY-MM-DD HH:MM:SS)
                string formattedDateTime = pointInTime.ToString("yyyy-MM-dd HH:mm:ss");

                // Confirm with user before proceeding with restore
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn phục hồi CSDL đến thời điểm: {formattedDateTime}?\n\n" +
                    "CẢNH BÁO: Thao tác này sẽ ngắt kết nối tất cả người dùng hiện tại và không thể hoàn tác.",
                    "Xác nhận phục hồi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    // Execute the restore with point-in-time recovery
                    int res = Program.ExecSqlNonQuery(
                        $"USE master; EXEC sp_PhucHoiCSDL_TheoThoiGian " +
                        $"@path=N'C:\\backup\\{deviceName}.bak', " +
                        $"@datetime='{formattedDateTime}'");
                    Console.WriteLine(res +" "+ $"USE master; EXEC sp_PhucHoiCSDL_TheoThoiGian " +
                        $"@path=N'C:\\backup\\{deviceName}.bak', " +
                        $"@datetime='{formattedDateTime}'");
                    Cursor = Cursors.Default;

                    // Notify the user of the result
                    if (res == 0)
                    {
                        MessageBox.Show(
                            $"Đã phục hồi CSDL đến thời điểm {formattedDateTime} thành công!",
                            "Thành công",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // After successful restore, refresh backup list
                        backupTableLoad();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Phục hồi theo thời gian thất bại. Thời điểm đã chọn có thể không có trong bản sao lưu.",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Có lỗi xảy ra khi phục hồi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private bool IsValidRestoreTime(DateTime pointInTime)
        {
            // Don't allow future dates
            if (pointInTime > DateTime.Now)
            {
                MessageBox.Show("Không thể phục hồi đến thời điểm trong tương lai.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if there are any backups available
            if (sp_DanhSachBackUpDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản sao lưu nào để phục hồi.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                // Get the oldest backup time
                DateTime oldestBackup = DateTime.MaxValue;
                foreach (DataGridViewRow row in sp_DanhSachBackUpDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        DateTime backupTime = Convert.ToDateTime(sp_DanhSachBackUpDataGridView.Rows[row.Index].Cells[0].Value);
                        if (backupTime < oldestBackup)
                            oldestBackup = backupTime;
                    }
                }

                // Make sure the selected time is within available backup range
                if (pointInTime < oldestBackup)
                {
                    MessageBox.Show($"Thời điểm đã chọn ({pointInTime:dd/MM/yyyy HH:mm:ss}) trước bản sao lưu cũ nhất ({oldestBackup:dd/MM/yyyy HH:mm:ss}).",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra thời gian: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
