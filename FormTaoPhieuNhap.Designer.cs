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
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.masoDDHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nhanvienEditor = new DevExpress.XtraEditors.TextEdit();
            this.maPNEditor = new DevExpress.XtraEditors.TextEdit();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.PhieuNhapTableAdapter();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTPNTableAdapter();
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
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(47, 218);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(77, 16);
            masoDDHLabel.TabIndex = 15;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 315);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 16);
            label1.TabIndex = 17;
            label1.Text = "Nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(47, 269);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 16);
            label2.TabIndex = 19;
            label2.Text = "Ngày nhập ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(47, 369);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 16);
            label3.TabIndex = 22;
            label3.Text = "Mã phiếu nhập";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(16, 13);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(109, 478);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(236, 38);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Xác nhận nhập hàng";
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
            this.datHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.datHangDataGridView.DataSource = this.datHangBindingSource;
            this.datHangDataGridView.Location = new System.Drawing.Point(12, 51);
            this.datHangDataGridView.Name = "datHangDataGridView";
            this.datHangDataGridView.ReadOnly = true;
            this.datHangDataGridView.RowHeadersWidth = 51;
            this.datHangDataGridView.RowTemplate.Height = 24;
            this.datHangDataGridView.Size = new System.Drawing.Size(1234, 75);
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
            this.cTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cTDDHDataGridView.DataSource = this.cTDDHBindingSource;
            this.cTDDHDataGridView.Location = new System.Drawing.Point(463, 132);
            this.cTDDHDataGridView.MultiSelect = false;
            this.cTDDHDataGridView.Name = "cTDDHDataGridView";
            this.cTDDHDataGridView.RowHeadersWidth = 51;
            this.cTDDHDataGridView.RowTemplate.Height = 24;
            this.cTDDHDataGridView.Size = new System.Drawing.Size(783, 539);
            this.cTDDHDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn5.HeaderText = "MasoDDH";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn6.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn7.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn8.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(155, 263);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker.TabIndex = 15;
            // 
            // masoDDHTextEdit
            // 
            this.masoDDHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MasoDDH", true));
            this.masoDDHTextEdit.Enabled = false;
            this.masoDDHTextEdit.Location = new System.Drawing.Point(155, 215);
            this.masoDDHTextEdit.Name = "masoDDHTextEdit";
            this.masoDDHTextEdit.Size = new System.Drawing.Size(236, 22);
            this.masoDDHTextEdit.TabIndex = 16;
            // 
            // nhanvienEditor
            // 
            this.nhanvienEditor.Enabled = false;
            this.nhanvienEditor.Location = new System.Drawing.Point(155, 315);
            this.nhanvienEditor.Name = "nhanvienEditor";
            this.nhanvienEditor.Size = new System.Drawing.Size(236, 22);
            this.nhanvienEditor.TabIndex = 20;
            // 
            // maPNEditor
            // 
            this.maPNEditor.Location = new System.Drawing.Point(155, 366);
            this.maPNEditor.Name = "maPNEditor";
            this.maPNEditor.Size = new System.Drawing.Size(236, 22);
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
            // FormTaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 836);
            this.Controls.Add(label3);
            this.Controls.Add(this.maPNEditor);
            this.Controls.Add(this.nhanvienEditor);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.masoDDHTextEdit);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cTDDHDataGridView);
            this.Controls.Add(this.datHangDataGridView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource sp_BaoCaoDonDatHangChuaNhapBindingSource;
        private qlvtDataSetTableAdapters.sp_BaoCaoDonDatHangChuaNhapTableAdapter sp_BaoCaoDonDatHangChuaNhapTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private qlvtDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private System.Windows.Forms.DataGridView datHangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private qlvtDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private System.Windows.Forms.DataGridView cTDDHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private DevExpress.XtraEditors.TextEdit masoDDHTextEdit;
        private DevExpress.XtraEditors.TextEdit nhanvienEditor;
        private DevExpress.XtraEditors.TextEdit maPNEditor;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private qlvtDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private qlvtDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
    }
}