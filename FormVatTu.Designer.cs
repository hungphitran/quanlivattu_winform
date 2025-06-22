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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.backBut = new DevExpress.XtraEditors.SimpleButton();
            this.reloadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.undoBtn = new DevExpress.XtraEditors.SimpleButton();
            this.listVattuBtn = new DevExpress.XtraEditors.SimpleButton();
            this.searchInput = new DevExpress.XtraEditors.TextEdit();
            this.lichSuVattuBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.vattuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mavtTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dvtTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soluongtonSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tenvtTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupBoxAddVatTu = new System.Windows.Forms.GroupBox();
            this.addButt = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.donvitinhInput = new DevExpress.XtraEditors.TextEdit();
            this.tenvtInput = new DevExpress.XtraEditors.TextEdit();
            this.mavtInput = new DevExpress.XtraEditors.TextEdit();
            this.labelNoResult = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            soluongtonLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuDataGridView)).BeginInit();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavtTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvtTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtonSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtTextEdit.Properties)).BeginInit();
            this.groupBoxAddVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENVTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            tENVTLabel.Location = new System.Drawing.Point(286, 43);
            tENVTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(62, 15);
            tENVTLabel.TabIndex = 22;
            tENVTLabel.Text = "Tên vật tư:";
            // 
            // soluongtonLabel
            // 
            soluongtonLabel.AutoSize = true;
            soluongtonLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soluongtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            soluongtonLabel.Location = new System.Drawing.Point(286, 92);
            soluongtonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            soluongtonLabel.Name = "soluongtonLabel";
            soluongtonLabel.Size = new System.Drawing.Size(78, 15);
            soluongtonLabel.TabIndex = 25;
            soluongtonLabel.Text = "Số lượng tồn:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dVTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dVTLabel.Location = new System.Drawing.Point(40, 92);
            dVTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(68, 15);
            dVTLabel.TabIndex = 23;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAVTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            mAVTLabel.Location = new System.Drawing.Point(40, 43);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(60, 15);
            mAVTLabel.TabIndex = 21;
            mAVTLabel.Text = "Mã vật tư:";
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
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1326, 68);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(4, 9);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(282, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "QUẢN LÝ VẬT TƯ";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.backBut);
            this.controlPanel.Controls.Add(this.reloadBtn);
            this.controlPanel.Controls.Add(this.saveBtn);
            this.controlPanel.Controls.Add(this.undoBtn);
            this.controlPanel.Controls.Add(this.listVattuBtn);
            this.controlPanel.Controls.Add(this.searchInput);
            this.controlPanel.Controls.Add(this.lichSuVattuBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 68);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1326, 86);
            this.controlPanel.TabIndex = 1;
            // 
            // backBut
            // 
            this.backBut.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.backBut.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.backBut.Appearance.ForeColor = System.Drawing.Color.White;
            this.backBut.Appearance.Options.UseBackColor = true;
            this.backBut.Appearance.Options.UseFont = true;
            this.backBut.Appearance.Options.UseForeColor = true;
            this.backBut.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.backBut.AppearanceHovered.Options.UseBackColor = true;
            this.backBut.Location = new System.Drawing.Point(13, 24);
            this.backBut.Margin = new System.Windows.Forms.Padding(5);
            this.backBut.Name = "backBut";
            this.backBut.Size = new System.Drawing.Size(160, 43);
            this.backBut.TabIndex = 16;
            this.backBut.Text = "◄ Quay lại";
            this.backBut.Click += new System.EventHandler(this.backBut_Click);
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
            this.reloadBtn.Location = new System.Drawing.Point(193, 24);
            this.reloadBtn.Margin = new System.Windows.Forms.Padding(5);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(160, 44);
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
            this.saveBtn.Location = new System.Drawing.Point(363, 24);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(160, 44);
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
            this.undoBtn.Location = new System.Drawing.Point(533, 24);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(5);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(160, 44);
            this.undoBtn.TabIndex = 19;
            this.undoBtn.Text = "↶ Undo";
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // listVattuBtn
            // 
            this.listVattuBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(16)))), ((int)(((byte)(242)))));
            this.listVattuBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.listVattuBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.listVattuBtn.Appearance.Options.UseBackColor = true;
            this.listVattuBtn.Appearance.Options.UseFont = true;
            this.listVattuBtn.Appearance.Options.UseForeColor = true;
            this.listVattuBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(13)))), ((int)(((byte)(200)))));
            this.listVattuBtn.AppearanceHovered.Options.UseBackColor = true;
            this.listVattuBtn.Location = new System.Drawing.Point(1167, 25);
            this.listVattuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.listVattuBtn.Name = "listVattuBtn";
            this.listVattuBtn.Size = new System.Drawing.Size(147, 43);
            this.listVattuBtn.TabIndex = 40;
            this.listVattuBtn.Text = "📄 In danh sách vật tư";
            this.listVattuBtn.Click += new System.EventHandler(this.listVattuBtn_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(717, 34);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.searchInput.Name = "searchInput";
            this.searchInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchInput.Properties.Appearance.Options.UseFont = true;
            this.searchInput.Properties.NullValuePrompt = "Nhập từ khóa tìm kiếm...";
            this.searchInput.Size = new System.Drawing.Size(243, 24);
            this.searchInput.TabIndex = 15;
            this.searchInput.EditValueChanged += new System.EventHandler(this.searchInput_EditValueChanged);
            // 
            // lichSuVattuBtn
            // 
            this.lichSuVattuBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(16)))), ((int)(((byte)(242)))));
            this.lichSuVattuBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lichSuVattuBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.lichSuVattuBtn.Appearance.Options.UseBackColor = true;
            this.lichSuVattuBtn.Appearance.Options.UseFont = true;
            this.lichSuVattuBtn.Appearance.Options.UseForeColor = true;
            this.lichSuVattuBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(13)))), ((int)(((byte)(200)))));
            this.lichSuVattuBtn.AppearanceHovered.Options.UseBackColor = true;
            this.lichSuVattuBtn.Location = new System.Drawing.Point(991, 24);
            this.lichSuVattuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.lichSuVattuBtn.Name = "lichSuVattuBtn";
            this.lichSuVattuBtn.Size = new System.Drawing.Size(168, 43);
            this.lichSuVattuBtn.TabIndex = 41;
            this.lichSuVattuBtn.Text = "📄 Xem lịch sử giao dịch";
            this.lichSuVattuBtn.Click += new System.EventHandler(this.lichSuVattuBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(171, 144);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(267, 43);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "🗑️ Xóa vật tư đang chọn";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // vattuDataGridView
            // 
            this.vattuDataGridView.AllowUserToAddRows = false;
            this.vattuDataGridView.AllowUserToDeleteRows = false;
            this.vattuDataGridView.AllowUserToOrderColumns = true;
            this.vattuDataGridView.AutoGenerateColumns = false;
            this.vattuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vattuDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.vattuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vattuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vattuDataGridView.ColumnHeadersHeight = 40;
            this.vattuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vattuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vattuDataGridView.DataSource = this.vattuBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vattuDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vattuDataGridView.EnableHeadersVisualStyles = false;
            this.vattuDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.vattuDataGridView.Location = new System.Drawing.Point(13, 159);
            this.vattuDataGridView.Margin = new System.Windows.Forms.Padding(27, 25, 27, 12);
            this.vattuDataGridView.MultiSelect = false;
            this.vattuDataGridView.Name = "vattuDataGridView";
            this.vattuDataGridView.RowHeadersVisible = false;
            this.vattuDataGridView.RowHeadersWidth = 51;
            this.vattuDataGridView.RowTemplate.Height = 35;
            this.vattuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vattuDataGridView.Size = new System.Drawing.Size(1301, 456);
            this.vattuDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã vật tư";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên vật tư";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DVT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn vị tính";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Soluongton";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng tồn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Controls.Add(this.groupControl1);
            this.inputPanel.Controls.Add(this.groupBoxAddVatTu);
            this.inputPanel.Location = new System.Drawing.Point(27, 624);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(1297, 243);
            this.inputPanel.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(mAVTLabel);
            this.groupControl1.Controls.Add(this.mavtTextEdit);
            this.groupControl1.Controls.Add(this.deleteBtn);
            this.groupControl1.Controls.Add(dVTLabel);
            this.groupControl1.Controls.Add(this.dvtTextEdit);
            this.groupControl1.Controls.Add(soluongtonLabel);
            this.groupControl1.Controls.Add(this.soluongtonSpinEdit);
            this.groupControl1.Controls.Add(tENVTLabel);
            this.groupControl1.Controls.Add(this.tenvtTextEdit);
            this.groupControl1.Location = new System.Drawing.Point(13, 17);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(611, 209);
            this.groupControl1.TabIndex = 50;
            this.groupControl1.Text = "THÔNG TIN VẬT TƯ";
            // 
            // mavtTextEdit
            // 
            this.mavtTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "MAVT", true));
            this.mavtTextEdit.Location = new System.Drawing.Point(138, 40);
            this.mavtTextEdit.Margin = new System.Windows.Forms.Padding(5);
            this.mavtTextEdit.Name = "mavtTextEdit";
            this.mavtTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mavtTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mavtTextEdit.Size = new System.Drawing.Size(108, 22);
            this.mavtTextEdit.TabIndex = 14;
            // 
            // dvtTextEdit
            // 
            this.dvtTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "DVT", true));
            this.dvtTextEdit.Location = new System.Drawing.Point(138, 90);
            this.dvtTextEdit.Margin = new System.Windows.Forms.Padding(5);
            this.dvtTextEdit.Name = "dvtTextEdit";
            this.dvtTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dvtTextEdit.Properties.Appearance.Options.UseFont = true;
            this.dvtTextEdit.Size = new System.Drawing.Size(108, 22);
            this.dvtTextEdit.TabIndex = 13;
            // 
            // soluongtonSpinEdit
            // 
            this.soluongtonSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "Soluongton", true));
            this.soluongtonSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soluongtonSpinEdit.Location = new System.Drawing.Point(385, 90);
            this.soluongtonSpinEdit.Margin = new System.Windows.Forms.Padding(5);
            this.soluongtonSpinEdit.Name = "soluongtonSpinEdit";
            this.soluongtonSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soluongtonSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.soluongtonSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soluongtonSpinEdit.Size = new System.Drawing.Size(112, 22);
            this.soluongtonSpinEdit.TabIndex = 12;
            // 
            // tenvtTextEdit
            // 
            this.tenvtTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "TENVT", true));
            this.tenvtTextEdit.Location = new System.Drawing.Point(385, 40);
            this.tenvtTextEdit.Margin = new System.Windows.Forms.Padding(5);
            this.tenvtTextEdit.Name = "tenvtTextEdit";
            this.tenvtTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tenvtTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tenvtTextEdit.Size = new System.Drawing.Size(178, 22);
            this.tenvtTextEdit.TabIndex = 11;
            // 
            // groupBoxAddVatTu
            // 
            this.groupBoxAddVatTu.Controls.Add(this.addButt);
            this.groupBoxAddVatTu.Controls.Add(this.label3);
            this.groupBoxAddVatTu.Controls.Add(this.label2);
            this.groupBoxAddVatTu.Controls.Add(this.label1);
            this.groupBoxAddVatTu.Controls.Add(this.donvitinhInput);
            this.groupBoxAddVatTu.Controls.Add(this.tenvtInput);
            this.groupBoxAddVatTu.Controls.Add(this.mavtInput);
            this.groupBoxAddVatTu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxAddVatTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxAddVatTu.Location = new System.Drawing.Point(647, 17);
            this.groupBoxAddVatTu.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAddVatTu.Name = "groupBoxAddVatTu";
            this.groupBoxAddVatTu.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAddVatTu.Size = new System.Drawing.Size(640, 209);
            this.groupBoxAddVatTu.TabIndex = 51;
            this.groupBoxAddVatTu.TabStop = false;
            this.groupBoxAddVatTu.Text = "THÊM VẬT TƯ MỚI";
            // 
            // addButt
            // 
            this.addButt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.addButt.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addButt.Appearance.ForeColor = System.Drawing.Color.White;
            this.addButt.Appearance.Options.UseBackColor = true;
            this.addButt.Appearance.Options.UseFont = true;
            this.addButt.Appearance.Options.UseForeColor = true;
            this.addButt.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(179)))));
            this.addButt.AppearanceHovered.Options.UseBackColor = true;
            this.addButt.Location = new System.Drawing.Point(371, 75);
            this.addButt.Margin = new System.Windows.Forms.Padding(5);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(208, 55);
            this.addButt.TabIndex = 29;
            this.addButt.Text = "➕ Thêm vật tư mới";
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên vật tư:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã vật tư:";
            // 
            // donvitinhInput
            // 
            this.donvitinhInput.Location = new System.Drawing.Point(105, 148);
            this.donvitinhInput.Margin = new System.Windows.Forms.Padding(5);
            this.donvitinhInput.Name = "donvitinhInput";
            this.donvitinhInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.donvitinhInput.Properties.Appearance.Options.UseFont = true;
            this.donvitinhInput.Size = new System.Drawing.Size(240, 22);
            this.donvitinhInput.TabIndex = 32;
            // 
            // tenvtInput
            // 
            this.tenvtInput.Location = new System.Drawing.Point(105, 91);
            this.tenvtInput.Margin = new System.Windows.Forms.Padding(5);
            this.tenvtInput.Name = "tenvtInput";
            this.tenvtInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tenvtInput.Properties.Appearance.Options.UseFont = true;
            this.tenvtInput.Size = new System.Drawing.Size(240, 22);
            this.tenvtInput.TabIndex = 31;
            // 
            // mavtInput
            // 
            this.mavtInput.Location = new System.Drawing.Point(105, 41);
            this.mavtInput.Margin = new System.Windows.Forms.Padding(5);
            this.mavtInput.Name = "mavtInput";
            this.mavtInput.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mavtInput.Properties.Appearance.Options.UseFont = true;
            this.mavtInput.Size = new System.Drawing.Size(240, 22);
            this.mavtInput.TabIndex = 30;
            // 
            // labelNoResult
            // 
            this.labelNoResult.AutoSize = true;
            this.labelNoResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoResult.ForeColor = System.Drawing.Color.Red;
            this.labelNoResult.Location = new System.Drawing.Point(556, 391);
            this.labelNoResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoResult.Name = "labelNoResult";
            this.labelNoResult.Size = new System.Drawing.Size(313, 21);
            this.labelNoResult.TabIndex = 4;
            this.labelNoResult.Text = "Không tìm thấy vật tư phù hợp với tìm kiếm";
            this.labelNoResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNoResult.Visible = false;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1326, 883);
            this.Controls.Add(this.labelNoResult);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.vattuDataGridView);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Vật Tư";
            this.Load += new System.EventHandler(this.FormVatTu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuDataGridView)).EndInit();
            this.inputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavtTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvtTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluongtonSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtTextEdit.Properties)).EndInit();
            this.groupBoxAddVatTu.ResumeLayout(false);
            this.groupBoxAddVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donvitinhInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenvtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavtInput.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private qlvtDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton backBut;
        private DevExpress.XtraEditors.SimpleButton addButt;
        private DevExpress.XtraEditors.SimpleButton reloadBtn;
        private DevExpress.XtraEditors.TextEdit mavtInput;
        private DevExpress.XtraEditors.TextEdit tenvtInput;
        private DevExpress.XtraEditors.TextEdit donvitinhInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton undoBtn;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.TextEdit searchInput;
        private DevExpress.XtraEditors.SimpleButton lichSuVattuBtn;
        private System.Windows.Forms.DataGridView vattuDataGridView;
        private DevExpress.XtraEditors.TextEdit dvtTextEdit;
        private DevExpress.XtraEditors.SpinEdit soluongtonSpinEdit;
        private DevExpress.XtraEditors.TextEdit tenvtTextEdit;
        private DevExpress.XtraEditors.TextEdit mavtTextEdit;
        private DevExpress.XtraEditors.SimpleButton listVattuBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.GroupBox groupBoxAddVatTu;
        private System.Windows.Forms.Label labelNoResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}