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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTDDHDataGridView = new System.Windows.Forms.DataGridView();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBut
            // 
            this.backBut.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.backBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBut.FlatAppearance.BorderSize = 0;
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
            this.notImportBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(102, 16, 242);
            this.notImportBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.notImportBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.notImportBtn.Appearance.Options.UseBackColor = true;
            this.notImportBtn.Appearance.Options.UseFont = true;
            this.notImportBtn.Appearance.Options.UseForeColor = true;
            this.notImportBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(85, 13, 200);
            this.notImportBtn.AppearanceHovered.Options.UseBackColor = true;
            this.notImportBtn.Location = new System.Drawing.Point(590, 20);
            this.notImportBtn.Name = "notImportBtn";
            this.notImportBtn.Size = new System.Drawing.Size(250, 35);
            this.notImportBtn.TabIndex = 5;
            this.notImportBtn.Text = "📄 Đơn hàng chưa nhập";
            this.notImportBtn.Click += new System.EventHandler(this.notImportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.importBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.importBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.importBtn.Appearance.Options.UseBackColor = true;
            this.importBtn.Appearance.Options.UseFont = true;
            this.importBtn.Appearance.Options.UseForeColor = true;
            this.importBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(20, 108, 67);
            this.importBtn.AppearanceHovered.Options.UseBackColor = true;
            this.importBtn.Location = new System.Drawing.Point(370, 20);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(200, 35);
            this.importBtn.TabIndex = 6;
            this.importBtn.Text = "📦 Nhập hàng";
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // addDdhBtn
            // 
            this.addDdhBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.addDdhBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addDdhBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.addDdhBtn.Appearance.Options.UseBackColor = true;
            this.addDdhBtn.Appearance.Options.UseFont = true;
            this.addDdhBtn.Appearance.Options.UseForeColor = true;
            this.addDdhBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(0, 86, 179);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datHangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datHangDataGridView.ColumnHeadersHeight = 40;
            this.datHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.datHangDataGridView.DataSource = this.datHangBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datHangDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.datHangDataGridView.EnableHeadersVisualStyles = false;
            this.datHangDataGridView.GridColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.datHangDataGridView.Location = new System.Drawing.Point(10, 30);
            this.datHangDataGridView.MultiSelect = false;
            this.datHangDataGridView.Name = "datHangDataGridView";
            this.datHangDataGridView.ReadOnly = true;
            this.datHangDataGridView.RowHeadersVisible = false;
            this.datHangDataGridView.RowHeadersWidth = 51;
            this.datHangDataGridView.RowTemplate.Height = 35;
            this.datHangDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datHangDataGridView.Size = new System.Drawing.Size(1080, 210);
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn9.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn8.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn7.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn6.HeaderText = "MasoDDH";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // cTDDHDataGridView
            // 
            this.cTDDHDataGridView.AllowUserToAddRows = false;
            this.cTDDHDataGridView.AllowUserToDeleteRows = false;
            this.cTDDHDataGridView.AutoGenerateColumns = false;
            this.cTDDHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cTDDHDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cTDDHDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTDDHDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cTDDHDataGridView.ColumnHeadersHeight = 40;
            this.cTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.cTDDHDataGridView.DataSource = this.cTDDHBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cTDDHDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.cTDDHDataGridView.EnableHeadersVisualStyles = false;
            this.cTDDHDataGridView.GridColor = System.Drawing.Color.FromArgb(233, 236, 239);
            this.cTDDHDataGridView.Location = new System.Drawing.Point(10, 30);
            this.cTDDHDataGridView.MultiSelect = false;
            this.cTDDHDataGridView.Name = "cTDDHDataGridView";
            this.cTDDHDataGridView.ReadOnly = true;
            this.cTDDHDataGridView.RowHeadersVisible = false;
            this.cTDDHDataGridView.RowHeadersWidth = 51;
            this.cTDDHDataGridView.RowTemplate.Height = 35;
            this.cTDDHDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cTDDHDataGridView.Size = new System.Drawing.Size(1080, 170);
            this.cTDDHDataGridView.TabIndex = 3;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1171, 80);
            this.headerPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(420, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.backBut);
            this.controlPanel.Controls.Add(this.addDdhBtn);
            this.controlPanel.Controls.Add(this.importBtn);
            this.controlPanel.Controls.Add(this.notImportBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 80);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1171, 70);
            this.controlPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.groupBoxOrders);
            this.mainPanel.Controls.Add(this.groupBoxOrderDetails);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 150);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1171, 574);
            this.mainPanel.TabIndex = 0;
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.BackColor = System.Drawing.Color.White;
            this.groupBoxOrders.Controls.Add(this.datHangDataGridView);
            this.groupBoxOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxOrders.Location = new System.Drawing.Point(30, 20);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(1100, 260);
            this.groupBoxOrders.TabIndex = 0;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG";
            // 
            // groupBoxOrderDetails
            // 
            this.groupBoxOrderDetails.BackColor = System.Drawing.Color.White;
            this.groupBoxOrderDetails.Controls.Add(this.cTDDHDataGridView);
            this.groupBoxOrderDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(30, 300);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(1100, 220);
            this.groupBoxOrderDetails.TabIndex = 1;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "CHI TIẾT ĐƠN ĐẶT HÀNG";
            // 
            // FormDatHang
            // 
            this.ClientSize = new System.Drawing.Size(1171, 724);
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
            this.mainPanel.ResumeLayout(false);
            this.groupBoxOrders.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView cTDDHDataGridView;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
    }
}