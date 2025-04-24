namespace quanlyvattu
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.VattuBtn = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.importBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.creatAccBtn = new System.Windows.Forms.Button();
            this.ImAndExportBtn = new System.Windows.Forms.Button();
            this.exportBtn = new DevExpress.XtraEditors.SimpleButton();
            this.backupBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelName = new DevExpress.XtraEditors.LabelControl();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.tongHopNhapXuatBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(378, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang chủ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(907, 15);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(124, 44);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(257, 160);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(211, 60);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = "Quản lý nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // VattuBtn
            // 
            this.VattuBtn.Location = new System.Drawing.Point(257, 233);
            this.VattuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VattuBtn.Name = "VattuBtn";
            this.VattuBtn.Size = new System.Drawing.Size(211, 66);
            this.VattuBtn.TabIndex = 3;
            this.VattuBtn.Text = "Quản lý vật tư";
            this.VattuBtn.UseVisualStyleBackColor = true;
            this.VattuBtn.Click += new System.EventHandler(this.VattuBtn_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 698);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip2.Size = new System.Drawing.Size(1145, 22);
            this.statusStrip2.TabIndex = 6;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 20);
            this.toolStripStatusLabel1.Text = "Tên";
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(593, 233);
            this.importBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(213, 66);
            this.importBtn.TabIndex = 7;
            this.importBtn.Text = "Phiếu nhập";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(593, 317);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(212, 57);
            this.orderBtn.TabIndex = 8;
            this.orderBtn.Text = "Đơn đặt hàng";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // creatAccBtn
            // 
            this.creatAccBtn.Location = new System.Drawing.Point(257, 400);
            this.creatAccBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creatAccBtn.Name = "creatAccBtn";
            this.creatAccBtn.Size = new System.Drawing.Size(211, 57);
            this.creatAccBtn.TabIndex = 9;
            this.creatAccBtn.Text = "Tạo tài khoản";
            this.creatAccBtn.UseVisualStyleBackColor = true;
            this.creatAccBtn.Click += new System.EventHandler(this.creatAccBtn_Click);
            // 
            // ImAndExportBtn
            // 
            this.ImAndExportBtn.Location = new System.Drawing.Point(259, 317);
            this.ImAndExportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImAndExportBtn.Name = "ImAndExportBtn";
            this.ImAndExportBtn.Size = new System.Drawing.Size(211, 57);
            this.ImAndExportBtn.TabIndex = 10;
            this.ImAndExportBtn.Text = "Báo cáo nhập xuất chi tiết";
            this.ImAndExportBtn.UseVisualStyleBackColor = true;
            this.ImAndExportBtn.Click += new System.EventHandler(this.ImAndExportBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(593, 160);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(210, 55);
            this.exportBtn.TabIndex = 11;
            this.exportBtn.Text = "Phiếu xuất";
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(595, 400);
            this.backupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(210, 57);
            this.backupBtn.TabIndex = 12;
            this.backupBtn.Text = "Sao lưu và phục hồi";
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 16);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Người dùng : ";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(110, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(4, 16);
            this.labelName.TabIndex = 14;
            this.labelName.Text = " ";
            // 
            // changePassBtn
            // 
            this.changePassBtn.Location = new System.Drawing.Point(257, 480);
            this.changePassBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(211, 60);
            this.changePassBtn.TabIndex = 15;
            this.changePassBtn.Text = "Đổi mật khẩu";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // tongHopNhapXuatBtn
            // 
            this.tongHopNhapXuatBtn.Location = new System.Drawing.Point(595, 480);
            this.tongHopNhapXuatBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tongHopNhapXuatBtn.Name = "tongHopNhapXuatBtn";
            this.tongHopNhapXuatBtn.Size = new System.Drawing.Size(211, 60);
            this.tongHopNhapXuatBtn.TabIndex = 16;
            this.tongHopNhapXuatBtn.Text = "Tổng hợp nhập xuất";
            this.tongHopNhapXuatBtn.UseVisualStyleBackColor = true;
            this.tongHopNhapXuatBtn.Click += new System.EventHandler(this.tongHopNhapXuatBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 720);
            this.Controls.Add(this.tongHopNhapXuatBtn);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.backupBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.ImAndExportBtn);
            this.Controls.Add(this.creatAccBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.VattuBtn);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button VattuBtn;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button creatAccBtn;
        private System.Windows.Forms.Button ImAndExportBtn;
        private DevExpress.XtraEditors.SimpleButton exportBtn;
        private DevExpress.XtraEditors.SimpleButton backupBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelName;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Button tongHopNhapXuatBtn;
    }
}