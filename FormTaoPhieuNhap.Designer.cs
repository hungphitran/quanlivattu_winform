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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel;
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.sp_BaoCaoDonDatHangChuaNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.sp_BaoCaoDonDatHangChuaNhapTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.phieuNhapTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.PhieuNhapTableAdapter();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_BaoCaoDonDatHangChuaNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.masoDDHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.CTDDHTableAdapter();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mapnInput = new DevExpress.XtraEditors.TextEdit();
            this.manvInput = new DevExpress.XtraEditors.TextEdit();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ngayInput = new System.Windows.Forms.DateTimePicker();
            masoDDHLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapnInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manvInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(9, 294);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 2;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(11, 334);
            mAPNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(41, 13);
            mAPNLabel.TabIndex = 4;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(245, 299);
            nGAYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(40, 13);
            nGAYLabel.TabIndex = 6;
            nGAYLabel.Text = "NGAY:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(245, 338);
            mANVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MANV:";
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
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qlvtDataSet;
            // 
            // sp_BaoCaoDonDatHangChuaNhapGridControl
            // 
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.DataSource = this.sp_BaoCaoDonDatHangChuaNhapBindingSource;
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.Location = new System.Drawing.Point(2, 34);
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.MainView = this.gridView1;
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.Name = "sp_BaoCaoDonDatHangChuaNhapGridControl";
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.Size = new System.Drawing.Size(926, 248);
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.TabIndex = 2;
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colHOTEN});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.sp_BaoCaoDonDatHangChuaNhapGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 19;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 70;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 19;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 70;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 19;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 70;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 19;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 70;
            // 
            // masoDDHTextEdit
            // 
            this.masoDDHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sp_BaoCaoDonDatHangChuaNhapBindingSource, "MasoDDH", true));
            this.masoDDHTextEdit.Location = new System.Drawing.Point(71, 292);
            this.masoDDHTextEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masoDDHTextEdit.Name = "masoDDHTextEdit";
            this.masoDDHTextEdit.Size = new System.Drawing.Size(94, 20);
            this.masoDDHTextEdit.TabIndex = 3;
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
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.cTDDHBindingSource;
            this.cTDDHGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cTDDHGridControl.Location = new System.Drawing.Point(512, 287);
            this.cTDDHGridControl.MainView = this.gridView2;
            this.cTDDHGridControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(415, 231);
            this.cTDDHGridControl.TabIndex = 3;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.cTDDHGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "MasoDDH";
            this.gridColumn1.MinWidth = 19;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 70;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 19;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 70;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 19;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 70;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 19;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 70;
            // 
            // mapnInput
            // 
            this.mapnInput.Location = new System.Drawing.Point(71, 326);
            this.mapnInput.Name = "mapnInput";
            this.mapnInput.Size = new System.Drawing.Size(100, 20);
            this.mapnInput.TabIndex = 9;
            // 
            // manvInput
            // 
            this.manvInput.Location = new System.Drawing.Point(314, 334);
            this.manvInput.Name = "manvInput";
            this.manvInput.Size = new System.Drawing.Size(100, 20);
            this.manvInput.TabIndex = 11;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(25, 6);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ngayInput
            // 
            this.ngayInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayInput.Location = new System.Drawing.Point(290, 295);
            this.ngayInput.Name = "ngayInput";
            this.ngayInput.Size = new System.Drawing.Size(200, 20);
            this.ngayInput.TabIndex = 13;
            this.ngayInput.ValueChanged += new System.EventHandler(this.ngayInput_ValueChanged);
            // 
            // FormTaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 534);
            this.Controls.Add(this.ngayInput);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.manvInput);
            this.Controls.Add(this.mapnInput);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(nGAYLabel);
            this.Controls.Add(mAPNLabel);
            this.Controls.Add(this.cTDDHGridControl);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.masoDDHTextEdit);
            this.Controls.Add(this.sp_BaoCaoDonDatHangChuaNhapGridControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTaoPhieuNhap";
            this.Text = "NhapVatTu";
            this.Load += new System.EventHandler(this.NhapVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_BaoCaoDonDatHangChuaNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapnInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manvInput.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource sp_BaoCaoDonDatHangChuaNhapBindingSource;
        private qlvtDataSetTableAdapters.sp_BaoCaoDonDatHangChuaNhapTableAdapter sp_BaoCaoDonDatHangChuaNhapTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private qlvtDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private DevExpress.XtraGrid.GridControl sp_BaoCaoDonDatHangChuaNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraEditors.TextEdit masoDDHTextEdit;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private qlvtDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.TextEdit mapnInput;
        private DevExpress.XtraEditors.TextEdit manvInput;
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private System.Windows.Forms.DateTimePicker ngayInput;
    }
}