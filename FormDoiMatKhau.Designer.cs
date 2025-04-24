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
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienCoTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
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
            this.cmbNhanVien.DisplayMember = "CMND";
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(261, 47);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(261, 24);
            this.cmbNhanVien.TabIndex = 1;
            this.cmbNhanVien.ValueMember = "MANV";
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // textPass1
            // 
            this.textPass1.Location = new System.Drawing.Point(261, 141);
            this.textPass1.Name = "textPass1";
            this.textPass1.Properties.UseSystemPasswordChar = true;
            this.textPass1.Size = new System.Drawing.Size(261, 22);
            this.textPass1.TabIndex = 2;
            // 
            // textPass2
            // 
            this.textPass2.Location = new System.Drawing.Point(261, 208);
            this.textPass2.Name = "textPass2";
            this.textPass2.Properties.UseSystemPasswordChar = true;
            this.textPass2.Size = new System.Drawing.Size(261, 22);
            this.textPass2.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(146, 144);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Nhập mật khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(129, 211);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Nhập lại mật khẩu";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(309, 280);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(153, 29);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Đổi mật khẩu";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 29);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Quay lại";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Appearance.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Appearance.BackColor2 = System.Drawing.Color.White;
            this.deleteBtn.Appearance.Options.UseBackColor = true;
            this.deleteBtn.Location = new System.Drawing.Point(309, 335);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(153, 29);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Xóa tài khoản";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(558, 140);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Hiển thị mật khẩu";
            this.checkEdit1.Size = new System.Drawing.Size(170, 24);
            this.checkEdit1.TabIndex = 9;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textPass2);
            this.Controls.Add(this.textPass1);
            this.Controls.Add(this.cmbNhanVien);
            this.Name = "FormDoiMatKhau";
            this.Text = "FormDoiMatKhau";
            this.Load += new System.EventHandler(this.FormDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_NhanVienCoTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPass2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}