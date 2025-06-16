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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTimeRestore = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTimeRestore.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.backupBtn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backupBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.backupBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.backupBtn.Appearance.Options.UseBackColor = true;
            this.backupBtn.Appearance.Options.UseBorderColor = true;
            this.backupBtn.Appearance.Options.UseFont = true;
            this.backupBtn.Appearance.Options.UseForeColor = true;
            this.backupBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.backupBtn.AppearanceHovered.Options.UseBackColor = true;
            this.backupBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.backupBtn.AppearancePressed.Options.UseBackColor = true;
            this.backupBtn.Location = new System.Drawing.Point(742, 10);
            this.backupBtn.Margin = new System.Windows.Forms.Padding(10);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(168, 41);
            this.backupBtn.TabIndex = 2;
            this.backupBtn.Text = "🔒 Sao lưu dữ liệu";
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.returnBtn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.returnBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.returnBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19)))));
            this.returnBtn.Appearance.Options.UseBackColor = true;
            this.returnBtn.Appearance.Options.UseBorderColor = true;
            this.returnBtn.Appearance.Options.UseFont = true;
            this.returnBtn.Appearance.Options.UseForeColor = true;
            this.returnBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.returnBtn.AppearanceHovered.Options.UseBackColor = true;
            this.returnBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.returnBtn.AppearancePressed.Options.UseBackColor = true;
            this.returnBtn.Location = new System.Drawing.Point(20, 15);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(10);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(120, 50);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "← Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.restoreBtn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restoreBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.restoreBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.restoreBtn.Appearance.Options.UseBackColor = true;
            this.restoreBtn.Appearance.Options.UseBorderColor = true;
            this.restoreBtn.Appearance.Options.UseFont = true;
            this.restoreBtn.Appearance.Options.UseForeColor = true;
            this.restoreBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.restoreBtn.AppearanceHovered.Options.UseBackColor = true;
            this.restoreBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.restoreBtn.AppearancePressed.Options.UseBackColor = true;
            this.restoreBtn.Location = new System.Drawing.Point(930, 10);
            this.restoreBtn.Margin = new System.Windows.Forms.Padding(10);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(256, 41);
            this.restoreBtn.TabIndex = 15;
            this.restoreBtn.Text = "🔄 Phục hồi về phiên bản đang chọn";
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // createDeviceBtn
            // 
            this.createDeviceBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.createDeviceBtn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.createDeviceBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.createDeviceBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19)))));
            this.createDeviceBtn.Appearance.Options.UseBackColor = true;
            this.createDeviceBtn.Appearance.Options.UseBorderColor = true;
            this.createDeviceBtn.Appearance.Options.UseFont = true;
            this.createDeviceBtn.Appearance.Options.UseForeColor = true;
            this.createDeviceBtn.AppearanceDisabled.BackColor = System.Drawing.Color.LightGray;
            this.createDeviceBtn.AppearanceDisabled.BackColor2 = System.Drawing.Color.LightGray;
            this.createDeviceBtn.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.createDeviceBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.createDeviceBtn.AppearanceDisabled.Options.UseFont = true;
            this.createDeviceBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.createDeviceBtn.AppearanceHovered.Options.UseBackColor = true;
            this.createDeviceBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.createDeviceBtn.AppearancePressed.Options.UseBackColor = true;
            this.createDeviceBtn.Location = new System.Drawing.Point(25, 40);
            this.createDeviceBtn.Margin = new System.Windows.Forms.Padding(15);
            this.createDeviceBtn.Name = "createDeviceBtn";
            this.createDeviceBtn.Size = new System.Drawing.Size(180, 50);
            this.createDeviceBtn.TabIndex = 16;
            this.createDeviceBtn.Text = "💾 Tạo device sao lưu";
            this.createDeviceBtn.Click += new System.EventHandler(this.createDeviceBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.createDeviceBtn);
            this.groupControl1.Location = new System.Drawing.Point(20, 20);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(230, 120);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "🔧 Quản lý Device";
            // 
            // sp_DanhSachBackUpDataGridView
            // 
            this.sp_DanhSachBackUpDataGridView.AllowUserToAddRows = false;
            this.sp_DanhSachBackUpDataGridView.AllowUserToDeleteRows = false;
            this.sp_DanhSachBackUpDataGridView.AutoGenerateColumns = false;
            this.sp_DanhSachBackUpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_DanhSachBackUpDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sp_DanhSachBackUpDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sp_DanhSachBackUpDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sp_DanhSachBackUpDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_DanhSachBackUpDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sp_DanhSachBackUpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_DanhSachBackUpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sp_DanhSachBackUpDataGridView.DataSource = this.sp_DanhSachBackUpBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sp_DanhSachBackUpDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.sp_DanhSachBackUpDataGridView.EnableHeadersVisualStyles = false;
            this.sp_DanhSachBackUpDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(203)))));
            this.sp_DanhSachBackUpDataGridView.Location = new System.Drawing.Point(20, 20);
            this.sp_DanhSachBackUpDataGridView.Margin = new System.Windows.Forms.Padding(20);
            this.sp_DanhSachBackUpDataGridView.MultiSelect = false;
            this.sp_DanhSachBackUpDataGridView.Name = "sp_DanhSachBackUpDataGridView";
            this.sp_DanhSachBackUpDataGridView.ReadOnly = true;
            this.sp_DanhSachBackUpDataGridView.RowHeadersVisible = false;
            this.sp_DanhSachBackUpDataGridView.RowHeadersWidth = 51;
            this.sp_DanhSachBackUpDataGridView.RowTemplate.Height = 35;
            this.sp_DanhSachBackUpDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sp_DanhSachBackUpDataGridView.Size = new System.Drawing.Size(1140, 320);
            this.sp_DanhSachBackUpDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "backup_finish_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "📅 Ngày sao lưu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "backup_size_mb";
            this.dataGridViewTextBoxColumn3.HeaderText = "📏 Kích thước (MB)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "physical_device_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "💾 Thiết bị sao lưu";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "backed_up_by";
            this.dataGridViewTextBoxColumn8.HeaderText = "👤 Người sao lưu";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
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
            this.checkEdit1.Location = new System.Drawing.Point(20, 20);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(20);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "🗑️ Xóa bản sao lưu cũ trước khi sao lưu bản mới";
            this.checkEdit1.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.checkEdit1.Size = new System.Drawing.Size(400, 22);
            this.checkEdit1.TabIndex = 20;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(743, 57);
            this.checkEdit2.Margin = new System.Windows.Forms.Padding(20);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.checkEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit2.Properties.Caption = "⏰ Khôi phục theo thời gian chỉ định";
            this.checkEdit2.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.checkEdit2.Size = new System.Drawing.Size(350, 23);
            this.checkEdit2.TabIndex = 21;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(271, 25);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(150, 25);
            this.dtpDate.TabIndex = 22;
            // 
            // lblTime
            // 
            this.lblTime.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTime.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTime.Appearance.Options.UseFont = true;
            this.lblTime.Appearance.Options.UseForeColor = true;
            this.lblTime.Location = new System.Drawing.Point(20, 30);
            this.lblTime.Margin = new System.Windows.Forms.Padding(20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(241, 19);
            this.lblTime.TabIndex = 23;
            this.lblTime.Text = "📅 Chọn thời điểm muốn khôi phục:";
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(427, 25);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(10);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(150, 25);
            this.dtpTime.TabIndex = 24;
            // 
            // restoreWithTimeBtn
            // 
            this.restoreWithTimeBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.restoreWithTimeBtn.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.restoreWithTimeBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.restoreWithTimeBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19)))));
            this.restoreWithTimeBtn.Appearance.Options.UseBackColor = true;
            this.restoreWithTimeBtn.Appearance.Options.UseBorderColor = true;
            this.restoreWithTimeBtn.Appearance.Options.UseFont = true;
            this.restoreWithTimeBtn.Appearance.Options.UseForeColor = true;
            this.restoreWithTimeBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.restoreWithTimeBtn.AppearanceHovered.Options.UseBackColor = true;
            this.restoreWithTimeBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.restoreWithTimeBtn.AppearancePressed.Options.UseBackColor = true;
            this.restoreWithTimeBtn.Location = new System.Drawing.Point(590, 20);
            this.restoreWithTimeBtn.Margin = new System.Windows.Forms.Padding(10);
            this.restoreWithTimeBtn.Name = "restoreWithTimeBtn";
            this.restoreWithTimeBtn.Size = new System.Drawing.Size(200, 40);
            this.restoreWithTimeBtn.TabIndex = 25;
            this.restoreWithTimeBtn.Text = "✅ Xác nhận khôi phục";
            this.restoreWithTimeBtn.Click += new System.EventHandler(this.restoreWithTimeBtn_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.returnBtn);
            this.panelHeader.Controls.Add(this.backupBtn);
            this.panelHeader.Controls.Add(this.restoreBtn);
            this.panelHeader.Controls.Add(this.checkEdit2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1206, 85);
            this.panelHeader.TabIndex = 26;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Location = new System.Drawing.Point(211, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 25);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "🔐 HỆ THỐNG SAO LƯU VÀ PHỤC HỒI DỮ LIỆU";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelMain.Controls.Add(this.sp_DanhSachBackUpDataGridView);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 85);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1206, 360);
            this.panelMain.TabIndex = 27;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.panelTimeRestore);
            this.panelBottom.Controls.Add(this.panelOptions);
            this.panelBottom.Controls.Add(this.groupControl1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 445);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1206, 183);
            this.panelBottom.TabIndex = 28;
            // 
            // panelTimeRestore
            // 
            this.panelTimeRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.panelTimeRestore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimeRestore.Controls.Add(this.lblTime);
            this.panelTimeRestore.Controls.Add(this.dtpDate);
            this.panelTimeRestore.Controls.Add(this.dtpTime);
            this.panelTimeRestore.Controls.Add(this.restoreWithTimeBtn);
            this.panelTimeRestore.Location = new System.Drawing.Point(270, 100);
            this.panelTimeRestore.Margin = new System.Windows.Forms.Padding(20);
            this.panelTimeRestore.Name = "panelTimeRestore";
            this.panelTimeRestore.Size = new System.Drawing.Size(820, 70);
            this.panelTimeRestore.TabIndex = 29;
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOptions.Controls.Add(this.checkEdit1);
            this.panelOptions.Location = new System.Drawing.Point(270, 20);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(20);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(820, 70);
            this.panelOptions.TabIndex = 30;
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 628);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BackupRestoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Sao lưu và Phục hồi Dữ liệu - Quản lý Vật tư";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTimeRestore.ResumeLayout(false);
            this.panelTimeRestore.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelHeader;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTimeRestore;
        private System.Windows.Forms.Panel panelOptions;
    }
}