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
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.RadioButton();
            this.employeeBtn = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.vw_NhanVienChuaCoTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.vw_NhanVienChuaCoTaiKhoanTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.vw_NhanVienChuaCoTaiKhoanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.showPassword = new DevExpress.XtraEditors.CheckEdit();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.createBtn = new DevExpress.XtraEditors.SimpleButton();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.groupBoxAccountInfo = new System.Windows.Forms.GroupBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.groupBoxRole = new System.Windows.Forms.GroupBox();
            this.labelRole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword.Properties)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.groupBoxAccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxRole.SuspendLayout();
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
            this.adminBtn.Location = new System.Drawing.Point(36, 72);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(2);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(74, 24);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.TabStop = true;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            // 
            // employeeBtn
            // 
            this.employeeBtn.AutoSize = true;
            this.employeeBtn.Location = new System.Drawing.Point(164, 73);
            this.employeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(98, 24);
            this.employeeBtn.TabIndex = 2;
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
            this.cmbNhanVien.Location = new System.Drawing.Point(97, 52);
            this.cmbNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(175, 28);
            this.cmbNhanVien.TabIndex = 1;
            this.cmbNhanVien.ValueMember = "MANV";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn nhân viên";
            // 
            // showPassword
            // 
            this.showPassword.Location = new System.Drawing.Point(90, 98);
            this.showPassword.Margin = new System.Windows.Forms.Padding(2);
            this.showPassword.Name = "showPassword";
            this.showPassword.Properties.Caption = "Hiển thị mật khẩu";
            this.showPassword.Size = new System.Drawing.Size(112, 20);
            this.showPassword.TabIndex = 4;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(675, 65);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(15, 16);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(461, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TẠO TÀI KHOẢN NHÂN VIÊN";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.backBtn);
            this.controlPanel.Controls.Add(this.createBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 65);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(675, 57);
            this.controlPanel.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.backBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.backBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.backBtn.Appearance.Options.UseBackColor = true;
            this.backBtn.Appearance.Options.UseFont = true;
            this.backBtn.Appearance.Options.UseForeColor = true;
            this.backBtn.Location = new System.Drawing.Point(22, 16);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(90, 28);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "◄ Quay lại";
            this.backBtn.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // createBtn
            // 
            this.createBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.createBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.createBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.createBtn.Appearance.Options.UseBackColor = true;
            this.createBtn.Appearance.Options.UseFont = true;
            this.createBtn.Appearance.Options.UseForeColor = true;
            this.createBtn.Location = new System.Drawing.Point(562, 16);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(90, 28);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Tạo tài khoản";
            this.createBtn.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Controls.Add(this.groupBoxAccountInfo);
            this.inputPanel.Controls.Add(this.groupBoxEmployee);
            this.inputPanel.Controls.Add(this.groupBoxRole);
            this.inputPanel.Location = new System.Drawing.Point(38, 146);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(2);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(600, 284);
            this.inputPanel.TabIndex = 2;
            // 
            // groupBoxAccountInfo
            // 
            this.groupBoxAccountInfo.Controls.Add(this.labelUsername);
            this.groupBoxAccountInfo.Controls.Add(this.txtUsername);
            this.groupBoxAccountInfo.Controls.Add(this.labelPassword);
            this.groupBoxAccountInfo.Controls.Add(this.txtPass);
            this.groupBoxAccountInfo.Controls.Add(this.showPassword);
            this.groupBoxAccountInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxAccountInfo.Location = new System.Drawing.Point(14, 16);
            this.groupBoxAccountInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAccountInfo.Name = "groupBoxAccountInfo";
            this.groupBoxAccountInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAccountInfo.Size = new System.Drawing.Size(267, 245);
            this.groupBoxAccountInfo.TabIndex = 0;
            this.groupBoxAccountInfo.TabStop = false;
            this.groupBoxAccountInfo.Text = "THÔNG TIN TÀI KHOẢN";
            this.groupBoxAccountInfo.Enter += new System.EventHandler(this.groupBoxAccountInfo_Enter);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUsername.Location = new System.Drawing.Point(15, 32);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(69, 15);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "LoginName";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(90, 30);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.MaxLength = 20;
            this.txtUsername.Size = new System.Drawing.Size(150, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelPassword.Location = new System.Drawing.Point(15, 65);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(90, 63);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.MaxLength = 20;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(150, 22);
            this.txtPass.TabIndex = 3;
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.labelControl1);
            this.groupBoxEmployee.Controls.Add(this.cmbNhanVien);
            this.groupBoxEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxEmployee.Location = new System.Drawing.Point(300, 16);
            this.groupBoxEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEmployee.Size = new System.Drawing.Size(286, 106);
            this.groupBoxEmployee.TabIndex = 1;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "CHỌN NHÂN VIÊN";
            // 
            // groupBoxRole
            // 
            this.groupBoxRole.Controls.Add(this.labelRole);
            this.groupBoxRole.Controls.Add(this.adminBtn);
            this.groupBoxRole.Controls.Add(this.employeeBtn);
            this.groupBoxRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxRole.Location = new System.Drawing.Point(300, 149);
            this.groupBoxRole.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRole.Name = "groupBoxRole";
            this.groupBoxRole.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRole.Size = new System.Drawing.Size(286, 112);
            this.groupBoxRole.TabIndex = 2;
            this.groupBoxRole.TabStop = false;
            this.groupBoxRole.Text = "PHÂN QUYỀN";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelRole.ForeColor = System.Drawing.Color.Red;
            this.labelRole.Location = new System.Drawing.Point(98, 42);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(86, 19);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Thuộc nhóm";
            // 
            // FormTaoAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 488);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTaoAcc";
            this.Text = "Tạo tài khoản nhân viên";
            this.Load += new System.EventHandler(this.FormTaoAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword.Properties)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.groupBoxAccountInfo.ResumeLayout(false);
            this.groupBoxAccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxRole.ResumeLayout(false);
            this.groupBoxRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton adminBtn;
        private System.Windows.Forms.RadioButton employeeBtn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource;
        private qlvtDataSetTableAdapters.vw_NhanVienChuaCoTaiKhoanTableAdapter vw_NhanVienChuaCoTaiKhoanTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource1;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource2;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource3;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource4;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit showPassword;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private DevExpress.XtraEditors.SimpleButton createBtn;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.GroupBox groupBoxAccountInfo;
        private System.Windows.Forms.Label labelUsername;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private System.Windows.Forms.Label labelPassword;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.GroupBox groupBoxRole;
    }
}