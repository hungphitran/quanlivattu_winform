namespace quanlyvattu
{
    partial class BackupRestoreForm
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
            this.backupBtn = new DevExpress.XtraEditors.SimpleButton();
            this.returnBtn = new DevExpress.XtraEditors.SimpleButton();
            this.restoreBtn = new DevExpress.XtraEditors.SimpleButton();
            this.createDeviceBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deviceCb = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deviceNameInput = new DevExpress.XtraEditors.TextEdit();
            this.sp_DanhSachBackUpDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_DanhSachBackUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlvtDataSet = new quanlyvattu.qlvtDataSet();
            this.tableAdapterManager = new quanlyvattu.qlvtDataSetTableAdapters.TableAdapterManager();
            this.sp_DanhSachBackUpTableAdapter = new quanlyvattu.qlvtDataSetTableAdapters.sp_DanhSachBackUpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceNameInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Location = new System.Drawing.Point(706, 16);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(158, 44);
            this.backupBtn.TabIndex = 2;
            this.backupBtn.Text = "Sao lưu dữ liệu";
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(27, 16);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(94, 44);
            this.returnBtn.TabIndex = 3;
            this.returnBtn.Text = "Quay lại";
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(896, 16);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(232, 44);
            this.restoreBtn.TabIndex = 15;
            this.restoreBtn.Text = "Phục hồi về phiên bản đang chọn";
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // createDeviceBtn
            // 
            this.createDeviceBtn.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.createDeviceBtn.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.createDeviceBtn.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 9F);
            this.createDeviceBtn.AppearanceDisabled.Options.UseBackColor = true;
            this.createDeviceBtn.AppearanceDisabled.Options.UseFont = true;
            this.createDeviceBtn.Location = new System.Drawing.Point(106, 148);
            this.createDeviceBtn.Name = "createDeviceBtn";
            this.createDeviceBtn.Size = new System.Drawing.Size(148, 44);
            this.createDeviceBtn.TabIndex = 16;
            this.createDeviceBtn.Text = "Tạo device sao lưu";
            this.createDeviceBtn.Click += new System.EventHandler(this.createDeviceBtn_Click);
            // 
            // deviceCb
            // 
            this.deviceCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceCb.FormattingEnabled = true;
            this.deviceCb.Location = new System.Drawing.Point(380, 22);
            this.deviceCb.Name = "deviceCb";
            this.deviceCb.Size = new System.Drawing.Size(129, 24);
            this.deviceCb.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(291, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Chọn device";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.deviceNameInput);
            this.groupControl1.Controls.Add(this.createDeviceBtn);
            this.groupControl1.Location = new System.Drawing.Point(3, 391);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 217);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Tạo device";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(194, 21);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Nhập tên device muốn tạo";
            // 
            // deviceNameInput
            // 
            this.deviceNameInput.Location = new System.Drawing.Point(106, 88);
            this.deviceNameInput.Name = "deviceNameInput";
            this.deviceNameInput.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deviceNameInput.Properties.Appearance.Options.UseFont = true;
            this.deviceNameInput.Properties.MaxLength = 20;
            this.deviceNameInput.Size = new System.Drawing.Size(148, 28);
            this.deviceNameInput.TabIndex = 17;
            // 
            // sp_DanhSachBackUpDataGridView
            // 
            this.sp_DanhSachBackUpDataGridView.AutoGenerateColumns = false;
            this.sp_DanhSachBackUpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_DanhSachBackUpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_DanhSachBackUpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sp_DanhSachBackUpDataGridView.DataSource = this.sp_DanhSachBackUpBindingSource;
            this.sp_DanhSachBackUpDataGridView.Location = new System.Drawing.Point(3, 78);
            this.sp_DanhSachBackUpDataGridView.Name = "sp_DanhSachBackUpDataGridView";
            this.sp_DanhSachBackUpDataGridView.RowHeadersWidth = 51;
            this.sp_DanhSachBackUpDataGridView.RowTemplate.Height = 24;
            this.sp_DanhSachBackUpDataGridView.Size = new System.Drawing.Size(1198, 307);
            this.sp_DanhSachBackUpDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "backup_finish_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày sao lưu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "backup_size_mb";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kích thước";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "physical_device_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Thiết bị sao lưu";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "backed_up_by";
            this.dataGridViewTextBoxColumn8.HeaderText = "Người sao lưu";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // sp_DanhSachBackUpBindingSource
            // 
            this.sp_DanhSachBackUpBindingSource.DataMember = "sp_DanhSachBackUp";
            this.sp_DanhSachBackUpBindingSource.DataSource = this.qlvtDataSet;
            // 
            // qlvtDataSet
            // 
            this.qlvtDataSet.DataSetName = "qlvtDataSet";
            this.qlvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sp_DanhSachBackUpTableAdapter
            // 
            this.sp_DanhSachBackUpTableAdapter.ClearBeforeFill = true;
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 628);
            this.Controls.Add(this.sp_DanhSachBackUpDataGridView);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deviceCb);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.backupBtn);
            this.Name = "BackupRestoreForm";
            this.Text = "BackupRestoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceNameInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DanhSachBackUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvtDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton backupBtn;
        private qlvtDataSet qlvtDataSet;
        private System.Windows.Forms.BindingSource sp_DanhSachBackUpBindingSource;
        private qlvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevExpress.XtraEditors.SimpleButton returnBtn;
        private DevExpress.XtraEditors.SimpleButton restoreBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.SimpleButton createDeviceBtn;
        private System.Windows.Forms.ComboBox deviceCb;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit deviceNameInput;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private qlvtDataSetTableAdapters.sp_DanhSachBackUpTableAdapter sp_DanhSachBackUpTableAdapter;
        private System.Windows.Forms.DataGridView sp_DanhSachBackUpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}