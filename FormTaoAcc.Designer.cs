namespace quanlyvattu
{
    partial class FormTaoAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoAcc));
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.RadioButton();
            this.employeeBtn = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vw_NhanVienChuaCoTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.vw_NhanVienChuaCoTaiKhoanTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vw_NhanVienChuaCoTaiKhoanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingNavigator)).BeginInit();
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Yellow;
            this.btnCreate.Location = new System.Drawing.Point(537, 403);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 39);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo tài khoản";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(471, 283);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(256, 22);
            this.txtPass.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(471, 226);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(256, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "LoginName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // adminBtn
            // 
            this.adminBtn.AutoSize = true;
            this.adminBtn.Location = new System.Drawing.Point(483, 336);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(66, 20);
            this.adminBtn.TabIndex = 6;
            this.adminBtn.TabStop = true;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            // 
            // employeeBtn
            // 
            this.employeeBtn.AutoSize = true;
            this.employeeBtn.Location = new System.Drawing.Point(651, 336);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(88, 20);
            this.employeeBtn.TabIndex = 7;
            this.employeeBtn.TabStop = true;
            this.employeeBtn.Text = "Nhân viên";
            this.employeeBtn.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(37, 51);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thuộc nhóm";
            // 
            // vw_NhanVienChuaCoTaiKhoanBindingSource
            // 
            this.vw_NhanVienChuaCoTaiKhoanBindingSource.DataMember = "vw_NhanVienChuaCoTaiKhoan";
            this.vw_NhanVienChuaCoTaiKhoanBindingSource.DataSource = this.qlvtDataSet;
            // 
            // vw_NhanVienChuaCoTaiKhoanTableAdapter
            // 
            this.vw_NhanVienChuaCoTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanvienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // vw_NhanVienChuaCoTaiKhoanBindingNavigator
            // 
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.BindingSource = this.vw_NhanVienChuaCoTaiKhoanBindingSource;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem});
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.Name = "vw_NhanVienChuaCoTaiKhoanBindingNavigator";
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.Size = new System.Drawing.Size(1179, 27);
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.TabIndex = 10;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem
            // 
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem.Enabled = false;
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem.Image")));
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem.Name = "vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem";
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // vw_NhanVienChuaCoTaiKhoanBindingSource1
            // 
            this.vw_NhanVienChuaCoTaiKhoanBindingSource1.DataMember = "vw_NhanVienChuaCoTaiKhoan";
            this.vw_NhanVienChuaCoTaiKhoanBindingSource1.DataSource = this.qlvtDataSet;
            // 
            // vw_NhanVienChuaCoTaiKhoanBindingSource2
            // 
            this.vw_NhanVienChuaCoTaiKhoanBindingSource2.DataMember = "vw_NhanVienChuaCoTaiKhoan";
            this.vw_NhanVienChuaCoTaiKhoanBindingSource2.DataSource = this.qlvtDataSet;
            // 
            // vw_NhanVienChuaCoTaiKhoanBindingSource3
            // 
            this.vw_NhanVienChuaCoTaiKhoanBindingSource3.DataMember = "vw_NhanVienChuaCoTaiKhoan";
            this.vw_NhanVienChuaCoTaiKhoanBindingSource3.DataSource = this.qlvtDataSet;
            // 
            // vw_NhanVienChuaCoTaiKhoanBindingSource4
            // 
            this.vw_NhanVienChuaCoTaiKhoanBindingSource4.DataMember = "vw_NhanVienChuaCoTaiKhoan";
            this.vw_NhanVienChuaCoTaiKhoanBindingSource4.DataSource = this.qlvtDataSet;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DataSource = this.vw_NhanVienChuaCoTaiKhoanBindingSource4;
            this.cmbNhanVien.DisplayMember = "CMND";
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(471, 102);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(256, 24);
            this.cmbNhanVien.TabIndex = 10;
            this.cmbNhanVien.ValueMember = "MANV";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(351, 110);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Chọn nhân viên";
            // 
            // FormTaoAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 742);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.vw_NhanVienChuaCoTaiKhoanBindingNavigator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.employeeBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnCreate);
            this.Name = "FormTaoAcc";
            this.Text = "Tạo tài khoản nhân viên";
            this.Load += new System.EventHandler(this.FormTaoAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingNavigator)).EndInit();
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.ResumeLayout(false);
            this.vw_NhanVienChuaCoTaiKhoanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton adminBtn;
        private System.Windows.Forms.RadioButton employeeBtn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource;
        private qlvtDataSetTableAdapters.vw_NhanVienChuaCoTaiKhoanTableAdapter vw_NhanVienChuaCoTaiKhoanTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vw_NhanVienChuaCoTaiKhoanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vw_NhanVienChuaCoTaiKhoanBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource1;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource2;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource3;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource4;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}