namespace quanlyvattu
{
    partial class FormDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBut = new System.Windows.Forms.Button();
            this.notImportBtn = new DevExpress.XtraEditors.SimpleButton();
            this.importBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addDdhBtn = new DevExpress.XtraEditors.SimpleButton();
            this.qlvtDataSet1 = new quanlyvattu.qlvtDataSet();
            this.datHangTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTDDHTableAdapter();
            this.sp_BaoCaoDonDatHangChuaNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.sp_BaoCaoDonDatHangChuaNhapTableAdapter();
            this.cTDDHDataGridView = new System.Windows.Forms.DataGridView();
            this.masoDDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.checkDaNhap = new System.Windows.Forms.CheckBox();
            this.checkChuaNhap = new System.Windows.Forms.CheckBox();
            this.searchInput = new DevExpress.XtraEditors.TextEdit();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.labelNoResult = new System.Windows.Forms.Label();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.backBut.FlatAppearance.BorderSize = 0;
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.backBut.ForeColor = System.Drawing.Color.White;
            this.backBut.Location = new System.Drawing.Point(30, 20);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(120, 35);
            this.backBut.TabIndex = 4;
            this.backBut.Text = "◄ Quay lại";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // notImportBtn
            // 
            this.notImportBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(16)))), ((int)(((byte)(242)))));
            this.notImportBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.notImportBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.notImportBtn.Appearance.Options.UseBackColor = true;
            this.notImportBtn.Appearance.Options.UseFont = true;
            this.notImportBtn.Appearance.Options.UseForeColor = true;
            this.notImportBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(13)))), ((int)(((byte)(200)))));
            this.notImportBtn.AppearanceHovered.Options.UseBackColor = true;
            this.notImportBtn.Location = new System.Drawing.Point(510, 20);
            this.notImportBtn.Name = "notImportBtn";
            this.notImportBtn.Size = new System.Drawing.Size(191, 35);
            this.notImportBtn.TabIndex = 5;
            this.notImportBtn.Text = "📄 Đơn hàng chưa nhập";
            this.notImportBtn.Click += new System.EventHandler(this.notImportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.importBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.importBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.importBtn.Appearance.Options.UseBackColor = true;
            this.importBtn.Appearance.Options.UseFont = true;
            this.importBtn.Appearance.Options.UseForeColor = true;
            this.importBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(67)))));
            this.importBtn.AppearanceHovered.Options.UseBackColor = true;
            this.importBtn.Location = new System.Drawing.Point(370, 20);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(118, 35);
            this.importBtn.TabIndex = 6;
            this.importBtn.Text = "📦 Nhập hàng";
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // addDdhBtn
            // 
            this.addDdhBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addDdhBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addDdhBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.addDdhBtn.Appearance.Options.UseBackColor = true;
            this.addDdhBtn.Appearance.Options.UseFont = true;
            this.addDdhBtn.Appearance.Options.UseForeColor = true;
            this.addDdhBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.addDdhBtn.AppearanceHovered.Options.UseBackColor = true;
            this.addDdhBtn.Location = new System.Drawing.Point(170, 20);
            this.addDdhBtn.Name = "addDdhBtn";
            this.addDdhBtn.Size = new System.Drawing.Size(180, 35);
            this.addDdhBtn.TabIndex = 7;
            this.addDdhBtn.Text = "➕ Thêm đơn đặt hàng";
            this.addDdhBtn.Click += new System.EventHandler(this.addDdhBtn_Click);
            // 
            // qlvtDataSet1
            // 
            this.qlvtDataSet1.DataSetName = "qlvtDataSet";
            this.qlvtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.qlvtDataSet1;
            // 
            // datHangDataGridView
            // 
            this.datHangDataGridView.AllowUserToAddRows = false;
            this.datHangDataGridView.AllowUserToDeleteRows = false;
            this.datHangDataGridView.AutoGenerateColumns = false;
            this.datHangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datHangDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.datHangDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datHangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datHangDataGridView.ColumnHeadersHeight = 40;
            this.datHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.datHangDataGridView.DataSource = this.datHangBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datHangDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.datHangDataGridView.EnableHeadersVisualStyles = false;
            this.datHangDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.datHangDataGridView.Location = new System.Drawing.Point(10, 30);
            this.datHangDataGridView.MultiSelect = false;
            this.datHangDataGridView.Name = "datHangDataGridView";
            this.datHangDataGridView.ReadOnly = true;
            this.datHangDataGridView.RowHeadersVisible = false;
            this.datHangDataGridView.RowHeadersWidth = 51;
            this.datHangDataGridView.RowTemplate.Height = 35;
            this.datHangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datHangDataGridView.Size = new System.Drawing.Size(1189, 210);
            this.datHangDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasoDDH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NGAY";
            this.dataGridViewTextBoxColumn2.HeaderText = "NGAY";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NhaCC";
            this.dataGridViewTextBoxColumn3.HeaderText = "NhaCC";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn5.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK__CTDDH__MasoDDH__32E0915F";
            this.cTDDHBindingSource.DataSource = this.datHangBindingSource;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // sp_BaoCaoDonDatHangChuaNhapBindingSource
            // 
            this.sp_BaoCaoDonDatHangChuaNhapBindingSource.DataMember = "sp_BaoCaoDonDatHangChuaNhap";
            this.sp_BaoCaoDonDatHangChuaNhapBindingSource.DataSource = this.qlvtDataSet1;
            // 
            // sp_BaoCaoDonDatHangChuaNhapTableAdapter
            // 
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.ClearBeforeFill = true;
            // 
            // cTDDHDataGridView
            // 
            this.cTDDHDataGridView.AllowUserToAddRows = false;
            this.cTDDHDataGridView.AllowUserToDeleteRows = false;
            this.cTDDHDataGridView.AutoGenerateColumns = false;
            this.cTDDHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cTDDHDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cTDDHDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTDDHDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.cTDDHDataGridView.ColumnHeadersHeight = 40;
            this.cTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masoDDHDataGridViewTextBoxColumn,
            this.mAVTDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn});
            this.cTDDHDataGridView.DataSource = this.cTDDHBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cTDDHDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.cTDDHDataGridView.EnableHeadersVisualStyles = false;
            this.cTDDHDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cTDDHDataGridView.Location = new System.Drawing.Point(10, 30);
            this.cTDDHDataGridView.MultiSelect = false;
            this.cTDDHDataGridView.Name = "cTDDHDataGridView";
            this.cTDDHDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTDDHDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.cTDDHDataGridView.RowHeadersVisible = false;
            this.cTDDHDataGridView.RowHeadersWidth = 51;
            this.cTDDHDataGridView.RowTemplate.Height = 35;
            this.cTDDHDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cTDDHDataGridView.Size = new System.Drawing.Size(1189, 170);
            this.cTDDHDataGridView.TabIndex = 3;
            // 
            // masoDDHDataGridViewTextBoxColumn
            // 
            this.masoDDHDataGridViewTextBoxColumn.DataPropertyName = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn.HeaderText = "MasoDDH";
            this.masoDDHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masoDDHDataGridViewTextBoxColumn.Name = "masoDDHDataGridViewTextBoxColumn";
            this.masoDDHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAVTDataGridViewTextBoxColumn
            // 
            this.mAVTDataGridViewTextBoxColumn.DataPropertyName = "MAVT";
            this.mAVTDataGridViewTextBoxColumn.HeaderText = "MAVT";
            this.mAVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAVTDataGridViewTextBoxColumn.Name = "mAVTDataGridViewTextBoxColumn";
            this.mAVTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            this.dONGIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1266, 80);
            this.headerPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(521, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.checkDaNhap);
            this.controlPanel.Controls.Add(this.checkChuaNhap);
            this.controlPanel.Controls.Add(this.searchInput);
            this.controlPanel.Controls.Add(this.backBut);
            this.controlPanel.Controls.Add(this.addDdhBtn);
            this.controlPanel.Controls.Add(this.importBtn);
            this.controlPanel.Controls.Add(this.notImportBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 80);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1266, 70);
            this.controlPanel.TabIndex = 1;
            // 
            // checkDaNhap
            // 
            this.checkDaNhap.AutoSize = true;
            this.checkDaNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDaNhap.Location = new System.Drawing.Point(1149, 22);
            this.checkDaNhap.Name = "checkDaNhap";
            this.checkDaNhap.Size = new System.Drawing.Size(97, 27);
            this.checkDaNhap.TabIndex = 10;
            this.checkDaNhap.Text = "Đã nhập";
            this.checkDaNhap.UseVisualStyleBackColor = true;
            this.checkDaNhap.CheckedChanged += new System.EventHandler(this.checkDaNhap_CheckedChanged);
            // 
            // checkChuaNhap
            // 
            this.checkChuaNhap.AutoSize = true;
            this.checkChuaNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkChuaNhap.Location = new System.Drawing.Point(1014, 23);
            this.checkChuaNhap.Name = "checkChuaNhap";
            this.checkChuaNhap.Size = new System.Drawing.Size(116, 27);
            this.checkChuaNhap.TabIndex = 9;
            this.checkChuaNhap.Text = "Chưa nhập";
            this.checkChuaNhap.UseVisualStyleBackColor = true;
            this.checkChuaNhap.CheckedChanged += new System.EventHandler(this.checkChuaNhap_CheckedChanged);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(717, 23);
            this.searchInput.Name = "searchInput";
            this.searchInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Properties.Appearance.Options.UseFont = true;
            this.searchInput.Properties.NullValuePrompt = "Nhập từ khóa tìm kiếm...";
            this.searchInput.Size = new System.Drawing.Size(256, 32);
            this.searchInput.TabIndex = 8;
            this.searchInput.EditValueChanged += new System.EventHandler(this.searchInput_EditValueChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.groupBoxOrders);
            this.mainPanel.Controls.Add(this.groupBoxOrderDetails);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 150);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1266, 574);
            this.mainPanel.TabIndex = 0;
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.BackColor = System.Drawing.Color.White;
            this.groupBoxOrders.Controls.Add(this.labelNoResult);
            this.groupBoxOrders.Controls.Add(this.datHangDataGridView);
            this.groupBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxOrders.Location = new System.Drawing.Point(30, 20);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(1205, 260);
            this.groupBoxOrders.TabIndex = 0;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG";
            // groupBoxOrders
            this.groupBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // datHangDataGridView header font (bold)
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datHangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;

            // datHangDataGridView content font (regular)
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datHangDataGridView.DefaultCellStyle = dataGridViewCellStyle12;

            // cTDDHDataGridView header font (bold)
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTDDHDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;

            // cTDDHDataGridView content font (regular)
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTDDHDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            // 
            // labelNoResult
            // 
            this.labelNoResult.AutoSize = true;
            this.labelNoResult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoResult.Location = new System.Drawing.Point(475, 160);
            this.labelNoResult.Name = "labelNoResult";
            this.labelNoResult.Size = new System.Drawing.Size(286, 25);
            this.labelNoResult.TabIndex = 3;
            this.labelNoResult.Text = "Không tìm thấy thông tin tìm kiếm";
            this.labelNoResult.Visible = false;
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.BackColor = System.Drawing.Color.White;
            this.groupBoxOrderDetails.Controls.Add(this.cTDDHDataGridView);
            this.groupBoxOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(30, 300);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(1205, 220);
            this.groupBoxOrderDetails.TabIndex = 1;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "CHI TIẾT ĐƠN ĐẶT HÀNG";
            // 
            // FormDatHang
            // 
            this.ClientSize = new System.Drawing.Size(1266, 724);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "FormDatHang";
            this.Load += new System.EventHandler(this.FormDatHang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator datHangBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton datHangBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl datHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button backBtn;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNHACC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource datHangBindingSource1;
        private qlvtDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter1;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator datHangBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton datHangBindingSource1BindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl datHangGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton backbutton;
        private System.Windows.Forms.Button backBut;
        private DevExpress.XtraEditors.SimpleButton notImportBtn;
        private DevExpress.XtraEditors.SimpleButton importBtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private DevExpress.XtraEditors.SimpleButton addDdhBtn;
        private qlvtDataSet qlvtDataSet1;
        private qlvtDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private System.Windows.Forms.DataGridView datHangDataGridView;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private qlvtDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource sp_BaoCaoDonDatHangChuaNhapBindingSource;
        private qlvtDataSetTableAdapters.sp_BaoCaoDonDatHangChuaNhapTableAdapter sp_BaoCaoDonDatHangChuaNhapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView cTDDHDataGridView;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
        private DevExpress.XtraEditors.TextEdit searchInput;
        private System.Windows.Forms.Label labelNoResult;
        private System.Windows.Forms.CheckBox checkDaNhap;
        private System.Windows.Forms.CheckBox checkChuaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn masoDDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
    }
}