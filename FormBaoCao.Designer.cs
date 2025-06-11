namespace quanlyvattu
{
    partial class FormBaoCao
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
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.excelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pdfBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(1027, 664);
            this.documentViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pdfBtn);
            this.panel1.Controls.Add(this.excelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 45);
            this.panel1.TabIndex = 1;
            // 
            // excelBtn
            // 
            this.excelBtn.Location = new System.Drawing.Point(621, 12);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(150, 29);
            this.excelBtn.TabIndex = 1;
            this.excelBtn.Text = "Lưu file EXCEL";
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // pdfBtn
            // 
            this.pdfBtn.Location = new System.Drawing.Point(804, 12);
            this.pdfBtn.Name = "pdfBtn";
            this.pdfBtn.Size = new System.Drawing.Size(112, 29);
            this.pdfBtn.TabIndex = 2;
            this.pdfBtn.Text = "Lưu file PDF";
            this.pdfBtn.Click += new System.EventHandler(this.pdfBtn_Click);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.documentViewer1);
            this.Name = "FormBaoCao";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton excelBtn;
        private DevExpress.XtraEditors.SimpleButton pdfBtn;
    }
}