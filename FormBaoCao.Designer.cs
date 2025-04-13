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
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
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
            this.panel1.Controls.Add(this.dropDownButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 45);
            this.panel1.TabIndex = 1;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(810, 12);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(154, 29);
            this.dropDownButton1.TabIndex = 0;
            this.dropDownButton1.Text = "Lưu file PDF";
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
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
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}