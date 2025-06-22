using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeParser;
using DevExpress.XtraCharts.Native;
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

            var files = Directory.GetFiles(folderPath, "qlvt_*.trn");

            //sắp xếp tập tin theo thời gian tạo
            files = files.OrderBy(f => File.GetCreationTime(f)).ToArray();


            foreach (var file in files)
            {
                string name = Path.GetFileNameWithoutExtension(file); // qlvt_Log_20250615_181831
                string[] parts = name.Split('_');
                if (parts.Length > 2)
                {
                    string datePart = parts[1]; // 20250615
                    string timePart = parts[2]; // 181831
                    if (DateTime.TryParseExact(datePart + timePart, "yyyyMMddHHmmss", null, System.Globalization.DateTimeStyles.None, out DateTime fileTime))
                    {
                        if (fileTime > from && fileTime < to)
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
        public void DeleteUnnecessaryLogFiles()
        {
            try
            {
                string folderPath = @"C:\backup"; // ✅ Thay đổi đường dẫn này nếu cần

                // Lấy tất cả các file .trn trong thư mục
                string[] logFiles = Directory.GetFiles(folderPath, "*.trn");

                List<string> deletedFiles = new List<string>();

                foreach (var file in logFiles)
                {
                    DateTime creationTime = File.GetCreationTime(file);

                    if (creationTime < DateTime.Now)
                    {
                        File.Delete(file);
                        deletedFiles.Add(file);
                    }
                }

                Console.WriteLine(
                    $"Đã xoá {deletedFiles.Count} file log không cần thiết:\n" + string.Join("\n", deletedFiles));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xoá file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int getNearestBackupIndex(DateTime pointInTime)
        {
            int index = -1;
            for (int i = 0; i < sp_DanhSachBackUpDataGridView.Rows.Count; i++)
            {
                DateTime backupTime = Convert.ToDateTime(sp_DanhSachBackUpDataGridView.Rows[i].Cells[0].Value);
                if (backupTime <= pointInTime)
                {
                    index = i;
                    Console.WriteLine("index: " + index);
                    break;
                }
            }
            return index;
        }


        private void restoreWithTimeBtn_Click(object sender, EventArgs e)
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

            int index = getNearestBackupIndex(pointInTime); // lấy index của bản backup gần nhất trước thời điểm phục hồi

            
            DateTime fullbackupTime = Convert.ToDateTime(sp_DanhSachBackUpDataGridView.Rows[index].Cells[0].Value);
                Console.WriteLine("Full backup time: " + fullbackupTime);
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
                else if (pointInTime > DateTime.Now.AddMinutes(-1))
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
                    using (SqlConnection conn = new SqlConnection(Program.connstr))
                    {
                        conn.Open();
                    try
                    {
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        //lấy thời gian của bản backup mới nhất
                        //DateTime dateTime = Convert.ToDateTime(sp_DanhSachBackUpDataGridView.Rows[0].Cells[0].Value);

                        //if (pointInTime > dateTime)
                        //{
                            // Backup log hiện tại để tránh mất log chưa backup
                            string backupLogQuery = $@"use qlvt; exec sp_TaoBackupLog '{Program.database}'";
                            using (SqlCommand logCmd = new SqlCommand(backupLogQuery, conn))
                            {
                                logCmd.ExecuteNonQuery();
                            }
                        //}

                        List<string> logFiles = GetFilesInTimeRange(folderPath, fullbackupTime, pointInTime);

                        // Đưa về SINGLE_USER
                        string setSingleUser = $@"USE master; ALTER DATABASE [{Program.database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        using (SqlCommand cmd = new SqlCommand(setSingleUser, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        string restoreFull;
                        if (pointInTime == fullbackupTime)
                        {
                            // Restore full backup từ device với FILE = index
                            restoreFull = $@"
                            RESTORE DATABASE [{Program.database}]
                            FROM DISK = N'{folderPath}device_qlvt.bak'
                            WITH FILE = {sp_DanhSachBackUpDataGridView.Rows.Count - index}, RECOVERY, REPLACE";
                            Console.WriteLine("cmd" + restoreFull);
                            using (SqlCommand cmd = new SqlCommand(restoreFull, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Restore full backup từ device với FILE = index
                            restoreFull = $@"
                                RESTORE DATABASE [{Program.database}]
                                FROM DISK = N'{folderPath}device_qlvt.bak'
                                WITH FILE = {sp_DanhSachBackUpDataGridView.Rows.Count - index}, NORECOVERY, REPLACE";
                            Console.WriteLine("cmd" + restoreFull);
                            using (SqlCommand cmd = new SqlCommand(restoreFull, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            string restoreLog = "";
                            bool stopApplied = false;
                            for (int i = 0; i < logFiles.Count; i++)
                            {
                                string logFile = logFiles[i];

                                DateTime logFileTime = File.GetCreationTime(logFile);
                                if (logFileTime >= pointInTime)
                                {
                                    restoreLog += $@"
                                        RESTORE LOG [{Program.database}]
                                        FROM DISK = N'{logFile}'
                                        WITH STOPAT = '{pointInTime:yyyy-MM-dd HH:mm:ss}',
                                        RECOVERY; " + "\n";
                                    stopApplied = true;
                                }
                                else
                                {// restore log trước thời điểm
                                    restoreLog += $@"
                                        RESTORE LOG [{Program.database}]
                                        FROM DISK = N'{logFile}'
                                        WITH NORECOVERY; " + "\n";
                                }


                                if (stopApplied)
                                    break;
                            }

                            Console.WriteLine(restoreLog);
                            using (SqlCommand cmd = new SqlCommand(restoreLog, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                            // Đưa về MULTI_USER
                            using (SqlCommand cmd = new SqlCommand("ALTER DATABASE qlvt SET MULTI_USER WITH ROLLBACK IMMEDIATE;", conn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                        // Xóa log khong can thiet
                        //DeleteUnnecessaryLogFiles(folderPath, fullbackupTime, pointInTime);
                        MessageBox.Show($"Đã Phục hồi thành công về thời điểm: {pointInTime:yyyy-MM-dd HH:mm:ss}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Đưa về MULTI_USER
                        //Program.ExecSqlNonQuery();
                        // backup with init 
                        DeleteUnnecessaryLogFiles();
                        int res = Program.ExecSqlNonQuery($"USE qlvt; EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}',1");
                        Program.ExecSqlNonQuery($"USE master; EXEC sp_XoaLoginMoCoi; \n use qlvt; EXEC sp_TaoLoginChoTatCaUserChuaCoLogin");

                        // Bắt đầu restore log chain hợp lệ kể từ bản full
                        // After successful restore, refresh backup list
                        backupTableLoad();
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            // Cố gắng đưa database về RECOVERY (nếu còn đang RESTORING)
                            //Program.ExecSqlNonQuery("USE master; RESTORE DATABASE qlvt WITH RECOVERY;");
                            using (SqlCommand cmd = new SqlCommand("USE master; RESTORE DATABASE qlvt WITH RECOVERY;", conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception innerEx)
                        {
                            // Nếu có lỗi trong quá trình khôi phục trạng thái, có thể ghi log hoặc cảnh báo
                            MessageBox.Show("Lỗi khi cố gắng đưa CSDL về trạng thái hoạt động: " + innerEx.Message,
                                            "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Hiển thị lỗi chính xảy ra khi phục hồi
                        MessageBox.Show("Có lỗi xảy ra khi phục hồi:\n" + ex.Message,
                                        "Lỗi phục hồi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
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
                DeleteUnnecessaryLogFiles();
                Program.ExecSqlNonQuery($"USE qlvt; EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}',1");
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
            if (checkEdit1.Checked)//with init
            {
                DeleteUnnecessaryLogFiles();
                int res = Program.ExecSqlNonQuery($"USE qlvt; EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}',1");
                // Notify the user of the result
                MessageBox.Show(res == 0 ? "Sao lưu thành công!" : "Sao lưu thất bại!");
                string backupLogQuery = $@"use qlvt; exec sp_TaoBackupLog '{Program.database}'";
                Program.ExecSqlNonQuery(backupLogQuery);

            }
            else //without init
            {
                string backupLogQuery = $@"use qlvt; exec sp_TaoBackupLog '{Program.database}'";
                Program.ExecSqlNonQuery(backupLogQuery);
                int res = Program.ExecSqlNonQuery($"USE qlvt; EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}',0");
                // Notify the user of the result
                MessageBox.Show(res == 0 ? "Sao lưu thành công!" : "Sao lưu thất bại!");
                // Backup log hiện tại để tránh mất log chưa backup
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
                DeleteUnnecessaryLogFiles();
                Program.ExecSqlNonQuery($"USE qlvt; EXEC sp_SaoLuuCSDL 'qlvt', '{deviceName}',1");
                Program.ExecSqlNonQuery($"USE master; EXEC sp_XoaLoginMoCoi; \n use qlvt; EXEC sp_TaoLoginChoTatCaUserChuaCoLogin");
            }
            else
            {
                MessageBox.Show("Phục hồi thất bại!");
            }
            // Refresh the DataGridView by reloading the data
            backupTableLoad();
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
 