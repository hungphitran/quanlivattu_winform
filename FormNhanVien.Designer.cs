namespace quanlyvattu
{
    partial class FormNhanVien
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
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.NhanvienTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.nhanvienDataGridView = new System.Windows.Forms.DataGridView();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.reloadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.undoBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelMANV = new System.Windows.Forms.Label();
            this.labelCMND = new System.Windows.Forms.Label();
            this.labelHO = new System.Windows.Forms.Label();
            this.labelTEN = new System.Windows.Forms.Label();
            this.labelNGAYSINH = new System.Windows.Forms.Label();
            this.labelLUONG = new System.Windows.Forms.Label();
            this.labelGHICHU = new System.Windows.Forms.Label();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.manvInput = new DevExpress.XtraEditors.TextEdit();
            this.cmndInput = new DevExpress.XtraEditors.TextEdit();
            this.hoInput = new DevExpress.XtraEditors.TextEdit();
            this.tenInput = new DevExpress.XtraEditors.TextEdit();
            this.ghichuInput = new DevExpress.XtraEditors.TextEdit();
            this.ngaysinhInput = new DevExpress.XtraEditors.DateEdit();
            this.luongInput = new DevExpress.XtraEditors.TextEdit();
            this.nhanVienReportBtn = new DevExpress.XtraEditors.SimpleButton();
            this.diachiInput = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchInput = new DevExpress.XtraEditors.TextEdit();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxWorkInfo = new System.Windows.Forms.GroupBox();
            this.labelNoResult = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manvInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmndInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhInput.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiInput.Properties)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.groupBoxPersonalInfo.SuspendLayout();
            this.groupBoxWorkInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "Nhanvien";
            this.nhanvienBindingSource.DataSource = this.qlvtDataSet;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = this.nhanvienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanvienDataGridView
            // 
            this.nhanvienDataGridView.AllowUserToAddRows = false;
            this.nhanvienDataGridView.AllowUserToDeleteRows = false;
            this.nhanvienDataGridView.AllowUserToOrderColumns = true;
            this.nhanvienDataGridView.AutoGenerateColumns = false;
            this.nhanvienDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhanvienDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.nhanvienDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhanvienDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.nhanvienDataGridView.ColumnHeadersHeight = 40;
            this.nhanvienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.nhanvienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.nhanvienDataGridView.DataSource = this.nhanvienBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nhanvienDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.nhanvienDataGridView.EnableHeadersVisualStyles = false;
            this.nhanvienDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.nhanvienDataGridView.Location = new System.Drawing.Point(15, 196);
            this.nhanvienDataGridView.Margin = new System.Windows.Forms.Padding(27, 25, 27, 12);
            this.nhanvienDataGridView.MultiSelect = false;
            this.nhanvienDataGridView.Name = "nhanvienDataGridView";
            this.nhanvienDataGridView.RowHeadersVisible = false;
            this.nhanvienDataGridView.RowHeadersWidth = 51;
            this.nhanvienDataGridView.RowTemplate.Height = 35;
            this.nhanvienDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhanvienDataGridView.Size = new System.Drawing.Size(1893, 394);
            this.nhanvienDataGridView.TabIndex = 2;
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
            this.backBtn.Location = new System.Drawing.Point(40, 25);
            this.backBtn.Margin = new System.Windows.Forms.Padding(5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(160, 43);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "◄ Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.reloadBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.reloadBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.reloadBtn.Appearance.Options.UseBackColor = true;
            this.reloadBtn.Appearance.Options.UseFont = true;
            this.reloadBtn.Appearance.Options.UseForeColor = true;
            this.reloadBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.reloadBtn.AppearanceHovered.Options.UseBackColor = true;
            this.reloadBtn.Location = new System.Drawing.Point(227, 25);
            this.reloadBtn.Margin = new System.Windows.Forms.Padding(5);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(160, 43);
            this.reloadBtn.TabIndex = 17;
            this.reloadBtn.Text = "🔄 Reload";
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Appearance.Options.UseBackColor = true;
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Appearance.Options.UseForeColor = true;
            this.saveBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(67)))));
            this.saveBtn.AppearanceHovered.Options.UseBackColor = true;
            this.saveBtn.Location = new System.Drawing.Point(413, 25);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(160, 43);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "💾 Ghi";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.undoBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.undoBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.undoBtn.Appearance.Options.UseBackColor = true;
            this.undoBtn.Appearance.Options.UseFont = true;
            this.undoBtn.Appearance.Options.UseForeColor = true;
            this.undoBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(57)))));
            this.undoBtn.AppearanceHovered.Options.UseBackColor = true;
            this.undoBtn.Location = new System.Drawing.Point(600, 25);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(5);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(160, 43);
            this.undoBtn.TabIndex = 19;
            this.undoBtn.Text = "↶ Undo";
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.deleteBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Appearance.Options.UseBackColor = true;
            this.deleteBtn.Appearance.Options.UseFont = true;
            this.deleteBtn.Appearance.Options.UseForeColor = true;
            this.deleteBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.deleteBtn.AppearanceHovered.Options.UseBackColor = true;
            this.deleteBtn.Location = new System.Drawing.Point(1693, 25);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(267, 43);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "🗑️ Xóa nhân viên đang chọn";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // labelMANV
            // 
            this.labelMANV.AutoSize = true;
            this.labelMANV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMANV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelMANV.Location = new System.Drawing.Point(40, 43);
            this.labelMANV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMANV.Name = "labelMANV";
            this.labelMANV.Size = new System.Drawing.Size(100, 20);
            this.labelMANV.TabIndex = 21;
            this.labelMANV.Text = "Mã nhân viên:";
            // 
            // labelCMND
            // 
            this.labelCMND.AutoSize = true;
            this.labelCMND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelCMND.Location = new System.Drawing.Point(467, 43);
            this.labelCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCMND.Name = "labelCMND";
            this.labelCMND.Size = new System.Drawing.Size(56, 20);
            this.labelCMND.TabIndex = 22;
            this.labelCMND.Text = "CMND:";
            // 
            // labelHO
            // 
            this.labelHO.AutoSize = true;
            this.labelHO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelHO.Location = new System.Drawing.Point(40, 92);
            this.labelHO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHO.Name = "labelHO";
            this.labelHO.Size = new System.Drawing.Size(32, 20);
            this.labelHO.TabIndex = 23;
            this.labelHO.Text = "Họ:";
            // 
            // labelTEN
            // 
            this.labelTEN.AutoSize = true;
            this.labelTEN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTEN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelTEN.Location = new System.Drawing.Point(467, 92);
            this.labelTEN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTEN.Name = "labelTEN";
            this.labelTEN.Size = new System.Drawing.Size(35, 20);
            this.labelTEN.TabIndex = 24;
            this.labelTEN.Text = "Tên:";
            // 
            // labelNGAYSINH
            // 
            this.labelNGAYSINH.AutoSize = true;
            this.labelNGAYSINH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNGAYSINH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelNGAYSINH.Location = new System.Drawing.Point(467, 142);
            this.labelNGAYSINH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNGAYSINH.Name = "labelNGAYSINH";
            this.labelNGAYSINH.Size = new System.Drawing.Size(77, 20);
            this.labelNGAYSINH.TabIndex = 25;
            this.labelNGAYSINH.Text = "Ngày sinh:";
            // 
            // labelLUONG
            // 
            this.labelLUONG.AutoSize = true;
            this.labelLUONG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLUONG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelLUONG.Location = new System.Drawing.Point(40, 43);
            this.labelLUONG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLUONG.Name = "labelLUONG";
            this.labelLUONG.Size = new System.Drawing.Size(54, 20);
            this.labelLUONG.TabIndex = 26;
            this.labelLUONG.Text = "Lương:";
            // 
            // labelGHICHU
            // 
            this.labelGHICHU.AutoSize = true;
            this.labelGHICHU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGHICHU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelGHICHU.Location = new System.Drawing.Point(40, 92);
            this.labelGHICHU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGHICHU.Name = "labelGHICHU";
            this.labelGHICHU.Size = new System.Drawing.Size(61, 20);
            this.labelGHICHU.TabIndex = 27;
            this.labelGHICHU.Text = "Ghi chú:";
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
            this.addBtn.Location = new System.Drawing.Point(1627, 98);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(267, 55);
            this.addBtn.TabIndex = 29;
            this.addBtn.Text = "➕ Thêm nhân viên mới";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // manvInput
            // 
            this.manvInput.Location = new System.Drawing.Point(187, 39);
            this.manvInput.Margin = new System.Windows.Forms.Padding(5);
            this.manvInput.Name = "manvInput";
            this.manvInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manvInput.Properties.Appearance.Options.UseFont = true;
            this.manvInput.Size = new System.Drawing.Size(240, 26);
            this.manvInput.TabIndex = 30;
            // 
            // cmndInput
            // 
            this.cmndInput.Location = new System.Drawing.Point(613, 39);
            this.cmndInput.Margin = new System.Windows.Forms.Padding(5);
            this.cmndInput.Name = "cmndInput";
            this.cmndInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmndInput.Properties.Appearance.Options.UseFont = true;
            this.cmndInput.Size = new System.Drawing.Size(240, 26);
            this.cmndInput.TabIndex = 31;
            // 
            // hoInput
            // 
            this.hoInput.Location = new System.Drawing.Point(187, 89);
            this.hoInput.Margin = new System.Windows.Forms.Padding(5);
            this.hoInput.Name = "hoInput";
            this.hoInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hoInput.Properties.Appearance.Options.UseFont = true;
            this.hoInput.Size = new System.Drawing.Size(240, 26);
            this.hoInput.TabIndex = 32;
            // 
            // tenInput
            // 
            this.tenInput.Location = new System.Drawing.Point(613, 89);
            this.tenInput.Margin = new System.Windows.Forms.Padding(5);
            this.tenInput.Name = "tenInput";
            this.tenInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tenInput.Properties.Appearance.Options.UseFont = true;
            this.tenInput.Size = new System.Drawing.Size(240, 26);
            this.tenInput.TabIndex = 33;
            // 
            // ghichuInput
            // 
            this.ghichuInput.Location = new System.Drawing.Point(187, 89);
            this.ghichuInput.Margin = new System.Windows.Forms.Padding(5);
            this.ghichuInput.Name = "ghichuInput";
            this.ghichuInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ghichuInput.Properties.Appearance.Options.UseFont = true;
            this.ghichuInput.Size = new System.Drawing.Size(333, 26);
            this.ghichuInput.TabIndex = 34;
            // 
            // ngaysinhInput
            // 
            this.ngaysinhInput.EditValue = null;
            this.ngaysinhInput.Location = new System.Drawing.Point(613, 138);
            this.ngaysinhInput.Margin = new System.Windows.Forms.Padding(5);
            this.ngaysinhInput.Name = "ngaysinhInput";
            this.ngaysinhInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngaysinhInput.Properties.Appearance.Options.UseFont = true;
            this.ngaysinhInput.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinhInput.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinhInput.Size = new System.Drawing.Size(240, 26);
            this.ngaysinhInput.TabIndex = 35;
            // 
            // luongInput
            // 
            this.luongInput.Location = new System.Drawing.Point(187, 39);
            this.luongInput.Margin = new System.Windows.Forms.Padding(5);
            this.luongInput.Name = "luongInput";
            this.luongInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.luongInput.Properties.Appearance.Options.UseFont = true;
            this.luongInput.Size = new System.Drawing.Size(333, 26);
            this.luongInput.TabIndex = 36;
            // 
            // nhanVienReportBtn
            // 
            this.nhanVienReportBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(16)))), ((int)(((byte)(242)))));
            this.nhanVienReportBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nhanVienReportBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.nhanVienReportBtn.Appearance.Options.UseBackColor = true;
            this.nhanVienReportBtn.Appearance.Options.UseFont = true;
            this.nhanVienReportBtn.Appearance.Options.UseForeColor = true;
            this.nhanVienReportBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(13)))), ((int)(((byte)(200)))));
            this.nhanVienReportBtn.AppearanceHovered.Options.UseBackColor = true;
            this.nhanVienReportBtn.Location = new System.Drawing.Point(1400, 25);
            this.nhanVienReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nhanVienReportBtn.Name = "nhanVienReportBtn";
            this.nhanVienReportBtn.Size = new System.Drawing.Size(267, 43);
            this.nhanVienReportBtn.TabIndex = 40;
            this.nhanVienReportBtn.Text = "📄 In danh sách nhân viên";
            this.nhanVienReportBtn.Click += new System.EventHandler(this.nhanVienReportBtn_Click);
            // 
            // diachiInput
            // 
            this.diachiInput.Location = new System.Drawing.Point(187, 138);
            this.diachiInput.Margin = new System.Windows.Forms.Padding(5);
            this.diachiInput.Name = "diachiInput";
            this.diachiInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.diachiInput.Properties.Appearance.Options.UseFont = true;
            this.diachiInput.Size = new System.Drawing.Size(240, 26);
            this.diachiInput.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(40, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Địa chỉ:";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1924, 98);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(27, 25);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(433, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.searchBtn);
            this.controlPanel.Controls.Add(this.searchInput);
            this.controlPanel.Controls.Add(this.backBtn);
            this.controlPanel.Controls.Add(this.reloadBtn);
            this.controlPanel.Controls.Add(this.saveBtn);
            this.controlPanel.Controls.Add(this.undoBtn);
            this.controlPanel.Controls.Add(this.nhanVienReportBtn);
            this.controlPanel.Controls.Add(this.deleteBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 98);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1924, 86);
            this.controlPanel.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.searchBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.searchBtn.Appearance.Options.UseBackColor = true;
            this.searchBtn.Appearance.Options.UseFont = true;
            this.searchBtn.Appearance.Options.UseForeColor = true;
            this.searchBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(57)))));
            this.searchBtn.AppearanceHovered.Options.UseBackColor = true;
            this.searchBtn.Location = new System.Drawing.Point(1139, 27);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(125, 38);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(837, 36);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4);
            this.searchInput.Name = "searchInput";
            this.searchInput.Properties.NullValuePrompt = "Nhập từ khóa tìm kiếm...";
            this.searchInput.Size = new System.Drawing.Size(248, 22);
            this.searchInput.TabIndex = 41;
            this.searchInput.EditValueChanged += new System.EventHandler(this.searchInput_EditValueChanged);
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Controls.Add(this.groupBoxPersonalInfo);
            this.inputPanel.Controls.Add(this.groupBoxWorkInfo);
            this.inputPanel.Controls.Add(this.addBtn);
            this.inputPanel.Location = new System.Drawing.Point(27, 628);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(1947, 308);
            this.inputPanel.TabIndex = 3;
            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxPersonalInfo.Controls.Add(this.labelMANV);
            this.groupBoxPersonalInfo.Controls.Add(this.manvInput);
            this.groupBoxPersonalInfo.Controls.Add(this.labelCMND);
            this.groupBoxPersonalInfo.Controls.Add(this.cmndInput);
            this.groupBoxPersonalInfo.Controls.Add(this.labelHO);
            this.groupBoxPersonalInfo.Controls.Add(this.hoInput);
            this.groupBoxPersonalInfo.Controls.Add(this.labelTEN);
            this.groupBoxPersonalInfo.Controls.Add(this.tenInput);
            this.groupBoxPersonalInfo.Controls.Add(this.labelNGAYSINH);
            this.groupBoxPersonalInfo.Controls.Add(this.ngaysinhInput);
            this.groupBoxPersonalInfo.Controls.Add(this.label1);
            this.groupBoxPersonalInfo.Controls.Add(this.diachiInput);
            this.groupBoxPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(40, 25);
            this.groupBoxPersonalInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            this.groupBoxPersonalInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(907, 209);
            this.groupBoxPersonalInfo.TabIndex = 50;
            this.groupBoxPersonalInfo.TabStop = false;
            this.groupBoxPersonalInfo.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // groupBoxWorkInfo
            // 
            this.groupBoxWorkInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxWorkInfo.Controls.Add(this.labelLUONG);
            this.groupBoxWorkInfo.Controls.Add(this.luongInput);
            this.groupBoxWorkInfo.Controls.Add(this.labelGHICHU);
            this.groupBoxWorkInfo.Controls.Add(this.ghichuInput);
            this.groupBoxWorkInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxWorkInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxWorkInfo.Location = new System.Drawing.Point(1000, 25);
            this.groupBoxWorkInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxWorkInfo.Name = "groupBoxWorkInfo";
            this.groupBoxWorkInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxWorkInfo.Size = new System.Drawing.Size(560, 209);
            this.groupBoxWorkInfo.TabIndex = 51;
            this.groupBoxWorkInfo.TabStop = false;
            this.groupBoxWorkInfo.Text = "THÔNG TIN CÔNG VIỆC";
            // 
            // labelNoResult
            // 
            this.labelNoResult.AutoSize = true;
            this.labelNoResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoResult.ForeColor = System.Drawing.Color.Red;
            this.labelNoResult.Location = new System.Drawing.Point(661, 402);
            this.labelNoResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoResult.Name = "labelNoResult";
            this.labelNoResult.Size = new System.Drawing.Size(428, 28);
            this.labelNoResult.TabIndex = 4;
            this.labelNoResult.Text = "Không tìm thấy nhân viên phù hợp với tìm kiếm";
            this.labelNoResult.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MÃ NV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn2.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn3.HeaderText = "HỌ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn4.HeaderText = "TÊN";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "ĐỊA CHỈ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn6.HeaderText = "NGÀY SINH";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LUONG";
            this.dataGridViewTextBoxColumn7.HeaderText = "LƯƠNG";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn8.HeaderText = "GHI CHÚ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.labelNoResult);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.nhanvienDataGridView);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manvInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmndInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghichuInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhInput.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinhInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diachiInput.Properties)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.groupBoxPersonalInfo.ResumeLayout(false);
            this.groupBoxPersonalInfo.PerformLayout();
            this.groupBoxWorkInfo.ResumeLayout(false);
            this.groupBoxWorkInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private qlvtDataSetTableAdapters.NhanvienTableAdapter nhanvienTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nhanvienDataGridView;
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private DevExpress.XtraEditors.SimpleButton reloadBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton undoBtn;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private System.Windows.Forms.Label labelMANV;
        private System.Windows.Forms.Label labelCMND;
        private System.Windows.Forms.Label labelHO;
        private System.Windows.Forms.Label labelTEN;
        private System.Windows.Forms.Label labelNGAYSINH;
        private System.Windows.Forms.Label labelLUONG;
        private System.Windows.Forms.Label labelGHICHU;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private DevExpress.XtraEditors.TextEdit manvInput;
        private DevExpress.XtraEditors.TextEdit cmndInput;
        private DevExpress.XtraEditors.TextEdit hoInput;
        private DevExpress.XtraEditors.TextEdit tenInput;
        private DevExpress.XtraEditors.TextEdit ghichuInput;
        private DevExpress.XtraEditors.DateEdit ngaysinhInput;
        private DevExpress.XtraEditors.TextEdit luongInput;
        private DevExpress.XtraEditors.SimpleButton nhanVienReportBtn;
        private DevExpress.XtraEditors.TextEdit diachiInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.GroupBox groupBoxWorkInfo;
        private DevExpress.XtraEditors.TextEdit searchInput;
        private DevExpress.XtraEditors.SimpleButton searchBtn;
        private System.Windows.Forms.Label labelNoResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}