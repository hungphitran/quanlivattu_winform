namespace quanlyvattu
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label soluongtonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.vattuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluongton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lichSuVattuBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.soluongtonSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.dVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.backBut = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.mavtInput = new DevExpress.XtraEditors.TextEdit();
            this.tenvtInput = new DevExpress.XtraEditors.TextEdit();
            this.donvitinhInput = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.searchInput = new DevExpress.XtraEditors.TextEdit();
            this.searchBtn = new DevExpress.XtraEditors.SimpleButton();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            soluongtonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingNavigator)).BeginInit();
            this.vattuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtonSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(51, 75);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(46, 16);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "MAVT:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(342, 76);
            tENVTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(51, 16);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "TENVT:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(51, 141);
            dVTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(36, 16);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "DVT:";
            // 
            // soluongtonLabel
            // 
            soluongtonLabel.AutoSize = true;
            soluongtonLabel.Location = new System.Drawing.Point(350, 145);
            soluongtonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            soluongtonLabel.Name = "soluongtonLabel";
            soluongtonLabel.Size = new System.Drawing.Size(76, 16);
            soluongtonLabel.TabIndex = 6;
            soluongtonLabel.Text = "Soluongton:";
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
            // vattuBindingNavigator
            // 
            this.vattuBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vattuBindingNavigator.BindingSource = this.vattuBindingSource;
            this.vattuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vattuBindingNavigator.DeleteItem = null;
            this.vattuBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vattuBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vattuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.vattuBindingNavigator.Location = new System.Drawing.Point(0, 645);
            this.vattuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vattuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vattuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vattuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vattuBindingNavigator.Name = "vattuBindingNavigator";
            this.vattuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vattuBindingNavigator.Size = new System.Drawing.Size(1244, 27);
            this.vattuBindingNavigator.TabIndex = 0;
            this.vattuBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.vattuBindingSource;
            this.vattuGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.vattuGridControl.Location = new System.Drawing.Point(0, 65);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(1244, 312);
            this.vattuGridControl.TabIndex = 1;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSoluongton});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 31;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 117;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 31;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 117;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 31;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 117;
            // 
            // colSoluongton
            // 
            this.colSoluongton.FieldName = "Soluongton";
            this.colSoluongton.MinWidth = 31;
            this.colSoluongton.Name = "colSoluongton";
            this.colSoluongton.Visible = true;
            this.colSoluongton.VisibleIndex = 3;
            this.colSoluongton.Width = 117;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lichSuVattuBtn);
            this.groupControl1.Controls.Add(this.deleteBtn);
            this.groupControl1.Controls.Add(soluongtonLabel);
            this.groupControl1.Controls.Add(this.soluongtonSpinEdit);
            this.groupControl1.Controls.Add(dVTLabel);
            this.groupControl1.Controls.Add(this.dVTTextEdit);
            this.groupControl1.Controls.Add(tENVTLabel);
            this.groupControl1.Controls.Add(this.tENVTTextEdit);
            this.groupControl1.Controls.Add(mAVTLabel);
            this.groupControl1.Controls.Add(this.mAVTTextEdit);
            this.groupControl1.Location = new System.Drawing.Point(0, 378);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(640, 294);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin vật tư";
            // 
            // lichSuVattuBtn
            // 
            this.lichSuVattuBtn.Location = new System.Drawing.Point(345, 225);
            this.lichSuVattuBtn.Name = "lichSuVattuBtn";
            this.lichSuVattuBtn.Size = new System.Drawing.Size(225, 39);
            this.lichSuVattuBtn.TabIndex = 9;
            this.lichSuVattuBtn.Text = "Xem lịch sử giao dịch";
            this.lichSuVattuBtn.Click += new System.EventHandler(this.lichSuVattuBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(54, 225);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(145, 39);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Xóa vật tư";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // soluongtonSpinEdit
            // 
            this.soluongtonSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "Soluongton", true));
            this.soluongtonSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soluongtonSpinEdit.Location = new System.Drawing.Point(434, 141);
            this.soluongtonSpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.soluongtonSpinEdit.Name = "soluongtonSpinEdit";
            this.soluongtonSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soluongtonSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.soluongtonSpinEdit.TabIndex = 7;
            // 
            // dVTTextEdit
            // 
            this.dVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "DVT", true));
            this.dVTTextEdit.Location = new System.Drawing.Point(116, 138);
            this.dVTTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dVTTextEdit.Name = "dVTTextEdit";
            this.dVTTextEdit.Size = new System.Drawing.Size(156, 22);
            this.dVTTextEdit.TabIndex = 5;
            // 
            // tENVTTextEdit
            // 
            this.tENVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "TENVT", true));
            this.tENVTTextEdit.Location = new System.Drawing.Point(414, 72);
            this.tENVTTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tENVTTextEdit.Name = "tENVTTextEdit";
            this.tENVTTextEdit.Size = new System.Drawing.Size(156, 22);
            this.tENVTTextEdit.TabIndex = 3;
            // 
            // mAVTTextEdit
            // 
            this.mAVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "MAVT", true));
            this.mAVTTextEdit.Enabled = false;
            this.mAVTTextEdit.Location = new System.Drawing.Point(116, 71);
            this.mAVTTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.mAVTTextEdit.Name = "mAVTTextEdit";
            this.mAVTTextEdit.Size = new System.Drawing.Size(156, 22);
            this.mAVTTextEdit.TabIndex = 1;
            // 
            // backBut
            // 
            this.backBut.Location = new System.Drawing.Point(44, 12);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(75, 39);
            this.backBut.TabIndex = 3;
            this.backBut.Text = "Quay lại";
            this.backBut.UseVisualStyleBackColor = true;
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(1050, 486);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(134, 43);
            this.addButt.TabIndex = 4;
            this.addButt.Text = "Thêm vật tư";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Cyan;
            this.reloadBtn.Location = new System.Drawing.Point(240, 12);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(75, 39);
            this.reloadBtn.TabIndex = 5;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // mavtInput
            // 
            this.mavtInput.Location = new System.Drawing.Point(780, 423);
            this.mavtInput.Margin = new System.Windows.Forms.Padding(4);
            this.mavtInput.Name = "mavtInput";
            this.mavtInput.Size = new System.Drawing.Size(156, 22);
            this.mavtInput.TabIndex = 6;
            // 
            // tenvtInput
            // 
            this.tenvtInput.Location = new System.Drawing.Point(780, 496);
            this.tenvtInput.Margin = new System.Windows.Forms.Padding(4);
            this.tenvtInput.Name = "tenvtInput";
            this.tenvtInput.Size = new System.Drawing.Size(156, 22);
            this.tenvtInput.TabIndex = 7;
            // 
            // donvitinhInput
            // 
            this.donvitinhInput.Location = new System.Drawing.Point(780, 561);
            this.donvitinhInput.Margin = new System.Windows.Forms.Padding(4);
            this.donvitinhInput.Name = "donvitinhInput";
            this.donvitinhInput.Size = new System.Drawing.Size(156, 22);
            this.donvitinhInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã vật tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên vật tư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đơn vị tính";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Lime;
            this.saveBtn.Location = new System.Drawing.Point(373, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 38);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Ghi";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.BackColor = System.Drawing.Color.Lime;
            this.undoBtn.Location = new System.Drawing.Point(500, 12);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(99, 38);
            this.undoBtn.TabIndex = 14;
            this.undoBtn.Text = "Phục hồi";
            this.undoBtn.UseVisualStyleBackColor = false;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(821, 13);
            this.searchInput.Name = "searchInput";
            this.searchInput.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Properties.Appearance.Options.UseFont = true;
            this.searchInput.Size = new System.Drawing.Size(182, 30);
            this.searchInput.TabIndex = 15;
            // 
            // searchBtn
            // 
            this.searchBtn.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.searchBtn.Appearance.Options.UseBackColor = true;
            this.searchBtn.Location = new System.Drawing.Point(1009, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 31);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // FormVatTu
            // 
            this.ClientSize = new System.Drawing.Size(1244, 672);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.donvitinhInput);
            this.Controls.Add(this.tenvtInput);
            this.Controls.Add(this.mavtInput);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.backBut);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.vattuBindingNavigator);
            this.Name = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingNavigator)).EndInit();
            this.vattuBindingNavigator.ResumeLayout(false);
            this.vattuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtonSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private qlvtDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vattuBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit soluongtonSpinEdit;
        private DevExpress.XtraEditors.TextEdit dVTTextEdit;
        private DevExpress.XtraEditors.TextEdit tENVTTextEdit;
        private DevExpress.XtraEditors.TextEdit mAVTTextEdit;
        private System.Windows.Forms.Button backBut;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluongton;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button reloadBtn;
        private DevExpress.XtraEditors.TextEdit mavtInput;
        private DevExpress.XtraEditors.TextEdit tenvtInput;
        private DevExpress.XtraEditors.TextEdit donvitinhInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button deleteBtn;
        private DevExpress.XtraEditors.TextEdit searchInput;
        private DevExpress.XtraEditors.SimpleButton searchBtn;
        private DevExpress.XtraEditors.SimpleButton lichSuVattuBtn;
    }
}