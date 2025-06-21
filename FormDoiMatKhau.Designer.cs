namespace quanlyvattu
{
    partial class FormDoiMatKhau
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
            this.vw_NhanVienCoTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienCoTaiKhoanTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.vw_NhanVienCoTaiKhoanTableAdapter();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.textPass1 = new DevExpress.XtraEditors.TextEdit();
            this.textPass2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.submitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.backBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienCoTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.passwordGroupBox.SuspendLayout();
            this.userGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_NhanVienCoTaiKhoanBindingSource
            // 
            this.vw_NhanVienCoTaiKhoanBindingSource.DataMember = "vw_NhanVienCoTaiKhoan";
            this.vw_NhanVienCoTaiKhoanBindingSource.DataSource = this.qlvtDataSet;
            // 
            // vw_NhanVienCoTaiKhoanTableAdapter
            // 
            this.vw_NhanVienCoTaiKhoanTableAdapter.ClearBeforeFill = true;
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
            // cmbNhanVien
            // 
            this.cmbNhanVien.DataSource = this.vw_NhanVienCoTaiKhoanBindingSource;
            this.cmbNhanVien.DisplayMember = "HOTEN";
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(200, 35);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(480, 28);
            this.cmbNhanVien.TabIndex = 1;
            this.cmbNhanVien.ValueMember = "MANV";
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // textPass1
            // 
            this.textPass1.Location = new System.Drawing.Point(200, 35);
            this.textPass1.Name = "textPass1";
            this.textPass1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPass1.Properties.Appearance.Options.UseFont = true;
            this.textPass1.Properties.UseSystemPasswordChar = true;
            this.textPass1.Size = new System.Drawing.Size(250, 26);
            this.textPass1.TabIndex = 2;
            // 
            // textPass2
            // 
            this.textPass2.Location = new System.Drawing.Point(200, 65);
            this.textPass2.Name = "textPass2";
            this.textPass2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPass2.Properties.Appearance.Options.UseFont = true;
            this.textPass2.Properties.UseSystemPasswordChar = true;
            this.textPass2.Size = new System.Drawing.Size(250, 26);
            this.textPass2.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 17);
            this.labelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 17);
            this.labelControl2.TabIndex = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.submitBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.submitBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Appearance.Options.UseBackColor = true;
            this.submitBtn.Appearance.Options.UseFont = true;
            this.submitBtn.Appearance.Options.UseForeColor = true;
            this.submitBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(67)))));
            this.submitBtn.AppearanceHovered.Options.UseBackColor = true;
            this.submitBtn.Location = new System.Drawing.Point(30, 240);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(200, 45);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "💾 Đổi mật khẩu";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.backBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.backBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.backBtn.Appearance.Options.UseBackColor = true;
            this.backBtn.Appearance.Options.UseFont = true;
            this.backBtn.Appearance.Options.UseForeColor = true;
            this.backBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.backBtn.AppearanceHovered.Options.UseBackColor = true;
            this.backBtn.Location = new System.Drawing.Point(30, 20);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(120, 35);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "◄ Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.deleteBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Appearance.Options.UseBackColor = true;
            this.deleteBtn.Appearance.Options.UseFont = true;
            this.deleteBtn.Appearance.Options.UseForeColor = true;
            this.deleteBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.deleteBtn.AppearanceHovered.Options.UseBackColor = true;
            this.deleteBtn.Location = new System.Drawing.Point(530, 240);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(200, 45);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "🗑️ Xóa tài khoản";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(470, 35);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Hiển thị mật khẩu";
            this.checkEdit1.Size = new System.Drawing.Size(200, 24);
            this.checkEdit1.TabIndex = 9;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(321, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ĐỔI MẬT KHẨU";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.backBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 80);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(800, 70);
            this.controlPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.passwordGroupBox);
            this.mainPanel.Controls.Add(this.userGroupBox);
            this.mainPanel.Controls.Add(this.submitBtn);
            this.mainPanel.Controls.Add(this.deleteBtn);
            this.mainPanel.Location = new System.Drawing.Point(20, 170);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(760, 323);
            this.mainPanel.TabIndex = 2;
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.BackColor = System.Drawing.Color.White;
            this.passwordGroupBox.Controls.Add(this.labelConfirmPassword);
            this.passwordGroupBox.Controls.Add(this.labelPassword);
            this.passwordGroupBox.Controls.Add(this.textPass2);
            this.passwordGroupBox.Controls.Add(this.textPass1);
            this.passwordGroupBox.Controls.Add(this.checkEdit1);
            this.passwordGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.passwordGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.passwordGroupBox.Location = new System.Drawing.Point(30, 120);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(700, 100);
            this.passwordGroupBox.TabIndex = 51;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "THÔNG TIN MẬT KHẨU";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelConfirmPassword.Location = new System.Drawing.Point(30, 70);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(133, 20);
            this.labelConfirmPassword.TabIndex = 23;
            this.labelConfirmPassword.Text = "Nhập lại mật khẩu:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelPassword.Location = new System.Drawing.Point(30, 40);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(143, 20);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Nhập mật khẩu mới:";
            // 
            // userGroupBox
            // 
            this.userGroupBox.BackColor = System.Drawing.Color.White;
            this.userGroupBox.Controls.Add(this.labelUser);
            this.userGroupBox.Controls.Add(this.cmbNhanVien);
            this.userGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.userGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.userGroupBox.Location = new System.Drawing.Point(30, 20);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(700, 80);
            this.userGroupBox.TabIndex = 50;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "CHỌN NHÂN VIÊN";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelUser.Location = new System.Drawing.Point(30, 40);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(113, 20);
            this.labelUser.TabIndex = 21;
            this.labelUser.Text = "Chọn nhân viên:";
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.FormDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienCoTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource vw_NhanVienCoTaiKhoanBindingSource;
        private qlvtDataSetTableAdapters.vw_NhanVienCoTaiKhoanTableAdapter vw_NhanVienCoTaiKhoanTableAdapter;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private DevExpress.XtraEditors.TextEdit textPass1;
        private DevExpress.XtraEditors.TextEdit textPass2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton submitBtn;
        private DevExpress.XtraEditors.SimpleButton backBtn;
        private DevExpress.XtraEditors.SimpleButton deleteBtn;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
    }
}