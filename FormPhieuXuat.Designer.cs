using System;

namespace quanlyvattu
{

    partial class FormPhieuXuat
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
        /// 

        private void phieuXuatDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Phương thức này được gọi mỗi khi người dùng chọn một dòng khác
            // trong bảng danh sách các phiếu xuất.
            // Do đã có data binding giữa phieuXuatBindingSource và cTPXBindingSource,
            // DataGridView chi tiết phiếu xuất (cTPXDataGridView) sẽ tự động được cập nhật.
            // Bạn có thể thêm logic khác ở đây nếu cần.
            if (phieuXuatBindingSource.Current == null)
            {
                return;
            }
        }

        private void vattuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Phương thức này được gọi khi người dùng chọn một vật tư khác từ ComboBox.
            // Do đã có data binding, TextBox mã vật tư (mAVTTextBox) sẽ tự động
            // cập nhật theo lựa chọn.
            // Bạn có thể thêm logic khác như lấy đơn giá mặc định ở đây.
            if (vattuComboBox.SelectedValue == null)
            {
                return;
            }
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.vattuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.phieuXuatDataGridView = new System.Windows.Forms.DataGridView();
            this.colMAPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHOTENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTOTALVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phieuXuatTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTPXTableAdapter();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.NhanvienTableAdapter();
            this.vattuTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.VattuTableAdapter();
            this.nhanvienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.phieuxuatTab = new DevExpress.XtraTab.XtraTabPage();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.reloadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cTPXDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuXuatDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctpxTab = new DevExpress.XtraTab.XtraTabPage();
            this.clearAllBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteVTbtn = new DevExpress.XtraEditors.SimpleButton();
            this.totalAmoutBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new DevExpress.XtraEditors.LabelControl();
            this.addPhieuXuatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.tempDataGridView = new System.Windows.Forms.DataGridView();
            this.MAVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addvattuBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dongiaInput = new DevExpress.XtraEditors.TextEdit();
            this.soluongInput = new DevExpress.XtraEditors.TextEdit();
            this.mAVTTextBox = new System.Windows.Forms.TextBox();
            this.vattuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vattuComboBox = new System.Windows.Forms.ComboBox();
            this.soluongLabel = new DevExpress.XtraEditors.LabelControl();
            this.dongiaLabel = new DevExpress.XtraEditors.LabelControl();
            this.tenvtLabel = new DevExpress.XtraEditors.LabelControl();
            this.inputPanel2 = new DevExpress.XtraEditors.PanelControl();
            this.ngayInput = new System.Windows.Forms.DateTimePicker();
            this.nvInput = new DevExpress.XtraEditors.TextEdit();
            this.hotenkhInput = new DevExpress.XtraEditors.TextEdit();
            this.mapxInput = new DevExpress.XtraEditors.TextEdit();
            this.manvLabel = new DevExpress.XtraEditors.LabelControl();
            this.hotenkhLabel = new DevExpress.XtraEditors.LabelControl();
            this.ngayLabel = new DevExpress.XtraEditors.LabelControl();
            this.mapxLabel = new DevExpress.XtraEditors.LabelControl();
            mAVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.phieuxuatTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatDataGridView1)).BeginInit();
            this.ctpxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPanel2)).BeginInit();
            this.inputPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotenkhInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapxInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.BackColor = System.Drawing.Color.Transparent;
            mAVTLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            mAVTLabel.Location = new System.Drawing.Point(316, 20);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(43, 15);
            mAVTLabel.TabIndex = 5;
            mAVTLabel.Text = "MAVT:";
            // 
            // cTPXBindingSource
            // 
            this.cTPXBindingSource.DataMember = "FK__CTPX__MAPX__46E78A0C";
            this.cTPXBindingSource.DataSource = this.phieuXuatBindingSource;
            // 
            // phieuXuatBindingSource
            // 
            this.phieuXuatBindingSource.DataMember = "PhieuXuat";
            this.phieuXuatBindingSource.DataSource = this.qlvtDataSet;
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.backBtn);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1228, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(468, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(248, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "QUẢN LÝ XUẤT KHO";
            // 
            // backBtn
            // 
            this.backBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.backBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.backBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backBtn.Appearance.Options.UseBackColor = true;
            this.backBtn.Appearance.Options.UseFont = true;
            this.backBtn.Appearance.Options.UseForeColor = true;
            this.backBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.backBtn.AppearanceHovered.Options.UseBackColor = true;
            this.backBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.backBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.backBtn.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.backBtn.Location = new System.Drawing.Point(15, 18);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 36);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // vattuBindingSource1
            // 
            this.vattuBindingSource1.DataMember = "Vattu";
            this.vattuBindingSource1.DataSource = this.qlvtDataSet;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            // 
            // phieuXuatDataGridView
            // 
            this.phieuXuatDataGridView.ColumnHeadersHeight = 29;
            this.phieuXuatDataGridView.Location = new System.Drawing.Point(0, 0);
            this.phieuXuatDataGridView.Name = "phieuXuatDataGridView";
            this.phieuXuatDataGridView.RowHeadersWidth = 51;
            this.phieuXuatDataGridView.Size = new System.Drawing.Size(240, 150);
            this.phieuXuatDataGridView.TabIndex = 0;
            // 
            // colMAPX
            // 
            this.colMAPX.MinimumWidth = 6;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Width = 125;
            // 
            // colNGAY
            // 
            this.colNGAY.MinimumWidth = 6;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Width = 125;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.MinimumWidth = 6;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Width = 125;
            // 
            // colMANV
            // 
            this.colMANV.MinimumWidth = 6;
            this.colMANV.Name = "colMANV";
            this.colMANV.Width = 125;
            // 
            // colTOTALVALUE
            // 
            this.colTOTALVALUE.MinimumWidth = 6;
            this.colTOTALVALUE.Name = "colTOTALVALUE";
            this.colTOTALVALUE.Width = 125;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.qlvtDataSet;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // nhanvienBindingSource1
            // 
            this.nhanvienBindingSource1.DataMember = "Nhanvien";
            this.nhanvienBindingSource1.DataSource = this.qlvtDataSet;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.xtraTabControl1.AppearancePage.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xtraTabControl1.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.White;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 70);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.phieuxuatTab;
            this.xtraTabControl1.Size = new System.Drawing.Size(1228, 668);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.phieuxuatTab,
            this.ctpxTab});
            // 
            // phieuxuatTab
            // 
            this.phieuxuatTab.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.phieuxuatTab.Appearance.PageClient.Options.UseBackColor = true;
            this.phieuxuatTab.AutoScroll = true;
            this.phieuxuatTab.Controls.Add(this.deleteBtn);
            this.phieuxuatTab.Controls.Add(this.saveBtn);
            this.phieuxuatTab.Controls.Add(this.reloadBtn);
            this.phieuxuatTab.Controls.Add(this.cTPXDataGridView);
            this.phieuxuatTab.Controls.Add(this.phieuXuatDataGridView1);
            this.phieuxuatTab.Name = "phieuxuatTab";
            this.phieuxuatTab.Size = new System.Drawing.Size(1226, 636);
            this.phieuxuatTab.Text = "Phiếu Xuất";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.deleteBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Appearance.Options.UseBackColor = true;
            this.deleteBtn.Appearance.Options.UseFont = true;
            this.deleteBtn.Appearance.Options.UseForeColor = true;
            this.deleteBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.AppearanceHovered.Options.UseBackColor = true;
            this.deleteBtn.Location = new System.Drawing.Point(728, 15);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 35);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Xóa";
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Appearance.Options.UseBackColor = true;
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Appearance.Options.UseForeColor = true;
            this.saveBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.saveBtn.AppearanceHovered.Options.UseBackColor = true;
            this.saveBtn.Location = new System.Drawing.Point(459, 15);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 35);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Lưu";
            // 
            // reloadBtn
            // 
            this.reloadBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.reloadBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.reloadBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reloadBtn.Appearance.Options.UseBackColor = true;
            this.reloadBtn.Appearance.Options.UseFont = true;
            this.reloadBtn.Appearance.Options.UseForeColor = true;
            this.reloadBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            this.reloadBtn.AppearanceHovered.Options.UseBackColor = true;
            this.reloadBtn.Location = new System.Drawing.Point(595, 15);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(90, 35);
            this.reloadBtn.TabIndex = 3;
            this.reloadBtn.Text = "Reload";
            // 
            // cTPXDataGridView
            // 
            this.cTPXDataGridView.AllowUserToAddRows = false;
            this.cTPXDataGridView.AllowUserToDeleteRows = false;
            this.cTPXDataGridView.AutoGenerateColumns = false;
            this.cTPXDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cTPXDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cTPXDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cTPXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cTPXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cTPXDataGridView.DataSource = this.cTPXBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cTPXDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cTPXDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cTPXDataGridView.Location = new System.Drawing.Point(25, 400);
            this.cTPXDataGridView.MultiSelect = false;
            this.cTPXDataGridView.Name = "cTPXDataGridView";
            this.cTPXDataGridView.ReadOnly = true;
            this.cTPXDataGridView.RowHeadersVisible = false;
            this.cTPXDataGridView.RowHeadersWidth = 51;
            this.cTPXDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cTPXDataGridView.Size = new System.Drawing.Size(1175, 220);
            this.cTPXDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAPX";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã Phiếu Xuất";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã Vật Tư";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn8.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // phieuXuatDataGridView1
            // 
            this.phieuXuatDataGridView1.AllowUserToAddRows = false;
            this.phieuXuatDataGridView1.AllowUserToDeleteRows = false;
            this.phieuXuatDataGridView1.AutoGenerateColumns = false;
            this.phieuXuatDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phieuXuatDataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phieuXuatDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.phieuXuatDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuXuatDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.phieuXuatDataGridView1.DataSource = this.phieuXuatBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.phieuXuatDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.phieuXuatDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phieuXuatDataGridView1.Location = new System.Drawing.Point(25, 70);
            this.phieuXuatDataGridView1.MultiSelect = false;
            this.phieuXuatDataGridView1.Name = "phieuXuatDataGridView1";
            this.phieuXuatDataGridView1.ReadOnly = true;
            this.phieuXuatDataGridView1.RowHeadersVisible = false;
            this.phieuXuatDataGridView1.RowHeadersWidth = 51;
            this.phieuXuatDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phieuXuatDataGridView1.Size = new System.Drawing.Size(1175, 300);
            this.phieuXuatDataGridView1.TabIndex = 1;
            this.phieuXuatDataGridView1.SelectionChanged += new System.EventHandler(this.phieuXuatDataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPX";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phiếu Xuất";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NGAY";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOTENKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ Tên Khách Hàng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ctpxTab
            // 
            this.ctpxTab.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ctpxTab.Appearance.PageClient.Options.UseBackColor = true;
            this.ctpxTab.AutoScroll = true;
            this.ctpxTab.Controls.Add(this.clearAllBtn);
            this.ctpxTab.Controls.Add(this.deleteVTbtn);
            this.ctpxTab.Controls.Add(this.totalAmoutBox);
            this.ctpxTab.Controls.Add(this.totalLabel);
            this.ctpxTab.Controls.Add(this.addPhieuXuatBtn);
            this.ctpxTab.Controls.Add(this.tempDataGridView);
            this.ctpxTab.Controls.Add(this.addvattuBtn);
            this.ctpxTab.Controls.Add(this.dongiaInput);
            this.ctpxTab.Controls.Add(this.soluongInput);
            this.ctpxTab.Controls.Add(mAVTLabel);
            this.ctpxTab.Controls.Add(this.mAVTTextBox);
            this.ctpxTab.Controls.Add(this.vattuComboBox);
            this.ctpxTab.Controls.Add(this.soluongLabel);
            this.ctpxTab.Controls.Add(this.dongiaLabel);
            this.ctpxTab.Controls.Add(this.tenvtLabel);
            this.ctpxTab.Controls.Add(this.inputPanel2);
            this.ctpxTab.Name = "ctpxTab";
            this.ctpxTab.Size = new System.Drawing.Size(1226, 636);
            this.ctpxTab.Text = "Tạo Phiếu Xuất";
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.clearAllBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.clearAllBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.clearAllBtn.Appearance.Options.UseBackColor = true;
            this.clearAllBtn.Appearance.Options.UseFont = true;
            this.clearAllBtn.Appearance.Options.UseForeColor = true;
            this.clearAllBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.clearAllBtn.AppearanceHovered.Options.UseBackColor = true;
            this.clearAllBtn.Location = new System.Drawing.Point(800, 300);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(120, 35);
            this.clearAllBtn.TabIndex = 15;
            this.clearAllBtn.Text = "Xóa Tất Cả";
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // deleteVTbtn
            // 
            this.deleteVTbtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.deleteVTbtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteVTbtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteVTbtn.Appearance.Options.UseBackColor = true;
            this.deleteVTbtn.Appearance.Options.UseFont = true;
            this.deleteVTbtn.Appearance.Options.UseForeColor = true;
            this.deleteVTbtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteVTbtn.AppearanceHovered.Options.UseBackColor = true;
            this.deleteVTbtn.Location = new System.Drawing.Point(670, 300);
            this.deleteVTbtn.Name = "deleteVTbtn";
            this.deleteVTbtn.Size = new System.Drawing.Size(120, 35);
            this.deleteVTbtn.TabIndex = 14;
            this.deleteVTbtn.Text = "Xóa Vật Tư";
            this.deleteVTbtn.Click += new System.EventHandler(this.deleteVTbtn_Click);
            // 
            // totalAmoutBox
            // 
            this.totalAmoutBox.BackColor = System.Drawing.Color.White;
            this.totalAmoutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmoutBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalAmoutBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalAmoutBox.Location = new System.Drawing.Point(540, 580);
            this.totalAmoutBox.Name = "totalAmoutBox";
            this.totalAmoutBox.ReadOnly = true;
            this.totalAmoutBox.Size = new System.Drawing.Size(200, 29);
            this.totalAmoutBox.TabIndex = 13;
            this.totalAmoutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalLabel
            // 
            this.totalLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.totalLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalLabel.Appearance.Options.UseFont = true;
            this.totalLabel.Appearance.Options.UseForeColor = true;
            this.totalLabel.Location = new System.Drawing.Point(388, 585);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(132, 21);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Tổng Tiền (VNĐ):";
            // 
            // addPhieuXuatBtn
            // 
            this.addPhieuXuatBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.addPhieuXuatBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.addPhieuXuatBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.addPhieuXuatBtn.Appearance.Options.UseBackColor = true;
            this.addPhieuXuatBtn.Appearance.Options.UseFont = true;
            this.addPhieuXuatBtn.Appearance.Options.UseForeColor = true;
            this.addPhieuXuatBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.addPhieuXuatBtn.AppearanceHovered.Options.UseBackColor = true;
            this.addPhieuXuatBtn.Location = new System.Drawing.Point(780, 575);
            this.addPhieuXuatBtn.Name = "addPhieuXuatBtn";
            this.addPhieuXuatBtn.Size = new System.Drawing.Size(150, 40);
            this.addPhieuXuatBtn.TabIndex = 11;
            this.addPhieuXuatBtn.Text = "Tạo Phiếu Xuất";
            this.addPhieuXuatBtn.Click += new System.EventHandler(this.addPhieuXuatBtn_Click);
            // 
            // tempDataGridView
            // 
            this.tempDataGridView.AllowUserToAddRows = false;
            this.tempDataGridView.AllowUserToDeleteRows = false;
            this.tempDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tempDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tempDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tempDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tempDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVT,
            this.TENVT,
            this.SOLUONG,
            this.DONGIA,
            this.THANHTIEN});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tempDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.tempDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tempDataGridView.Location = new System.Drawing.Point(25, 350);
            this.tempDataGridView.MultiSelect = false;
            this.tempDataGridView.Name = "tempDataGridView";
            this.tempDataGridView.ReadOnly = true;
            this.tempDataGridView.RowHeadersVisible = false;
            this.tempDataGridView.RowHeadersWidth = 51;
            this.tempDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tempDataGridView.Size = new System.Drawing.Size(1175, 220);
            this.tempDataGridView.TabIndex = 10;
            // 
            // MAVT
            // 
            this.MAVT.HeaderText = "Mã Vật Tư";
            this.MAVT.MinimumWidth = 6;
            this.MAVT.Name = "MAVT";
            this.MAVT.ReadOnly = true;
            // 
            // TENVT
            // 
            this.TENVT.HeaderText = "Tên Vật Tư";
            this.TENVT.MinimumWidth = 6;
            this.TENVT.Name = "TENVT";
            this.TENVT.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // addvattuBtn
            // 
            this.addvattuBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.addvattuBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addvattuBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.addvattuBtn.Appearance.Options.UseBackColor = true;
            this.addvattuBtn.Appearance.Options.UseFont = true;
            this.addvattuBtn.Appearance.Options.UseForeColor = true;
            this.addvattuBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.addvattuBtn.AppearanceHovered.Options.UseBackColor = true;
            this.addvattuBtn.Location = new System.Drawing.Point(540, 300);
            this.addvattuBtn.Name = "addvattuBtn";
            this.addvattuBtn.Size = new System.Drawing.Size(120, 35);
            this.addvattuBtn.TabIndex = 9;
            this.addvattuBtn.Text = "Thêm Vật Tư";
            this.addvattuBtn.Click += new System.EventHandler(this.addvattuBtn_Click);
            // 
            // dongiaInput
            // 
            this.dongiaInput.Location = new System.Drawing.Point(540, 240);
            this.dongiaInput.Name = "dongiaInput";
            this.dongiaInput.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dongiaInput.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dongiaInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dongiaInput.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dongiaInput.Properties.Appearance.Options.UseBackColor = true;
            this.dongiaInput.Properties.Appearance.Options.UseBorderColor = true;
            this.dongiaInput.Properties.Appearance.Options.UseFont = true;
            this.dongiaInput.Properties.Appearance.Options.UseForeColor = true;
            this.dongiaInput.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dongiaInput.Size = new System.Drawing.Size(200, 24);
            this.dongiaInput.TabIndex = 8;
            // 
            // soluongInput
            // 
            this.soluongInput.Location = new System.Drawing.Point(135, 240);
            this.soluongInput.Name = "soluongInput";
            this.soluongInput.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.soluongInput.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.soluongInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.soluongInput.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.soluongInput.Properties.Appearance.Options.UseBackColor = true;
            this.soluongInput.Properties.Appearance.Options.UseBorderColor = true;
            this.soluongInput.Properties.Appearance.Options.UseFont = true;
            this.soluongInput.Properties.Appearance.Options.UseForeColor = true;
            this.soluongInput.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.soluongInput.Size = new System.Drawing.Size(150, 24);
            this.soluongInput.TabIndex = 7;
            // 
            // mAVTTextBox
            // 
            this.mAVTTextBox.BackColor = System.Drawing.Color.White;
            this.mAVTTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mAVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vattuBindingSource2, "MAVT", true));
            this.mAVTTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mAVTTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mAVTTextBox.Location = new System.Drawing.Point(365, 18);
            this.mAVTTextBox.Name = "mAVTTextBox";
            this.mAVTTextBox.ReadOnly = true;
            this.mAVTTextBox.Size = new System.Drawing.Size(100, 25);
            this.mAVTTextBox.TabIndex = 6;
            // 
            // vattuBindingSource2
            // 
            this.vattuBindingSource2.DataMember = "Vattu";
            this.vattuBindingSource2.DataSource = this.qlvtDataSet;
            // 
            // vattuComboBox
            // 
            this.vattuComboBox.BackColor = System.Drawing.Color.White;
            this.vattuComboBox.DataSource = this.vattuBindingSource2;
            this.vattuComboBox.DisplayMember = "TENVT";
            this.vattuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vattuComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.vattuComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vattuComboBox.FormattingEnabled = true;
            this.vattuComboBox.Location = new System.Drawing.Point(540, 18);
            this.vattuComboBox.Name = "vattuComboBox";
            this.vattuComboBox.Size = new System.Drawing.Size(300, 25);
            this.vattuComboBox.TabIndex = 4;
            this.vattuComboBox.ValueMember = "MAVT";
            this.vattuComboBox.SelectedIndexChanged += new System.EventHandler(this.vattuComboBox_SelectedIndexChanged);
            // 
            // soluongLabel
            // 
            this.soluongLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.soluongLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.soluongLabel.Appearance.Options.UseFont = true;
            this.soluongLabel.Appearance.Options.UseForeColor = true;
            this.soluongLabel.Location = new System.Drawing.Point(135, 218);
            this.soluongLabel.Name = "soluongLabel";
            this.soluongLabel.Size = new System.Drawing.Size(56, 15);
            this.soluongLabel.TabIndex = 3;
            this.soluongLabel.Text = "Số Lượng:";
            // 
            // dongiaLabel
            // 
            this.dongiaLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dongiaLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dongiaLabel.Appearance.Options.UseFont = true;
            this.dongiaLabel.Appearance.Options.UseForeColor = true;
            this.dongiaLabel.Location = new System.Drawing.Point(0, 0);
            this.dongiaLabel.Name = "dongiaLabel";
            this.dongiaLabel.Size = new System.Drawing.Size(48, 15);
            this.dongiaLabel.TabIndex = 2;
            this.dongiaLabel.Text = "Đơn Giá:";
            // 
            // tenvtLabel
            // 
            this.tenvtLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tenvtLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tenvtLabel.Appearance.Options.UseFont = true;
            this.tenvtLabel.Appearance.Options.UseForeColor = true;
            this.tenvtLabel.Location = new System.Drawing.Point(471, 20);
            this.tenvtLabel.Name = "tenvtLabel";
            this.tenvtLabel.Size = new System.Drawing.Size(63, 15);
            this.tenvtLabel.TabIndex = 1;
            this.tenvtLabel.Text = "Tên Vật Tư:";
            // 
            // inputPanel2
            // 
            this.inputPanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.inputPanel2.Appearance.Options.UseBackColor = true;
            this.inputPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.inputPanel2.Controls.Add(this.ngayInput);
            this.inputPanel2.Controls.Add(this.nvInput);
            this.inputPanel2.Controls.Add(this.hotenkhInput);
            this.inputPanel2.Controls.Add(this.mapxInput);
            this.inputPanel2.Controls.Add(this.manvLabel);
            this.inputPanel2.Controls.Add(this.hotenkhLabel);
            this.inputPanel2.Controls.Add(this.ngayLabel);
            this.inputPanel2.Controls.Add(this.mapxLabel);
            this.inputPanel2.Location = new System.Drawing.Point(25, 60);
            this.inputPanel2.Name = "inputPanel2";
            this.inputPanel2.Size = new System.Drawing.Size(1175, 140);
            this.inputPanel2.TabIndex = 0;
            // 
            // ngayInput
            // 
            this.ngayInput.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ngayInput.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.ngayInput.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ngayInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ngayInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayInput.Location = new System.Drawing.Point(515, 20);
            this.ngayInput.Name = "ngayInput";
            this.ngayInput.Size = new System.Drawing.Size(200, 25);
            this.ngayInput.TabIndex = 7;
            // 
            // nvInput
            // 
            this.nvInput.Enabled = false;
            this.nvInput.Location = new System.Drawing.Point(515, 80);
            this.nvInput.Name = "nvInput";
            this.nvInput.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.nvInput.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nvInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nvInput.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nvInput.Properties.Appearance.Options.UseBackColor = true;
            this.nvInput.Properties.Appearance.Options.UseBorderColor = true;
            this.nvInput.Properties.Appearance.Options.UseFont = true;
            this.nvInput.Properties.Appearance.Options.UseForeColor = true;
            this.nvInput.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.nvInput.Size = new System.Drawing.Size(200, 24);
            this.nvInput.TabIndex = 6;
            // 
            // hotenkhInput
            // 
            this.hotenkhInput.Location = new System.Drawing.Point(110, 80);
            this.hotenkhInput.Name = "hotenkhInput";
            this.hotenkhInput.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.hotenkhInput.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hotenkhInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hotenkhInput.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hotenkhInput.Properties.Appearance.Options.UseBackColor = true;
            this.hotenkhInput.Properties.Appearance.Options.UseBorderColor = true;
            this.hotenkhInput.Properties.Appearance.Options.UseFont = true;
            this.hotenkhInput.Properties.Appearance.Options.UseForeColor = true;
            this.hotenkhInput.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.hotenkhInput.Size = new System.Drawing.Size(250, 24);
            this.hotenkhInput.TabIndex = 5;
            // 
            // mapxInput
            // 
            this.mapxInput.Location = new System.Drawing.Point(110, 20);
            this.mapxInput.Name = "mapxInput";
            this.mapxInput.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.mapxInput.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mapxInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mapxInput.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mapxInput.Properties.Appearance.Options.UseBackColor = true;
            this.mapxInput.Properties.Appearance.Options.UseBorderColor = true;
            this.mapxInput.Properties.Appearance.Options.UseFont = true;
            this.mapxInput.Properties.Appearance.Options.UseForeColor = true;
            this.mapxInput.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.mapxInput.Size = new System.Drawing.Size(150, 24);
            this.mapxInput.TabIndex = 4;
            // 
            // manvLabel
            // 
            this.manvLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.manvLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.manvLabel.Appearance.Options.UseFont = true;
            this.manvLabel.Appearance.Options.UseForeColor = true;
            this.manvLabel.Location = new System.Drawing.Point(415, 85);
            this.manvLabel.Name = "manvLabel";
            this.manvLabel.Size = new System.Drawing.Size(80, 15);
            this.manvLabel.TabIndex = 3;
            this.manvLabel.Text = "Mã Nhân Viên:";
            // 
            // hotenkhLabel
            // 
            this.hotenkhLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.hotenkhLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hotenkhLabel.Appearance.Options.UseFont = true;
            this.hotenkhLabel.Appearance.Options.UseForeColor = true;
            this.hotenkhLabel.Location = new System.Drawing.Point(20, 85);
            this.hotenkhLabel.Name = "hotenkhLabel";
            this.hotenkhLabel.Size = new System.Drawing.Size(65, 15);
            this.hotenkhLabel.TabIndex = 2;
            this.hotenkhLabel.Text = "Họ Tên K.H:";
            // 
            // ngayLabel
            // 
            this.ngayLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ngayLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ngayLabel.Appearance.Options.UseFont = true;
            this.ngayLabel.Appearance.Options.UseForeColor = true;
            this.ngayLabel.Location = new System.Drawing.Point(415, 25);
            this.ngayLabel.Name = "ngayLabel";
            this.ngayLabel.Size = new System.Drawing.Size(53, 15);
            this.ngayLabel.TabIndex = 1;
            this.ngayLabel.Text = "Ngày Lập:";
            // 
            // mapxLabel
            // 
            this.mapxLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mapxLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mapxLabel.Appearance.Options.UseFont = true;
            this.mapxLabel.Appearance.Options.UseForeColor = true;
            this.mapxLabel.Location = new System.Drawing.Point(20, 25);
            this.mapxLabel.Name = "mapxLabel";
            this.mapxLabel.Size = new System.Drawing.Size(83, 15);
            this.mapxLabel.TabIndex = 0;
            this.mapxLabel.Text = "Mã Phiếu Xuất:";
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 736);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(540, 218);
            this.MaximizeBox = false;
            this.Name = "FormPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phiếu Xuất";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cTPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.phieuxuatTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTPXDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatDataGridView1)).EndInit();
            this.ctpxTab.ResumeLayout(false);
            this.ctpxTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dongiaInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPanel2)).EndInit();
            this.inputPanel2.ResumeLayout(false);
            this.inputPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotenkhInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapxInput.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private System.Windows.Forms.Label labelTitle;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.DataGridView phieuXuatDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMAPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHOTENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTOTALVALUE;
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource phieuXuatBindingSource;
        private qlvtDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cTPXBindingSource;
        private qlvtDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private qlvtDataSetTableAdapters.NhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.BindingSource vattuBindingSource1;
        private qlvtDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource nhanvienBindingSource1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage phieuxuatTab;
        private DevExpress.XtraTab.XtraTabPage ctpxTab;
        private System.Windows.Forms.DataGridView cTPXDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView phieuXuatDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevExpress.XtraEditors.PanelControl inputPanel2;
        private DevExpress.XtraEditors.LabelControl tenvtLabel;
        private DevExpress.XtraEditors.LabelControl dongiaLabel;
        private DevExpress.XtraEditors.LabelControl soluongLabel;
        private System.Windows.Forms.ComboBox vattuComboBox;
        private System.Windows.Forms.BindingSource vattuBindingSource2;
        private System.Windows.Forms.TextBox mAVTTextBox;
        private DevExpress.XtraEditors.TextEdit dongiaInput;
        private DevExpress.XtraEditors.TextEdit soluongInput;
        private DevExpress.XtraEditors.SimpleButton addvattuBtn;
        private System.Windows.Forms.DataGridView tempDataGridView;
        private DevExpress.XtraEditors.SimpleButton addPhieuXuatBtn;
        private DevExpress.XtraEditors.LabelControl totalLabel;
        private System.Windows.Forms.TextBox totalAmoutBox;
        private DevExpress.XtraEditors.SimpleButton deleteVTbtn;
        private DevExpress.XtraEditors.SimpleButton clearAllBtn;
        private System.Windows.Forms.DateTimePicker ngayInput;
        private DevExpress.XtraEditors.TextEdit nvInput;
        private DevExpress.XtraEditors.TextEdit hotenkhInput;
        private DevExpress.XtraEditors.TextEdit mapxInput;
        private DevExpress.XtraEditors.LabelControl manvLabel;
        private DevExpress.XtraEditors.LabelControl hotenkhLabel;
        private DevExpress.XtraEditors.LabelControl ngayLabel;
        private DevExpress.XtraEditors.LabelControl mapxLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private DevExpress.XtraEditors.SimpleButton reloadBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
    }
}