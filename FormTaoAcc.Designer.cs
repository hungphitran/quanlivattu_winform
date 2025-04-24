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
            this.vw_NhanVienChuaCoTaiKhoanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vw_NhanVienChuaCoTaiKhoanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
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
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Chọn nhân viên";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(744, 285);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Hiển thị mật khẩu";
            this.checkEdit1.Size = new System.Drawing.Size(175, 24);
            this.checkEdit1.TabIndex = 13;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // FormTaoAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 742);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbNhanVien);
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
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienChuaCoTaiKhoanBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource1;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource2;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource3;
        private System.Windows.Forms.BindingSource vw_NhanVienChuaCoTaiKhoanBindingSource4;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}