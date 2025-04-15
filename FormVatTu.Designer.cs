using System;
using DevExpress.XtraGrid.Views.Base;

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
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label soluongtonLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label mAVTLabel;
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mAVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soluongtonSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tENVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lichSuVattuBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBtn = new System.Windows.Forms.Button();
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
            this.vattuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listVattuBtn = new DevExpress.XtraEditors.SimpleButton();
            tENVTLabel = new System.Windows.Forms.Label();
            soluongtonLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingNavigator)).BeginInit();
            this.vattuBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtonSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(316, 64);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(42, 13);
            tENVTLabel.TabIndex = 10;
            tENVTLabel.Text = "TENVT:";
            // 
            // soluongtonLabel
            // 
            soluongtonLabel.AutoSize = true;
            soluongtonLabel.Location = new System.Drawing.Point(291, 143);
            soluongtonLabel.Name = "soluongtonLabel";
            soluongtonLabel.Size = new System.Drawing.Size(65, 13);
            soluongtonLabel.TabIndex = 11;
            soluongtonLabel.Text = "Soluongton:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(85, 143);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(30, 13);
            dVTLabel.TabIndex = 12;
            dVTLabel.Text = "DVT:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(75, 64);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(38, 13);
            mAVTLabel.TabIndex = 13;
            mAVTLabel.Text = "MAVT:";
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
            this.vattuBindingNavigator.Location = new System.Drawing.Point(0, 696);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(mAVTLabel);
            this.groupControl1.Controls.Add(this.mAVTTextEdit);
            this.groupControl1.Controls.Add(dVTLabel);
            this.groupControl1.Controls.Add(this.dVTTextEdit);
            this.groupControl1.Controls.Add(soluongtonLabel);
            this.groupControl1.Controls.Add(this.soluongtonSpinEdit);
            this.groupControl1.Controls.Add(tENVTLabel);
            this.groupControl1.Controls.Add(this.tENVTTextEdit);
            this.groupControl1.Controls.Add(this.lichSuVattuBtn);
            this.groupControl1.Controls.Add(this.deleteBtn);
            this.groupControl1.Location = new System.Drawing.Point(0, 378);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(640, 294);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin vật tư";
            // 
            // mAVTTextEdit
            // 
            this.mAVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "MAVT", true));
            this.mAVTTextEdit.Location = new System.Drawing.Point(127, 61);
            this.mAVTTextEdit.Name = "mAVTTextEdit";
            this.mAVTTextEdit.Size = new System.Drawing.Size(125, 20);
            this.mAVTTextEdit.TabIndex = 14;
            // 
            // dVTTextEdit
            // 
            this.dVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "DVT", true));
            this.dVTTextEdit.Location = new System.Drawing.Point(127, 140);
            this.dVTTextEdit.Name = "dVTTextEdit";
            this.dVTTextEdit.Size = new System.Drawing.Size(125, 20);
            this.dVTTextEdit.TabIndex = 13;
            // 
            // soluongtonSpinEdit
            // 
            this.soluongtonSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "Soluongton", true));
            this.soluongtonSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soluongtonSpinEdit.Location = new System.Drawing.Point(373, 140);
            this.soluongtonSpinEdit.Name = "soluongtonSpinEdit";
            this.soluongtonSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soluongtonSpinEdit.Size = new System.Drawing.Size(125, 20);
            this.soluongtonSpinEdit.TabIndex = 12;
            // 
            // tENVTTextEdit
            // 
            this.tENVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "TENVT", true));
            this.tENVTTextEdit.Location = new System.Drawing.Point(373, 61);
            this.tENVTTextEdit.Name = "tENVTTextEdit";
            this.tENVTTextEdit.Size = new System.Drawing.Size(125, 20);
            this.tENVTTextEdit.TabIndex = 11;
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
            this.mavtInput.Size = new System.Drawing.Size(156, 20);
            this.mavtInput.TabIndex = 6;
            // 
            // tenvtInput
            // 
            this.tenvtInput.Location = new System.Drawing.Point(780, 496);
            this.tenvtInput.Margin = new System.Windows.Forms.Padding(4);
            this.tenvtInput.Name = "tenvtInput";
            this.tenvtInput.Size = new System.Drawing.Size(156, 20);
            this.tenvtInput.TabIndex = 7;
            // 
            // donvitinhInput
            // 
            this.donvitinhInput.Location = new System.Drawing.Point(780, 561);
            this.donvitinhInput.Margin = new System.Windows.Forms.Padding(4);
            this.donvitinhInput.Name = "donvitinhInput";
            this.donvitinhInput.Size = new System.Drawing.Size(156, 20);
            this.donvitinhInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã vật tư";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên vật tư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
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
            this.searchInput.Size = new System.Drawing.Size(182, 26);
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
            // vattuDataGridView
            // 
            this.vattuDataGridView.AllowUserToOrderColumns = true;
            this.vattuDataGridView.AutoGenerateColumns = false;
            this.vattuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vattuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vattuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vattuDataGridView.DataSource = this.vattuBindingSource;
            this.vattuDataGridView.Location = new System.Drawing.Point(0, 74);
            this.vattuDataGridView.Name = "vattuDataGridView";
            this.vattuDataGridView.RowHeadersWidth = 51;
            this.vattuDataGridView.RowTemplate.Height = 24;
            this.vattuDataGridView.Size = new System.Drawing.Size(1232, 297);
            this.vattuDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENVT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DVT";
            this.dataGridViewTextBoxColumn3.HeaderText = "DVT";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Soluongton";
            this.dataGridViewTextBoxColumn4.HeaderText = "Soluongton";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // listVattuBtn
            // 
            this.listVattuBtn.Location = new System.Drawing.Point(844, 628);
            this.listVattuBtn.Name = "listVattuBtn";
            this.listVattuBtn.Size = new System.Drawing.Size(207, 29);
            this.listVattuBtn.TabIndex = 17;
            this.listVattuBtn.Text = "In danh sách vật tư";
            this.listVattuBtn.Click += new System.EventHandler(this.listVattuBtn_Click);
            // 
            // FormVatTu
            // 
            this.ClientSize = new System.Drawing.Size(1244, 723);
            this.Controls.Add(this.listVattuBtn);
            this.Controls.Add(this.vattuDataGridView);
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
            this.Controls.Add(this.vattuBindingNavigator);
            this.Name = "FormVatTu";
            this.Load += new System.EventHandler(this.FormVatTu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingNavigator)).EndInit();
            this.vattuBindingNavigator.ResumeLayout(false);
            this.vattuBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtonSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuDataGridView)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button backBut;
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
        private System.Windows.Forms.DataGridView vattuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevExpress.XtraEditors.TextEdit dVTTextEdit;
        private DevExpress.XtraEditors.SpinEdit soluongtonSpinEdit;
        private DevExpress.XtraEditors.TextEdit tENVTTextEdit;
        private DevExpress.XtraEditors.TextEdit mAVTTextEdit;
        private DevExpress.XtraEditors.SimpleButton listVattuBtn;
    }
}