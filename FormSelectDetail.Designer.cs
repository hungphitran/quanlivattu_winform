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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.returnBtn = new DevExpress.XtraEditors.SimpleButton();
            this.submitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDateInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.toDateInput = new System.Windows.Forms.DateTimePicker();
            this.headerPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(833, 65);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(22, 16);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(317, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "XEM BÁO CÁO CHI TIẾT";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.controlPanel.Controls.Add(this.returnBtn);
            this.controlPanel.Controls.Add(this.submitBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 65);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(833, 49);
            this.controlPanel.TabIndex = 1;
            // 
            // returnBtn
            // 
            this.returnBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.returnBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.returnBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Appearance.Options.UseBackColor = true;
            this.returnBtn.Appearance.Options.UseFont = true;
            this.returnBtn.Appearance.Options.UseForeColor = true;
            this.returnBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(104)))));
            this.returnBtn.AppearanceHovered.Options.UseBackColor = true;
            this.returnBtn.Location = new System.Drawing.Point(22, 12);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(90, 24);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "◄ Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.submitBtn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.submitBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Appearance.Options.UseBackColor = true;
            this.submitBtn.Appearance.Options.UseFont = true;
            this.submitBtn.Appearance.Options.UseForeColor = true;
            this.submitBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(67)))));
            this.submitBtn.AppearanceHovered.Options.UseBackColor = true;
            this.submitBtn.Location = new System.Drawing.Point(688, 12);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(90, 24);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Xem báo cáo";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.Color.White;
            this.inputPanel.Controls.Add(this.groupBoxFilter);
            this.inputPanel.Location = new System.Drawing.Point(22, 130);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(786, 146);
            this.inputPanel.TabIndex = 2;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.White;
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.typeComboBox);
            this.groupBoxFilter.Controls.Add(this.label2);
            this.groupBoxFilter.Controls.Add(this.fromDateInput);
            this.groupBoxFilter.Controls.Add(this.label3);
            this.groupBoxFilter.Controls.Add(this.toDateInput);
            this.groupBoxFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBoxFilter.Location = new System.Drawing.Point(15, 16);
            this.groupBoxFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFilter.Size = new System.Drawing.Size(741, 114);
            this.groupBoxFilter.TabIndex = 0;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "BỘ LỌC BÁO CÁO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn loại thống kê";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "NHAP",
            "XUAT"});
            this.typeComboBox.Location = new System.Drawing.Point(205, 29);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(139, 23);
            this.typeComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(419, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày";
            // 
            // fromDateInput
            // 
            this.fromDateInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fromDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateInput.Location = new System.Drawing.Point(509, 27);
            this.fromDateInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromDateInput.MaxDate = new System.DateTime(2025, 12, 25, 23, 59, 59, 0);
            this.fromDateInput.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.fromDateInput.Name = "fromDateInput";
            this.fromDateInput.Size = new System.Drawing.Size(136, 23);
            this.fromDateInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến ngày";
            // 
            // toDateInput
            // 
            this.toDateInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateInput.Location = new System.Drawing.Point(120, 71);
            this.toDateInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toDateInput.MaxDate = new System.DateTime(2025, 12, 25, 23, 59, 59, 0);
            this.toDateInput.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.toDateInput.Name = "toDateInput";
            this.toDateInput.Size = new System.Drawing.Size(136, 23);
            this.toDateInput.TabIndex = 5;
            // 
            // FormSelectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(833, 425);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormSelectDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Báo Cáo Chi Tiết";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel controlPanel;
        private DevExpress.XtraEditors.SimpleButton returnBtn;
        private DevExpress.XtraEditors.SimpleButton submitBtn;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDateInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker toDateInput;
    }
}