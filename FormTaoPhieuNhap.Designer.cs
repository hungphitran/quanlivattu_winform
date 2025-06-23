namespace quanlyvattu
{
    partial class FormTaoPhieuNhap
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.sp_BaoCaoDonDatHangChuaNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.sp_BaoCaoDonDatHangChuaNhapTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTDDHTableAdapter();
            this.datHangTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.DatHangTableAdapter();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHDataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.masoDDHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nhanvienEditor = new DevExpress.XtraEditors.TextEdit();
            this.maPNEditor = new DevExpress.XtraEditors.TextEdit();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.PhieuNhapTableAdapter();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTPNTableAdapter();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.groupBoxOrderInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxReceiptInfo = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.VattuTableAdapter();
            this.dataGridViewTextBoxColumnTENVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            masoDDHLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPNEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.groupBoxOrderInfo.SuspendLayout();
            this.groupBoxReceiptInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(13, 22);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(88, 20);
            masoDDHLabel.TabIndex = 15;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 81);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 17;
            label1.Text = "Nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 52);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 20);
            label2.TabIndex = 19;
            label2.Text = "Ngày nhập ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 31);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 20);
            label3.TabIndex = 22;
            label3.Text = "Mã phiếu nhập";
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
            this.backBtn.Location = new System.Drawing.Point(12, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(90, 28);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "◄ Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.addBtn.Location = new System.Drawing.Point(178, 64);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(177, 37);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "➕ Xác nhận nhập hàng";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_BaoCaoDonDatHangChuaNhapBindingSource
            // 
            this.sp_BaoCaoDonDatHangChuaNhapBindingSource.DataMember = "sp_BaoCaoDonDatHangChuaNhap";
            this.sp_BaoCaoDonDatHangChuaNhapBindingSource.DataSource = this.qlvtDataSet;
            // 
            // sp_BaoCaoDonDatHangChuaNhapTableAdapter
            // 
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.qlvtDataSet;
            // 
            // datHangDataGridView
            // 
            this.datHangDataGridView.AllowUserToAddRows = false;
            this.datHangDataGridView.AllowUserToDeleteRows = false;
            this.datHangDataGridView.AutoGenerateColumns = false;
            this.datHangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datHangDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.datHangDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datHangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.datHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.datHangDataGridView.DataSource = this.datHangBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datHangDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.datHangDataGridView.EnableHeadersVisualStyles = false;
            this.datHangDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.datHangDataGridView.Location = new System.Drawing.Point(15, 107);
            this.datHangDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.datHangDataGridView.Name = "datHangDataGridView";
            this.datHangDataGridView.ReadOnly = true;
            this.datHangDataGridView.RowHeadersVisible = false;
            this.datHangDataGridView.RowHeadersWidth = 51;
            this.datHangDataGridView.RowTemplate.Height = 35;
            this.datHangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datHangDataGridView.Size = new System.Drawing.Size(922, 62);
            this.datHangDataGridView.TabIndex = 14;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn4.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "FK__CTDDH__MasoDDH__32E0915F";
            this.cTDDHBindingSource.DataSource = this.datHangBindingSource;
            // 
            // cTDDHDataGridView
            // 
            this.cTDDHDataGridView.AllowUserToAddRows = false;
            this.cTDDHDataGridView.AllowUserToDeleteRows = false;
            this.cTDDHDataGridView.AutoGenerateColumns = false;
            this.cTDDHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cTDDHDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cTDDHDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTDDHDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.cTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumnTENVT,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cTDDHDataGridView.DataSource = this.cTDDHBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cTDDHDataGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.cTDDHDataGridView.EnableHeadersVisualStyles = false;
            this.cTDDHDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.cTDDHDataGridView.Location = new System.Drawing.Point(15, 173);
            this.cTDDHDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.cTDDHDataGridView.MultiSelect = false;
            this.cTDDHDataGridView.Name = "cTDDHDataGridView";
            this.cTDDHDataGridView.RowHeadersVisible = false;
            this.cTDDHDataGridView.RowHeadersWidth = 51;
            this.cTDDHDataGridView.RowTemplate.Height = 35;
            this.cTDDHDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cTDDHDataGridView.Size = new System.Drawing.Size(922, 179);
            this.cTDDHDataGridView.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(122, 47);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(178, 27);
            this.dateTimePicker.TabIndex = 15;
            // 
            // masoDDHTextEdit
            // 
            this.masoDDHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MasoDDH", true));
            this.masoDDHTextEdit.Enabled = false;
            this.masoDDHTextEdit.Location = new System.Drawing.Point(122, 24);
            this.masoDDHTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.masoDDHTextEdit.Name = "masoDDHTextEdit";
            this.masoDDHTextEdit.Size = new System.Drawing.Size(177, 20);
            this.masoDDHTextEdit.TabIndex = 16;
            // 
            // nhanvienEditor
            // 
            this.nhanvienEditor.Enabled = false;
            this.nhanvienEditor.Location = new System.Drawing.Point(122, 84);
            this.nhanvienEditor.Margin = new System.Windows.Forms.Padding(2);
            this.nhanvienEditor.Name = "nhanvienEditor";
            this.nhanvienEditor.Size = new System.Drawing.Size(177, 20);
            this.nhanvienEditor.TabIndex = 20;
            // 
            // maPNEditor
            // 
            this.maPNEditor.Location = new System.Drawing.Point(178, 31);
            this.maPNEditor.Margin = new System.Windows.Forms.Padding(2);
            this.maPNEditor.Name = "maPNEditor";
            this.maPNEditor.Size = new System.Drawing.Size(177, 20);
            this.maPNEditor.TabIndex = 21;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qlvtDataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "CTPN";
            this.cTPNBindingSource.DataSource = this.qlvtDataSet;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(950, 65);
            this.headerPanel.TabIndex = 16;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(15, 16);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(397, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TẠO PHIẾU NHẬP HÀNG";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.backBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 65);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(950, 38);
            this.controlPanel.TabIndex = 15;
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Controls.Add(this.groupBoxOrderInfo);
            this.inputPanel.Controls.Add(this.groupBoxReceiptInfo);
            this.inputPanel.Location = new System.Drawing.Point(15, 365);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(2);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(922, 179);
            this.inputPanel.TabIndex = 0;
            // 
            // groupBoxOrderInfo
            // 
            this.groupBoxOrderInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxOrderInfo.Controls.Add(masoDDHLabel);
            this.groupBoxOrderInfo.Controls.Add(this.dateTimePicker);
            this.groupBoxOrderInfo.Controls.Add(this.masoDDHTextEdit);
            this.groupBoxOrderInfo.Controls.Add(label2);
            this.groupBoxOrderInfo.Controls.Add(this.nhanvienEditor);
            this.groupBoxOrderInfo.Controls.Add(label1);
            this.groupBoxOrderInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxOrderInfo.Location = new System.Drawing.Point(22, 16);
            this.groupBoxOrderInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            this.groupBoxOrderInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOrderInfo.Size = new System.Drawing.Size(435, 138);
            this.groupBoxOrderInfo.TabIndex = 0;
            this.groupBoxOrderInfo.TabStop = false;
            this.groupBoxOrderInfo.Text = "THÔNG TIN ĐƠN ĐẶT HÀNG";
            // 
            // groupBoxReceiptInfo
            // 
            this.groupBoxReceiptInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxReceiptInfo.Controls.Add(this.maPNEditor);
            this.groupBoxReceiptInfo.Controls.Add(this.addBtn);
            this.groupBoxReceiptInfo.Controls.Add(label3);
            this.groupBoxReceiptInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxReceiptInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxReceiptInfo.Location = new System.Drawing.Point(472, 16);
            this.groupBoxReceiptInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxReceiptInfo.Name = "groupBoxReceiptInfo";
            this.groupBoxReceiptInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxReceiptInfo.Size = new System.Drawing.Size(428, 138);
            this.groupBoxReceiptInfo.TabIndex = 1;
            this.groupBoxReceiptInfo.TabStop = false;
            this.groupBoxReceiptInfo.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn8.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn7.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn6.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn5.HeaderText = "MasoDDH";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            // dataGridViewTextBoxColumnTENVT
            // 
            this.dataGridViewTextBoxColumnTENVT.DataPropertyName = "TENVT";
            this.dataGridViewTextBoxColumnTENVT.HeaderText = "Tên vật tư";
            this.dataGridViewTextBoxColumnTENVT.MinimumWidth = 6;
            this.dataGridViewTextBoxColumnTENVT.Name = "dataGridViewTextBoxColumnTENVT";
            this.dataGridViewTextBoxColumnTENVT.ReadOnly = true;
            // 
            // FormTaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.cTDDHDataGridView);
            this.Controls.Add(this.datHangDataGridView);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTaoPhieuNhap";
            this.Text = "NhapVatTu";
            this.Load += new System.EventHandler(this.FormTaoPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPNEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.groupBoxOrderInfo.ResumeLayout(false);
            this.groupBoxOrderInfo.PerformLayout();
            this.groupBoxReceiptInfo.ResumeLayout(false);
            this.groupBoxReceiptInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource sp_BaoCaoDonDatHangChuaNhapBindingSource;
        private qlvtDataSetTableAdapters.sp_BaoCaoDonDatHangChuaNhapTableAdapter sp_BaoCaoDonDatHangChuaNhapTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private qlvtDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private qlvtDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private System.Windows.Forms.DataGridView datHangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private System.Windows.Forms.DataGridView cTDDHDataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private DevExpress.XtraEditors.TextEdit masoDDHTextEdit;
        private DevExpress.XtraEditors.TextEdit nhanvienEditor;
        private DevExpress.XtraEditors.TextEdit maPNEditor;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private qlvtDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private qlvtDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private DevExpress.XtraEditors.SimpleButton reloadBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton undoBtn;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.GroupBox groupBoxOrderInfo;
        private System.Windows.Forms.GroupBox groupBoxReceiptInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnTENVT;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private qlvtDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
    }
}