namespace quanlyvattu
{
    partial class FormTaoDDH
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
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.vattuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vattuComboBox = new System.Windows.Forms.ComboBox();
            this.soLuongEditor = new DevExpress.XtraEditors.TextEdit();
            this.dVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTDDHTableAdapter();
            this.createBtn = new DevExpress.XtraEditors.SimpleButton();
            this.donGiaEditor = new DevExpress.XtraEditors.TextEdit();
            this.danhSachDatHang = new System.Windows.Forms.DataGridView();
            this.MAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienEditor = new DevExpress.XtraEditors.TextEdit();
            this.userTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nhaccEditor = new DevExpress.XtraEditors.TextEdit();
            this.maddhEditor = new DevExpress.XtraEditors.TextEdit();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.DatHangTableAdapter();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.itemInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelVatTu = new System.Windows.Forms.Label();
            this.orderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.labelNguoiTao = new System.Windows.Forms.Label();
            this.labelNgayTao = new System.Windows.Forms.Label();
            this.labelNhaCC = new System.Windows.Forms.Label();
            this.labelMaDDH = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongTienEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaccEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maddhEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.itemInfoGroupBox.SuspendLayout();
            this.orderInfoGroupBox.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.qlvtDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1500, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(430, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TẠO ĐƠN ĐẶT HÀNG";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.backBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 80);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1500, 70);
            this.controlPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.summaryGroupBox);
            this.leftPanel.Controls.Add(this.itemInfoGroupBox);
            this.leftPanel.Controls.Add(this.orderInfoGroupBox);
            this.leftPanel.Controls.Add(this.createBtn);
            this.leftPanel.Location = new System.Drawing.Point(20, 170);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(20);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(500, 600);
            this.leftPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Controls.Add(this.danhSachDatHang);
            this.rightPanel.Location = new System.Drawing.Point(540, 170);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(20);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(940, 600);
            this.rightPanel.TabIndex = 3;
            // 
            // orderInfoGroupBox
            // 
            this.orderInfoGroupBox.BackColor = System.Drawing.Color.White;
            this.orderInfoGroupBox.Controls.Add(this.labelNguoiTao);
            this.orderInfoGroupBox.Controls.Add(this.labelNgayTao);
            this.orderInfoGroupBox.Controls.Add(this.labelNhaCC);
            this.orderInfoGroupBox.Controls.Add(this.labelMaDDH);
            this.orderInfoGroupBox.Controls.Add(this.userTextEdit);
            this.orderInfoGroupBox.Controls.Add(this.createDatePicker);
            this.orderInfoGroupBox.Controls.Add(this.nhaccEditor);
            this.orderInfoGroupBox.Controls.Add(this.maddhEditor);
            this.orderInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.orderInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.orderInfoGroupBox.Location = new System.Drawing.Point(20, 20);
            this.orderInfoGroupBox.Name = "orderInfoGroupBox";
            this.orderInfoGroupBox.Size = new System.Drawing.Size(460, 200);
            this.orderInfoGroupBox.TabIndex = 50;
            this.orderInfoGroupBox.TabStop = false;
            this.orderInfoGroupBox.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // itemInfoGroupBox
            // 
            this.itemInfoGroupBox.BackColor = System.Drawing.Color.White;
            this.itemInfoGroupBox.Controls.Add(this.labelDonGia);
            this.itemInfoGroupBox.Controls.Add(this.labelSoLuong);
            this.itemInfoGroupBox.Controls.Add(this.labelVatTu);
            this.itemInfoGroupBox.Controls.Add(this.vattuComboBox);
            this.itemInfoGroupBox.Controls.Add(this.soLuongEditor);
            this.itemInfoGroupBox.Controls.Add(this.dVTTextEdit);
            this.itemInfoGroupBox.Controls.Add(this.donGiaEditor);
            this.itemInfoGroupBox.Controls.Add(this.addBtn);
            this.itemInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.itemInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.itemInfoGroupBox.Location = new System.Drawing.Point(20, 240);
            this.itemInfoGroupBox.Name = "itemInfoGroupBox";
            this.itemInfoGroupBox.Size = new System.Drawing.Size(460, 200);
            this.itemInfoGroupBox.TabIndex = 51;
            this.itemInfoGroupBox.TabStop = false;
            this.itemInfoGroupBox.Text = "THÔNG TIN VẬT TƯ";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.BackColor = System.Drawing.Color.White;
            this.summaryGroupBox.Controls.Add(this.labelTongTien);
            this.summaryGroupBox.Controls.Add(this.tongTienEditor);
            this.summaryGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.summaryGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.summaryGroupBox.Location = new System.Drawing.Point(20, 460);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(460, 80);
            this.summaryGroupBox.TabIndex = 52;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "TỔNG KẾT";
            // 
            // backBtn
            // 
            this.backBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.backBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.backBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.backBtn.Appearance.Options.UseBackColor = true;
            this.backBtn.Appearance.Options.UseFont = true;
            this.backBtn.Appearance.Options.UseForeColor = true;
            this.backBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.backBtn.AppearanceHovered.Options.UseBackColor = true;
            this.backBtn.Location = new System.Drawing.Point(30, 20);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(120, 35);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "◄ Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // vattuBindingSource1
            // 
            this.vattuBindingSource1.DataMember = "Vattu";
            this.vattuBindingSource1.DataSource = this.qlvtDataSet;
            // 
            // vattuComboBox
            // 
            this.vattuComboBox.DataSource = this.vattuBindingSource1;
            this.vattuComboBox.DisplayMember = "TENVT";
            this.vattuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vattuComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vattuComboBox.FormattingEnabled = true;
            this.vattuComboBox.Location = new System.Drawing.Point(140, 35);
            this.vattuComboBox.Name = "vattuComboBox";
            this.vattuComboBox.Size = new System.Drawing.Size(300, 28);
            this.vattuComboBox.TabIndex = 2;
            this.vattuComboBox.ValueMember = "MAVT";
            // 
            // soLuongEditor
            // 
            this.soLuongEditor.EditValue = "1";
            this.soLuongEditor.Location = new System.Drawing.Point(140, 75);
            this.soLuongEditor.Name = "soLuongEditor";
            this.soLuongEditor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soLuongEditor.Properties.Appearance.Options.UseFont = true;
            this.soLuongEditor.Size = new System.Drawing.Size(150, 26);
            this.soLuongEditor.TabIndex = 3;
            // 
            // dVTTextEdit
            // 
            this.dVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource1, "DVT", true));
            this.dVTTextEdit.Enabled = false;
            this.dVTTextEdit.Location = new System.Drawing.Point(300, 75);
            this.dVTTextEdit.Name = "dVTTextEdit";
            this.dVTTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dVTTextEdit.Properties.Appearance.Options.UseFont = true;
            this.dVTTextEdit.Size = new System.Drawing.Size(140, 26);
            this.dVTTextEdit.TabIndex = 6;
            // 
            // donGiaEditor
            // 
            this.donGiaEditor.EditValue = "0";
            this.donGiaEditor.Location = new System.Drawing.Point(140, 115);
            this.donGiaEditor.Name = "donGiaEditor";
            this.donGiaEditor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.donGiaEditor.Properties.Appearance.Options.UseFont = true;
            this.donGiaEditor.Size = new System.Drawing.Size(300, 26);
            this.donGiaEditor.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.addBtn.Appearance.Options.UseBackColor = true;
            this.addBtn.Appearance.Options.UseFont = true;
            this.addBtn.Appearance.Options.UseForeColor = true;
            this.addBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.addBtn.AppearanceHovered.Options.UseBackColor = true;
            this.addBtn.Location = new System.Drawing.Point(140, 155);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(200, 35);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "➕ Thêm vật tư";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "CTDDH";
            this.cTDDHBindingSource.DataSource = this.qlvtDataSet;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // createBtn
            // 
            this.createBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.createBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.createBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.createBtn.Appearance.Options.UseBackColor = true;
            this.createBtn.Appearance.Options.UseFont = true;
            this.createBtn.Appearance.Options.UseForeColor = true;
            this.createBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(67)))));
            this.createBtn.AppearanceHovered.Options.UseBackColor = true;
            this.createBtn.Location = new System.Drawing.Point(20, 560);
            this.createBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(460, 35);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "📋 Tạo đơn đặt hàng";
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // danhSachDatHang
            // 
            this.danhSachDatHang.AllowUserToAddRows = false;
            this.danhSachDatHang.AllowUserToDeleteRows = false;
            this.danhSachDatHang.AllowUserToOrderColumns = true;
            this.danhSachDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachDatHang.BackgroundColor = System.Drawing.Color.White;
            this.danhSachDatHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachDatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.danhSachDatHang.ColumnHeadersHeight = 40;
            this.danhSachDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.danhSachDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVT,
            this.TENVT,
            this.SOLUONG,
            this.DONGIA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.danhSachDatHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.danhSachDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhSachDatHang.EnableHeadersVisualStyles = false;
            this.danhSachDatHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.danhSachDatHang.Location = new System.Drawing.Point(0, 0);
            this.danhSachDatHang.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.danhSachDatHang.MultiSelect = false;
            this.danhSachDatHang.Name = "danhSachDatHang";
            this.danhSachDatHang.RowHeadersVisible = false;
            this.danhSachDatHang.RowHeadersWidth = 51;
            this.danhSachDatHang.RowTemplate.Height = 35;
            this.danhSachDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhSachDatHang.Size = new System.Drawing.Size(940, 600);
            this.danhSachDatHang.TabIndex = 11;
            // 
            // MAVT
            // 
            this.MAVT.HeaderText = "MÃ VT";
            this.MAVT.MinimumWidth = 6;
            this.MAVT.Name = "MAVT";
            this.MAVT.ReadOnly = true;
            // 
            // TENVT
            // 
            this.TENVT.HeaderText = "TÊN VẬT TƯ";
            this.TENVT.MinimumWidth = 6;
            this.TENVT.Name = "TENVT";
            this.TENVT.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "SỐ LƯỢNG";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            // 
            // tongTienEditor
            // 
            this.tongTienEditor.EditValue = "";
            this.tongTienEditor.Enabled = false;
            this.tongTienEditor.Location = new System.Drawing.Point(140, 35);
            this.tongTienEditor.Name = "tongTienEditor";
            this.tongTienEditor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tongTienEditor.Properties.Appearance.Options.UseFont = true;
            this.tongTienEditor.Size = new System.Drawing.Size(300, 34);
            this.tongTienEditor.TabIndex = 12;
            // 
            // userTextEdit
            // 
            this.userTextEdit.EditValue = "";
            this.userTextEdit.Enabled = false;
            this.userTextEdit.Location = new System.Drawing.Point(140, 155);
            this.userTextEdit.Name = "userTextEdit";
            this.userTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userTextEdit.Properties.Appearance.Options.UseFont = true;
            this.userTextEdit.Size = new System.Drawing.Size(300, 26);
            this.userTextEdit.TabIndex = 14;
            // 
            // createDatePicker
            // 
            this.createDatePicker.Enabled = false;
            this.createDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createDatePicker.Location = new System.Drawing.Point(140, 115);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(300, 27);
            this.createDatePicker.TabIndex = 16;
            // 
            // nhaccEditor
            // 
            this.nhaccEditor.EditValue = "";
            this.nhaccEditor.Location = new System.Drawing.Point(140, 75);
            this.nhaccEditor.Name = "nhaccEditor";
            this.nhaccEditor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nhaccEditor.Properties.Appearance.Options.UseFont = true;
            this.nhaccEditor.Size = new System.Drawing.Size(300, 26);
            this.nhaccEditor.TabIndex = 18;
            // 
            // maddhEditor
            // 
            this.maddhEditor.EditValue = "";
            this.maddhEditor.Location = new System.Drawing.Point(140, 35);
            this.maddhEditor.Name = "maddhEditor";
            this.maddhEditor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maddhEditor.Properties.Appearance.Options.UseFont = true;
            this.maddhEditor.Size = new System.Drawing.Size(300, 26);
            this.maddhEditor.TabIndex = 20;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.qlvtDataSet;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // labelVatTu
            // 
            this.labelVatTu.AutoSize = true;
            this.labelVatTu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVatTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelVatTu.Location = new System.Drawing.Point(30, 40);
            this.labelVatTu.Name = "labelVatTu";
            this.labelVatTu.Size = new System.Drawing.Size(88, 20);
            this.labelVatTu.TabIndex = 21;
            this.labelVatTu.Text = "Chọn vật tư:";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelSoLuong.Location = new System.Drawing.Point(30, 80);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(72, 20);
            this.labelSoLuong.TabIndex = 22;
            this.labelSoLuong.Text = "Số lượng:";
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDonGia.Location = new System.Drawing.Point(30, 120);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(65, 20);
            this.labelDonGia.TabIndex = 23;
            this.labelDonGia.Text = "Đơn giá:";
            // 
            // labelMaDDH
            // 
            this.labelMaDDH.AutoSize = true;
            this.labelMaDDH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaDDH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelMaDDH.Location = new System.Drawing.Point(30, 40);
            this.labelMaDDH.Name = "labelMaDDH";
            this.labelMaDDH.Size = new System.Drawing.Size(100, 20);
            this.labelMaDDH.TabIndex = 24;
            this.labelMaDDH.Text = "Mã đơn hàng:";
            // 
            // labelNhaCC
            // 
            this.labelNhaCC.AutoSize = true;
            this.labelNhaCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelNhaCC.Location = new System.Drawing.Point(30, 80);
            this.labelNhaCC.Name = "labelNhaCC";
            this.labelNhaCC.Size = new System.Drawing.Size(103, 20);
            this.labelNhaCC.TabIndex = 25;
            this.labelNhaCC.Text = "Nhà cung cấp:";
            // 
            // labelNgayTao
            // 
            this.labelNgayTao.AutoSize = true;
            this.labelNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelNgayTao.Location = new System.Drawing.Point(30, 120);
            this.labelNgayTao.Name = "labelNgayTao";
            this.labelNgayTao.Size = new System.Drawing.Size(73, 20);
            this.labelNgayTao.TabIndex = 26;
            this.labelNgayTao.Text = "Ngày tạo:";
            // 
            // labelNguoiTao
            // 
            this.labelNguoiTao.AutoSize = true;
            this.labelNguoiTao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNguoiTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelNguoiTao.Location = new System.Drawing.Point(30, 160);
            this.labelNguoiTao.Name = "labelNguoiTao";
            this.labelNguoiTao.Size = new System.Drawing.Size(80, 20);
            this.labelNguoiTao.TabIndex = 27;
            this.labelNguoiTao.Text = "Người tạo:";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.labelTongTien.Location = new System.Drawing.Point(30, 40);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(108, 28);
            this.labelTongTien.TabIndex = 28;
            this.labelTongTien.Text = "Tổng tiền:";
            // 
            // FormTaoDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTaoDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.FormTaoDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tongTienEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaccEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maddhEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.itemInfoGroupBox.ResumeLayout(false);
            this.itemInfoGroupBox.PerformLayout();
            this.orderInfoGroupBox.ResumeLayout(false);
            this.orderInfoGroupBox.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private qlvtDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private System.Windows.Forms.BindingSource vattuBindingSource1;
        private System.Windows.Forms.ComboBox vattuComboBox;
        private DevExpress.XtraEditors.TextEdit soLuongEditor;
        private DevExpress.XtraEditors.TextEdit dVTTextEdit;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private qlvtDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraEditors.SimpleButton createBtn;
        private DevExpress.XtraEditors.TextEdit donGiaEditor;
        private System.Windows.Forms.DataGridView danhSachDatHang;
        private DevExpress.XtraEditors.TextEdit tongTienEditor;
        private DevExpress.XtraEditors.TextEdit userTextEdit;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private DevExpress.XtraEditors.TextEdit nhaccEditor;
        private DevExpress.XtraEditors.TextEdit maddhEditor;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private qlvtDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.GroupBox orderInfoGroupBox;
        private System.Windows.Forms.GroupBox itemInfoGroupBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label labelVatTu;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.Label labelMaDDH;
        private System.Windows.Forms.Label labelNhaCC;
        private System.Windows.Forms.Label labelNgayTao;
        private System.Windows.Forms.Label labelNguoiTao;
        private System.Windows.Forms.Label labelTongTien;
    }
}