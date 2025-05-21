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
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.vattuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vattuComboBox = new System.Windows.Forms.ComboBox();
            this.soLuongEditor = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTDDHTableAdapter();
            this.createBtn = new DevExpress.XtraEditors.SimpleButton();
            this.donGiaEditor = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.danhSachDatHang = new System.Windows.Forms.DataGridView();
            this.MAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienEditor = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nhaccEditor = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.maddhEditor = new DevExpress.XtraEditors.TextEdit();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.DatHangTableAdapter();
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
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(85, 29);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Quay lại";
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
            this.vattuComboBox.FormattingEnabled = true;
            this.vattuComboBox.Location = new System.Drawing.Point(140, 68);
            this.vattuComboBox.Name = "vattuComboBox";
            this.vattuComboBox.Size = new System.Drawing.Size(297, 24);
            this.vattuComboBox.TabIndex = 2;
            this.vattuComboBox.ValueMember = "MAVT";
            // 
            // soLuongEditor
            // 
            this.soLuongEditor.EditValue = "1";
            this.soLuongEditor.Location = new System.Drawing.Point(140, 116);
            this.soLuongEditor.Name = "soLuongEditor";
            this.soLuongEditor.Size = new System.Drawing.Size(191, 22);
            this.soLuongEditor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn vật tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng";
            // 
            // dVTTextEdit
            // 
            this.dVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource1, "DVT", true));
            this.dVTTextEdit.Enabled = false;
            this.dVTTextEdit.Location = new System.Drawing.Point(347, 116);
            this.dVTTextEdit.Name = "dVTTextEdit";
            this.dVTTextEdit.Size = new System.Drawing.Size(90, 22);
            this.dVTTextEdit.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(208, 202);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(191, 29);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Thêm sản phẩm";
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
            this.createBtn.Location = new System.Drawing.Point(80, 591);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(319, 79);
            this.createBtn.TabIndex = 8;
            this.createBtn.Text = "Tạo đơn đặt hàng";
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // donGiaEditor
            // 
            this.donGiaEditor.EditValue = "0";
            this.donGiaEditor.Location = new System.Drawing.Point(140, 160);
            this.donGiaEditor.Name = "donGiaEditor";
            this.donGiaEditor.Size = new System.Drawing.Size(191, 22);
            this.donGiaEditor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn giá";
            // 
            // danhSachDatHang
            // 
            this.danhSachDatHang.AllowUserToAddRows = false;
            this.danhSachDatHang.AllowUserToDeleteRows = false;
            this.danhSachDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVT,
            this.TENVT,
            this.SOLUONG,
            this.DONGIA});
            this.danhSachDatHang.Location = new System.Drawing.Point(537, 13);
            this.danhSachDatHang.MultiSelect = false;
            this.danhSachDatHang.Name = "danhSachDatHang";
            this.danhSachDatHang.RowHeadersWidth = 51;
            this.danhSachDatHang.RowTemplate.Height = 24;
            this.danhSachDatHang.Size = new System.Drawing.Size(714, 657);
            this.danhSachDatHang.TabIndex = 11;
            // 
            // MAVT
            // 
            this.MAVT.HeaderText = "MAVT";
            this.MAVT.MinimumWidth = 6;
            this.MAVT.Name = "MAVT";
            this.MAVT.ReadOnly = true;
            // 
            // TENVT
            // 
            this.TENVT.HeaderText = "TENVT";
            this.TENVT.MinimumWidth = 6;
            this.TENVT.Name = "TENVT";
            this.TENVT.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "SOLUONG";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "DONGIA";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            // 
            // tongTienEditor
            // 
            this.tongTienEditor.EditValue = "";
            this.tongTienEditor.Enabled = false;
            this.tongTienEditor.Location = new System.Drawing.Point(208, 551);
            this.tongTienEditor.Name = "tongTienEditor";
            this.tongTienEditor.Size = new System.Drawing.Size(191, 22);
            this.tongTienEditor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Người tạo đơn";
            // 
            // userTextEdit
            // 
            this.userTextEdit.EditValue = "";
            this.userTextEdit.Enabled = false;
            this.userTextEdit.Location = new System.Drawing.Point(208, 495);
            this.userTextEdit.Name = "userTextEdit";
            this.userTextEdit.Size = new System.Drawing.Size(191, 22);
            this.userTextEdit.TabIndex = 14;
            // 
            // createDatePicker
            // 
            this.createDatePicker.Enabled = false;
            this.createDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createDatePicker.Location = new System.Drawing.Point(208, 447);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(191, 22);
            this.createDatePicker.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày tạo đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nhà cung cấp";
            // 
            // nhaccEditor
            // 
            this.nhaccEditor.EditValue = "";
            this.nhaccEditor.Location = new System.Drawing.Point(208, 398);
            this.nhaccEditor.Name = "nhaccEditor";
            this.nhaccEditor.Size = new System.Drawing.Size(191, 22);
            this.nhaccEditor.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã ddh";
            // 
            // maddhEditor
            // 
            this.maddhEditor.EditValue = "";
            this.maddhEditor.Enabled = false;
            this.maddhEditor.Location = new System.Drawing.Point(208, 351);
            this.maddhEditor.Name = "maddhEditor";
            this.maddhEditor.Size = new System.Drawing.Size(191, 22);
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
            // FormTaoDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 758);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maddhEditor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nhaccEditor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userTextEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tongTienEditor);
            this.Controls.Add(this.danhSachDatHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.donGiaEditor);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dVTTextEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soLuongEditor);
            this.Controls.Add(this.vattuComboBox);
            this.Controls.Add(this.backBtn);
            this.Name = "FormTaoDDH";
            this.Text = "FormTaoDDH";
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit dVTTextEdit;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private qlvtDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraEditors.SimpleButton createBtn;
        private DevExpress.XtraEditors.TextEdit donGiaEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView danhSachDatHang;
        private DevExpress.XtraEditors.TextEdit tongTienEditor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit userTextEdit;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit nhaccEditor;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit maddhEditor;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private qlvtDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
    }
}