namespace quanlyvattu
{
    partial class FormSelectDetail
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
            this.fromDateInput = new System.Windows.Forms.DateTimePicker();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.toDateInput = new System.Windows.Forms.DateTimePicker();
            this.submitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.returnBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromDateInput
            // 
            this.fromDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateInput.Location = new System.Drawing.Point(576, 83);
            this.fromDateInput.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fromDateInput.Name = "fromDateInput";
            this.fromDateInput.Size = new System.Drawing.Size(200, 22);
            this.fromDateInput.TabIndex = 0;
            this.fromDateInput.Value = new System.DateTime(2025, 4, 11, 0, 0, 0, 0);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "NHAP",
            "XUAT"});
            this.typeComboBox.Location = new System.Drawing.Point(260, 85);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 1;
            // 
            // toDateInput
            // 
            this.toDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateInput.Location = new System.Drawing.Point(950, 83);
            this.toDateInput.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.toDateInput.Name = "toDateInput";
            this.toDateInput.Size = new System.Drawing.Size(200, 22);
            this.toDateInput.TabIndex = 2;
            this.toDateInput.Value = new System.DateTime(2025, 4, 11, 0, 0, 0, 0);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(599, 191);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(94, 29);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Xem báo cáo";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(12, 12);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(111, 44);
            this.returnBtn.TabIndex = 4;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn loại thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đến ngày";
            // 
            // FormSelectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.toDateInput);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.fromDateInput);
            this.Name = "FormSelectDetail";
            this.Text = "FormSelectDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDateInput;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.DateTimePicker toDateInput;
        private DevExpress.XtraEditors.SimpleButton submitBtn;
        private DevExpress.XtraEditors.SimpleButton returnBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}