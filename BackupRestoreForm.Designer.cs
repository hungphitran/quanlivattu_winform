namespace quanlyvattu
{
    partial class BackupRestoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backupBtn = new DevExpress.XtraEditors.SimpleButton();
            this.returnBtn = new DevExpress.XtraEditors.SimpleButton();
            this.restoreBtn = new DevExpress.XtraEditors.SimpleButton();
            this.createDeviceBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sp_DanhSachBackUpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_DanhSachBackUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.sp_DanhSachBackUpTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.sp_DanhSachBackUpTableAdapter();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.restoreWithTimeBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(752, 17);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(158, 44);
            this.backupBtn.TabIndex = 2;
            this.backupBtn.Text = "Sao lưu dữ liệu";
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(27, 16);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(94, 44);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(944, 16);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(232, 44);
            this.restoreBtn.TabIndex = 15;
            this.restoreBtn.Text = "Phục hồi về phiên bản đang chọn";
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // createDeviceBtn
            // 
            this.createDeviceBtn.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.createDeviceBtn.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.createDeviceBtn.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9F);
            this.createDeviceBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.createDeviceBtn.AppearanceDisabled.Options.UseFont = true;
            this.createDeviceBtn.Location = new System.Drawing.Point(42, 83);
            this.createDeviceBtn.Name = "createDeviceBtn";
            this.createDeviceBtn.Size = new System.Drawing.Size(148, 44);
            this.createDeviceBtn.TabIndex = 16;
            this.createDeviceBtn.Text = "Tạo device sao lưu";
            this.createDeviceBtn.Click += new System.EventHandler(this.createDeviceBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.createDeviceBtn);
            this.groupControl1.Location = new System.Drawing.Point(3, 391);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(228, 217);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Tạo device";
            // 
            // sp_DanhSachBackUpDataGridView
            // 
            this.sp_DanhSachBackUpDataGridView.AutoGenerateColumns = false;
            this.sp_DanhSachBackUpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_DanhSachBackUpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_DanhSachBackUpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sp_DanhSachBackUpDataGridView.DataSource = this.sp_DanhSachBackUpBindingSource;
            this.sp_DanhSachBackUpDataGridView.Location = new System.Drawing.Point(3, 78);
            this.sp_DanhSachBackUpDataGridView.Name = "sp_DanhSachBackUpDataGridView";
            this.sp_DanhSachBackUpDataGridView.RowHeadersWidth = 51;
            this.sp_DanhSachBackUpDataGridView.RowTemplate.Height = 24;
            this.sp_DanhSachBackUpDataGridView.Size = new System.Drawing.Size(1198, 307);
            this.sp_DanhSachBackUpDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "backup_finish_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày sao lưu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "backup_size_mb";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kích thước";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "physical_device_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Thiết bị sao lưu";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "backed_up_by";
            this.dataGridViewTextBoxColumn8.HeaderText = "Người sao lưu";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // sp_DanhSachBackUpBindingSource
            // 
            this.sp_DanhSachBackUpBindingSource.DataMember = "sp_DanhSachBackUp";
            this.sp_DanhSachBackUpBindingSource.DataSource = this.qlvtDataSet;
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // sp_DanhSachBackUpTableAdapter
            // 
            this.sp_DanhSachBackUpTableAdapter.ClearBeforeFill = true;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(547, 409);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Xóa bản sao lưu cũ trước khi sao lưu bản mới";
            this.checkEdit1.Size = new System.Drawing.Size(317, 24);
            this.checkEdit1.TabIndex = 20;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(305, 26);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Khôi phục theo thời gian chỉ định";
            this.checkEdit2.Size = new System.Drawing.Size(323, 24);
            this.checkEdit2.TabIndex = 21;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(560, 496);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(133, 22);
            this.dtpDate.TabIndex = 22;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(348, 496);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(180, 16);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "Chọn thời điểm muốn khôi phục";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(713, 496);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(140, 22);
            this.dtpTime.TabIndex = 24;
            // 
            // restoreWithTimeBtn
            // 
            this.restoreWithTimeBtn.Location = new System.Drawing.Point(911, 488);
            this.restoreWithTimeBtn.Name = "restoreWithTimeBtn";
            this.restoreWithTimeBtn.Size = new System.Drawing.Size(194, 41);
            this.restoreWithTimeBtn.TabIndex = 25;
            this.restoreWithTimeBtn.Text = "Xác nhận khôi phục";
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 628);
            this.Controls.Add(this.restoreWithTimeBtn);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.sp_DanhSachBackUpDataGridView);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.backupBtn);
            this.Name = "BackupRestoreForm";
            this.Text = "BackupRestoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton backupBtn;
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource sp_DanhSachBackUpBindingSource;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevExpress.XtraEditors.SimpleButton returnBtn;
        private DevExpress.XtraEditors.SimpleButton restoreBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.SimpleButton createDeviceBtn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private qlvtDataSetTableAdapters.sp_DanhSachBackUpTableAdapter sp_DanhSachBackUpTableAdapter;
        private System.Windows.Forms.DataGridView sp_DanhSachBackUpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private DevExpress.XtraEditors.SimpleButton restoreWithTimeBtn;
    }
}