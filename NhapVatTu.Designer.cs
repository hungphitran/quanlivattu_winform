namespace quanlyvattu
{
    partial class NhapVatTu
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
            this.mAPNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.mANVSpinEdit = new DevExpress.XtraEditors.SpinEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.Location = new System.Drawing.Point(2, 42);
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.MainView = this.gridView1;
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.Name = "sp_BaoCaoDonDatHangChuaNhapGridControl";
            this.sp_BaoCaoDonDatHangChuaNhapGridControl.Size = new System.Drawing.Size(1234, 305);
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
            this.gridView1.GridControl = this.sp_BaoCaoDonDatHangChuaNhapGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 94;
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(12, 362);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(77, 16);
            masoDDHLabel.TabIndex = 2;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // masoDDHTextEdit
            // 
            this.masoDDHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sp_BaoCaoDonDatHangChuaNhapBindingSource, "MasoDDH", true));
            this.masoDDHTextEdit.Location = new System.Drawing.Point(95, 359);
            this.masoDDHTextEdit.Name = "masoDDHTextEdit";
            this.masoDDHTextEdit.Size = new System.Drawing.Size(125, 22);
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
            this.cTDDHGridControl.Location = new System.Drawing.Point(683, 353);
            this.cTDDHGridControl.MainView = this.gridView2;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(553, 284);
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
            this.gridView2.GridControl = this.cTDDHGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "MasoDDH";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(364, 362);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(49, 16);
            mAPNLabel.TabIndex = 4;
            mAPNLabel.Text = "MAPN:";
            // 
            // mAPNTextEdit
            // 
            this.mAPNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.mAPNTextEdit.Location = new System.Drawing.Point(419, 359);
            this.mAPNTextEdit.Name = "mAPNTextEdit";
            this.mAPNTextEdit.Size = new System.Drawing.Size(125, 22);
            this.mAPNTextEdit.TabIndex = 5;
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(365, 405);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(48, 16);
            nGAYLabel.TabIndex = 6;
            nGAYLabel.Text = "NGAY:";
            // 
            // nGAYDateEdit
            // 
            this.nGAYDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "NGAY", true));
            this.nGAYDateEdit.EditValue = null;
            this.nGAYDateEdit.Location = new System.Drawing.Point(419, 402);
            this.nGAYDateEdit.Name = "nGAYDateEdit";
            this.nGAYDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYDateEdit.Size = new System.Drawing.Size(125, 22);
            this.nGAYDateEdit.TabIndex = 7;
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(364, 455);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(49, 16);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MANV:";
            // 
            // mANVSpinEdit
            // 
            this.mANVSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MANV", true));
            this.mANVSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mANVSpinEdit.Location = new System.Drawing.Point(419, 452);
            this.mANVSpinEdit.Name = "mANVSpinEdit";
            this.mANVSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mANVSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.mANVSpinEdit.TabIndex = 9;
            // 
            // NhapVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 657);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(this.mANVSpinEdit);
            this.Controls.Add(nGAYLabel);
            this.Controls.Add(this.nGAYDateEdit);
            this.Controls.Add(mAPNLabel);
            this.Controls.Add(this.mAPNTextEdit);
            this.Controls.Add(this.cTDDHGridControl);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.masoDDHTextEdit);
            this.Controls.Add(this.sp_BaoCaoDonDatHangChuaNhapGridControl);
            this.Name = "NhapVatTu";
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
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANVSpinEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit mAPNTextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYDateEdit;
        private DevExpress.XtraEditors.SpinEdit mANVSpinEdit;
    }
}