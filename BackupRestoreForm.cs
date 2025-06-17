using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeParser;
using QLVT;

namespace quanlyvattu
{
    public partial class BackupRestoreForm : Form
    {
        private String deviceName = "device_qlvt";
        string folderPath = @"C:\backup\";
        public BackupRestoreForm()
        {
            InitializeComponent();

            DataTable deviceTable = Program.ExecSqlDataTable("USE master; EXEC sp_helpdevice");
            if (deviceTable != null && deviceTable.Rows.Count > 0)
            {
                createDeviceBtn.Visible = false;
                groupControl1.Visible = false;
                backupTableLoad();
            }
            else
            {
                createDeviceBtn.Visible = true;
                groupControl1.Visible = true;
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
        static List<string> GetFilesInTimeRange(string folderPath, DateTime from, DateTime to)
        {
            var matchingFiles = new List<string>();

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Thư mục không tồn tại.");
                return matchingFiles;
            }

            var files = Directory.GetFiles(folderPath, "qlvt_Log_*.trn");

            //sắp xếp tập tin theo thời gian tạo
            files = files.OrderBy(f => File.GetCreationTime(f)).ToArray();


            foreach (var file in files)
            {
                string name = Path.GetFileNameWithoutExtension(file); // qlvt_Log_20250615_181831
                string[] parts = name.Split('_');
                if (parts.Length > 3)
                {
                    string datePart = parts[2]; // 20250615
                    string timePart = parts[3]; // 181831
                    if (DateTime.TryParseExact(datePart + timePart, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out DateTime fileTime))
                    {
                        if (fileTime >= from && fileTime < to)
                        {
                            matchingFiles.Add(file);
                        }
                        else if (fileTime >= to)
                        {
                            //last file >= to
                            matchingFiles.Add(file);
                            break; // Stop searching once we find a file after 'to'
                        }
                    }
                }
            }

            return matchingFiles;
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

                int index = sp_DanhSachBackUpDataGridView.CurrentCell.RowIndex;

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

                DateTime fullbackupTime = Convert.ToDateTime(sp_DanhSachBackUpDataGridView.Rows[index].Cells[0].Value);



                //Ensure the restore time is after the backup time
                if (pointInTime < fullbackupTime)
                {
                    MessageBox.Show(
                        $"Thời điểm phục hồi phải sau thời điểm sao lưu ({fullbackupTime:dd/MM/yyyy HH:mm:ss}).",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                List<string> logFiles = GetFilesInTimeRange(folderPath, fullbackupTime, pointInTime);

                if (logFiles.Count == 0)
                {
                    MessageBox.Show(
                        $"Không tìm thấy bản sao lưu trong khoang thời gian {fullbackupTime:dd/MM/yyyy HH:mm:ss} đến {pointInTime:dd/MM/yyyy HH:mm:ss}.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
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
                        // Backup log hiện tại để tránh mất log chưa backup
                        string backupLogQuery = $@"exec sp_TaoBackupLog '{Program.database}', 'C:\backup\'";

                        using (SqlCommand logCmd = new SqlCommand(backupLogQuery, Program.conn))
                        {
                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            logCmd.ExecuteNonQuery();
                        }
                        if (Program.conn.State == ConnectionState.Open)
                            Program.conn.Close();


                    using (SqlConnection conn = new SqlConnection(Program.connstr))
                    {
                        conn.Open();

                        // Đưa về SINGLE_USER
                        string setSingleUser = $@"USE master ALTER DATABASE [{Program.database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        using (SqlCommand cmd = new SqlCommand(setSingleUser, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Restore full backup từ device với FILE = index
                        string restoreFull = $@"
                            RESTORE DATABASE [{Program.database}]
                            FROM DISK = N'{folderPath}device_qlvt.bak'
                            WITH FILE = {index}, NORECOVERY, REPLACE";
                        using (SqlCommand cmd = new SqlCommand(restoreFull, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        bool stopApplied = false;

                        for (int i = 0; i < logFiles.Count; i++)
                        {
                            string logFile = "C:\\backup\\"+logFiles[i];
                            Console.WriteLine(logFile);
                            string restoreLog;
                            DateTime logFileTime = File.GetCreationTime(logFile);

                            if (!stopApplied)
                            {
                                if (logFileTime >= pointInTime)
                                {
                                    restoreLog = $@"
                                        RESTORE LOG [{Program.database}]
                                        FROM DISK = N'{logFile}'
                                        WITH STOPAT = '{pointInTime:yyyy-MM-dd HH:mm:ss}', RECOVERY";
                                    stopApplied = true;
                                }
                                else
                                {
                                    restoreLog = $@"
                                    RESTORE LOG [{Program.database}]
                                    FROM DISK = N'{logFile}'
                                    WITH NORECOVERY";
                                }
                            }
                            else
                            {
                                break;
                            }
                            using (SqlCommand cmd = new SqlCommand(restoreLog, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            if (!stopApplied)
                            {
                                throw new Exception("Không tìm thấy file log chứa thời điểm STOPAT.");
                            }
                        }

                        MessageBox.Show($"Đã Phục hồi thành công về thời điểm: {pointInTime:yyyy-MM-dd HH:mm:ss}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.ExecSqlNonQuery("USE master; ALTER DATABASE qlvt SET MULTI_USER WITH ROLLBACK IMMEDIATE;");
                        // Bắt đầu restore log chain hợp lệ kể từ bản full
                        // After successful restore, refresh backup list
                        backupTableLoad();
                    }
                }
            }
            catch (Exception ex)
            {
                Program.ExecSqlNonQuery("use master; restore database qlvt with recovery;");
                
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
            Console.WriteLine("index" + index);
            Console.WriteLine("devicename: " + deviceName);

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
 