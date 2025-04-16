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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang chủ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(680, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 36);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(48, 186);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(98, 54);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = "Quản lý nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // VattuBtn
            // 
            this.VattuBtn.Location = new System.Drawing.Point(212, 186);
            this.VattuBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VattuBtn.Name = "VattuBtn";
            this.VattuBtn.Size = new System.Drawing.Size(112, 54);
            this.VattuBtn.TabIndex = 3;
            this.VattuBtn.Text = "Quản lý vật tư";
            this.VattuBtn.UseVisualStyleBackColor = true;
            this.VattuBtn.Click += new System.EventHandler(this.VattuBtn_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 563);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip2.Size = new System.Drawing.Size(859, 22);
            this.statusStrip2.TabIndex = 6;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 20);
            this.toolStripStatusLabel1.Text = "Tên";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(388, 186);
            this.importBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(112, 54);
            this.importBtn.TabIndex = 7;
            this.importBtn.Text = "Phiếu nhập";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(571, 186);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(112, 54);
            this.orderBtn.TabIndex = 8;
            this.orderBtn.Text = "Đơn đặt hàng";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // creatAccBtn
            // 
            this.creatAccBtn.Location = new System.Drawing.Point(157, 314);
            this.creatAccBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creatAccBtn.Name = "creatAccBtn";
            this.creatAccBtn.Size = new System.Drawing.Size(126, 58);
            this.creatAccBtn.TabIndex = 9;
            this.creatAccBtn.Text = "Tạo tài khoản";
            this.creatAccBtn.UseVisualStyleBackColor = true;
            this.creatAccBtn.Click += new System.EventHandler(this.creatAccBtn_Click);
            // 
            // ImAndExportBtn
            // 
            this.ImAndExportBtn.Location = new System.Drawing.Point(426, 316);
            this.ImAndExportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImAndExportBtn.Name = "ImAndExportBtn";
            this.ImAndExportBtn.Size = new System.Drawing.Size(167, 54);
            this.ImAndExportBtn.TabIndex = 10;
            this.ImAndExportBtn.Text = "Báo cáo nhập xuất chi tiết";
            this.ImAndExportBtn.UseVisualStyleBackColor = true;
            this.ImAndExportBtn.Click += new System.EventHandler(this.ImAndExportBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(282, 421);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(124, 49);
            this.exportBtn.TabIndex = 11;
            this.exportBtn.Text = "Phiếu xuất";
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 585);
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
    }
}