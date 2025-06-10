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
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.NhanvienTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.nhanvienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.nhanvienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.nhanvienDataGridView.Location = new System.Drawing.Point(0, 119);
            this.nhanvienDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.nhanvienDataGridView.MultiSelect = false;
            this.nhanvienDataGridView.Name = "nhanvienDataGridView";
            this.nhanvienDataGridView.RowHeadersWidth = 51;
            this.nhanvienDataGridView.Size = new System.Drawing.Size(1401, 295);
            this.nhanvienDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MANV";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.dataGridViewTextBoxColumn3.HeaderText = "HO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn4.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn6.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LUONG";
            this.dataGridViewTextBoxColumn7.HeaderText = "LUONG";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn8.HeaderText = "GHICHU";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(24, 55);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(256, 55);
            this.reloadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(100, 28);
            this.reloadBtn.TabIndex = 17;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(390, 55);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 28);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Ghi";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(530, 55);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(100, 28);
            this.undoBtn.TabIndex = 19;
            this.undoBtn.Text = "Undo";
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Appearance.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Appearance.Options.UseBackColor = true;
            this.deleteBtn.Location = new System.Drawing.Point(1196, 53);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(205, 28);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Xóa nhân viên đang chọn";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // labelMANV
            // 
            this.labelMANV.AutoSize = true;
            this.labelMANV.Location = new System.Drawing.Point(319, 443);
            this.labelMANV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMANV.Name = "labelMANV";
            this.labelMANV.Size = new System.Drawing.Size(86, 16);
            this.labelMANV.TabIndex = 21;
            this.labelMANV.Text = "Mã nhân viên";
            // 
            // labelCMND
            // 
            this.labelCMND.AutoSize = true;
            this.labelCMND.Location = new System.Drawing.Point(768, 446);
            this.labelCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCMND.Name = "labelCMND";
            this.labelCMND.Size = new System.Drawing.Size(47, 16);
            this.labelCMND.TabIndex = 22;
            this.labelCMND.Text = "CMND";
            // 
            // labelHO
            // 
            this.labelHO.AutoSize = true;
            this.labelHO.Location = new System.Drawing.Point(323, 490);
            this.labelHO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHO.Name = "labelHO";
            this.labelHO.Size = new System.Drawing.Size(25, 16);
            this.labelHO.TabIndex = 23;
            this.labelHO.Text = "Họ";
            // 
            // labelTEN
            // 
            this.labelTEN.AutoSize = true;
            this.labelTEN.Location = new System.Drawing.Point(772, 493);
            this.labelTEN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTEN.Name = "labelTEN";
            this.labelTEN.Size = new System.Drawing.Size(31, 16);
            this.labelTEN.TabIndex = 24;
            this.labelTEN.Text = "Tên";
            // 
            // labelNGAYSINH
            // 
            this.labelNGAYSINH.AutoSize = true;
            this.labelNGAYSINH.Location = new System.Drawing.Point(323, 537);
            this.labelNGAYSINH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNGAYSINH.Name = "labelNGAYSINH";
            this.labelNGAYSINH.Size = new System.Drawing.Size(67, 16);
            this.labelNGAYSINH.TabIndex = 25;
            this.labelNGAYSINH.Text = "Ngày sinh";
            // 
            // labelLUONG
            // 
            this.labelLUONG.AutoSize = true;
            this.labelLUONG.Location = new System.Drawing.Point(772, 541);
            this.labelLUONG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLUONG.Name = "labelLUONG";
            this.labelLUONG.Size = new System.Drawing.Size(44, 16);
            this.labelLUONG.TabIndex = 26;
            this.labelLUONG.Text = "Lương";
            // 
            // labelGHICHU
            // 
            this.labelGHICHU.AutoSize = true;
            this.labelGHICHU.Location = new System.Drawing.Point(323, 595);
            this.labelGHICHU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGHICHU.Name = "labelGHICHU";
            this.labelGHICHU.Size = new System.Drawing.Size(51, 16);
            this.labelGHICHU.TabIndex = 27;
            this.labelGHICHU.Text = "Ghi chú";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(617, 629);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(157, 30);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "THÊM NHÂN VIÊN";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // manvInput
            // 
            this.manvInput.Location = new System.Drawing.Point(444, 440);
            this.manvInput.Margin = new System.Windows.Forms.Padding(4);
            this.manvInput.Name = "manvInput";
            this.manvInput.Size = new System.Drawing.Size(186, 22);
            this.manvInput.TabIndex = 29;
            // 
            // cmndInput
            // 
            this.cmndInput.EditValue = "";
            this.cmndInput.Location = new System.Drawing.Point(856, 443);
            this.cmndInput.Margin = new System.Windows.Forms.Padding(4);
            this.cmndInput.Name = "cmndInput";
            this.cmndInput.Properties.MaxLength = 12;
            this.cmndInput.Size = new System.Drawing.Size(165, 22);
            this.cmndInput.TabIndex = 30;
            this.cmndInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmndInput_KeyPress);
            // 
            // hoInput
            // 
            this.hoInput.Location = new System.Drawing.Point(444, 490);
            this.hoInput.Margin = new System.Windows.Forms.Padding(4);
            this.hoInput.Name = "hoInput";
            this.hoInput.Size = new System.Drawing.Size(186, 22);
            this.hoInput.TabIndex = 31;
            this.hoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoInput_KeyPress);
            // 
            // tenInput
            // 
            this.tenInput.Location = new System.Drawing.Point(856, 490);
            this.tenInput.Margin = new System.Windows.Forms.Padding(4);
            this.tenInput.Name = "tenInput";
            this.tenInput.Size = new System.Drawing.Size(165, 22);
            this.tenInput.TabIndex = 32;
            this.tenInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenInput_KeyPress);
            // 
            // ghichuInput
            // 
            this.ghichuInput.Location = new System.Drawing.Point(444, 587);
            this.ghichuInput.Margin = new System.Windows.Forms.Padding(4);
            this.ghichuInput.Name = "ghichuInput";
            this.ghichuInput.Size = new System.Drawing.Size(186, 22);
            this.ghichuInput.TabIndex = 35;
            // 
            // ngaysinhInput
            // 
            this.ngaysinhInput.EditValue = null;
            this.ngaysinhInput.Location = new System.Drawing.Point(444, 535);
            this.ngaysinhInput.Margin = new System.Windows.Forms.Padding(4);
            this.ngaysinhInput.Name = "ngaysinhInput";
            this.ngaysinhInput.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinhInput.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinhInput.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngaysinhInput.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ngaysinhInput.Properties.MaskSettings.Set("mask", "dd/MM/yyy");
            this.ngaysinhInput.Size = new System.Drawing.Size(186, 22);
            this.ngaysinhInput.TabIndex = 36;
            this.ngaysinhInput.EditValueChanged += new System.EventHandler(this.ngaysinhInput_EditValueChanged);
            // 
            // luongInput
            // 
            this.luongInput.Location = new System.Drawing.Point(856, 538);
            this.luongInput.Margin = new System.Windows.Forms.Padding(4);
            this.luongInput.Name = "luongInput";
            this.luongInput.Properties.DisplayFormat.FormatString = "n3";
            this.luongInput.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.luongInput.Properties.EditFormat.FormatString = "n3";
            this.luongInput.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.luongInput.Size = new System.Drawing.Size(165, 22);
            this.luongInput.TabIndex = 37;
            // 
            // nhanVienReportBtn
            // 
            this.nhanVienReportBtn.Location = new System.Drawing.Point(937, 53);
            this.nhanVienReportBtn.Name = "nhanVienReportBtn";
            this.nhanVienReportBtn.Size = new System.Drawing.Size(229, 29);
            this.nhanVienReportBtn.TabIndex = 40;
            this.nhanVienReportBtn.Text = "In danh sách nhân viên";
            this.nhanVienReportBtn.Click += new System.EventHandler(this.nhanVienReportBtn_Click);
            // 
            // diachiInput
            // 
            this.diachiInput.Location = new System.Drawing.Point(856, 584);
            this.diachiInput.Margin = new System.Windows.Forms.Padding(4);
            this.diachiInput.Name = "diachiInput";
            this.diachiInput.Properties.DisplayFormat.FormatString = "n3";
            this.diachiInput.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.diachiInput.Properties.EditFormat.FormatString = "n3";
            this.diachiInput.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.diachiInput.Size = new System.Drawing.Size(165, 22);
            this.diachiInput.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 587);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Địa chỉ";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diachiInput);
            this.Controls.Add(this.nhanVienReportBtn);
            this.Controls.Add(this.luongInput);
            this.Controls.Add(this.ngaysinhInput);
            this.Controls.Add(this.ghichuInput);
            this.Controls.Add(this.tenInput);
            this.Controls.Add(this.hoInput);
            this.Controls.Add(this.cmndInput);
            this.Controls.Add(this.manvInput);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.labelGHICHU);
            this.Controls.Add(this.labelLUONG);
            this.Controls.Add(this.labelNGAYSINH);
            this.Controls.Add(this.labelTEN);
            this.Controls.Add(this.labelHO);
            this.Controls.Add(this.labelCMND);
            this.Controls.Add(this.labelMANV);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nhanvienDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.Text = "Form1";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DevExpress.XtraEditors.TextEdit diachiInput;
        private System.Windows.Forms.Label label1;
    }
}