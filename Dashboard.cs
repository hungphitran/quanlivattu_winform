using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QLVT;

namespace quanlyvattu
{
    public class Dashboard : Form
    {
        FormBaoCao baocao;
        Label label1;
        Label labelControl1;
        Label labelName;
        Panel headerPanel, mainPanel, leftPanel, rightPanel, statusPanel;

        Button btnLogOut, btnNhanvien, VattuBtn, importBtn, exportBtn, orderBtn;
        Button creatAccBtn, ImAndExportBtn, backupBtn, changePassBtn, tongHopNhapXuatBtn;

        public Dashboard()
        {
            InitUI();
            LoadLogic();
        }

        private void InitUI()
        {
            // Cấu hình Form chính
            this.Text = "Dashboard - Quản Lý Vật Tư";
            this.Size = new Size(1300, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(248, 249, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Header Panel với gradient đ
            headerPanel = new Panel()
            {
                Size = new Size(1300, 120),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(220, 38, 38),
                Dock = DockStyle.Top
            };
            headerPanel.Paint += HeaderPanel_Paint;
            this.Controls.Add(headerPanel);

            // Status Panel (thanh dưới header)
            statusPanel = new Panel()
            {
                Size = new Size(1300, 6),
                Location = new Point(0, 120),
                BackColor = Color.FromArgb(252, 211, 77),
                Dock = DockStyle.Top
            };
            this.Controls.Add(statusPanel);

            // Main Panel
            mainPanel = new Panel()
            {
                Location = new Point(0, 126),
                Size = new Size(1300, 624),
                BackColor = Color.FromArgb(248, 249, 250),
                Dock = DockStyle.Fill
            };
            this.Controls.Add(mainPanel);

            // Left Panel với shadow effect
            leftPanel = new Panel()
            {
                Location = new Point(80, 180),
                Size = new Size(560, 450),
                BackColor = Color.White,
                Parent = mainPanel
            };
            leftPanel.Paint += ModernPanel_Paint;
            mainPanel.Controls.Add(leftPanel);

            // Right Panel với shadow effect
            rightPanel = new Panel()
            {
                Location = new Point(650, 180),
                Size = new Size(560, 450),
                BackColor = Color.White,
                Parent = mainPanel
            };
            rightPanel.Paint += ModernPanel_Paint;
            mainPanel.Controls.Add(rightPanel);


            label1 = new Label()
            {
                Text = "🏢 QUẢN LÝ VẬT TƯ",
                Font = new Font("Segoe UI", 26, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(60, 40),
                Parent = headerPanel
            };
            headerPanel.Controls.Add(label1);

       
           Panel userInfoPanel = new Panel()
           {
               Size = new Size(300, 60),
               Location = new Point(800, 30),
               BackColor = Color.FromArgb(40, 255, 255, 255),
               Parent = headerPanel
           };
            userInfoPanel.Paint += UserInfoPanel_Paint;
            headerPanel.Controls.Add(userInfoPanel);

            labelControl1 = new Label()
            {
                Text = "👤 Người dùng:",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(15, 10),
                Parent = userInfoPanel
            };
            labelName = new Label()
            {
                Text = Program.mHoten,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(252, 211, 77),
                AutoSize = true,
                Location = new Point(15, 32),
                Parent = userInfoPanel
            };
            userInfoPanel.Controls.Add(labelControl1);
            userInfoPanel.Controls.Add(labelName);

            // Logout button với design mới
            btnLogOut = CreateHeaderButton("🚪 Đăng xuất", 1130, 45);
            headerPanel.Controls.Add(btnLogOut);

            // Section headers với icon và màu sắc mới
            Panel leftHeaderPanel = new Panel()
            {
                Size = new Size(520, 50),
                Location = new Point(20, 15),
                BackColor = Color.FromArgb(239, 68, 68),
                Parent = leftPanel
            };
            leftHeaderPanel.Paint += SectionHeader_Paint;
            leftPanel.Controls.Add(leftHeaderPanel);

            Label leftSectionLabel = new Label()
            {
                Text = "⚙️ QUẢN LÝ HỆ THỐNG",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 15),
                Parent = leftHeaderPanel
            };
            leftHeaderPanel.Controls.Add(leftSectionLabel);

            Panel rightHeaderPanel = new Panel()
            {
                Size = new Size(520, 50),
                Location = new Point(20, 15),
                BackColor = Color.FromArgb(239, 68, 68),
                Parent = rightPanel
            };
            rightHeaderPanel.Paint += SectionHeader_Paint;
            rightPanel.Controls.Add(rightHeaderPanel);

            Label rightSectionLabel = new Label()
            {
                Text = "📊 NGHIỆP VỤ & BÁO CÁO",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 15),
                Parent = rightHeaderPanel
            };
            rightHeaderPanel.Controls.Add(rightSectionLabel);

            // Create buttons với design mới
            btnNhanvien = CreateModernRedButton("👥 Quản lý nhân viên", 40, 90, leftPanel);
            VattuBtn = CreateModernRedButton("📦 Quản lý vật tư", 40, 160, leftPanel);
            backupBtn = CreateModernRedButton("💾 Sao lưu phục hồi", 40, 230, leftPanel);
            creatAccBtn = CreateModernRedButton("🔑 Tạo tài khoản", 40, 300, leftPanel);
            changePassBtn = CreateModernRedButton("🔒 Đổi mật khẩu", 40, 370, leftPanel);

            exportBtn = CreateModernRedButton("📤 Phiếu xuất", 40, 90, rightPanel);
            importBtn = CreateModernRedButton("📥 Phiếu nhập", 40, 160, rightPanel);
            orderBtn = CreateModernRedButton("🛒 Đơn đặt hàng", 40, 230, rightPanel);
            ImAndExportBtn = CreateModernRedButton("📋 Báo cáo nhập xuất chi tiết", 40, 300, rightPanel);
            tongHopNhapXuatBtn = CreateModernRedButton("📈 Tổng hợp nhập xuất", 40, 370, rightPanel);

            // Gán sự kiện click (giữ nguyên logic)
            btnLogOut.Click += btnLogOut_Click;
            btnNhanvien.Click += btnNhanvien_Click;
            VattuBtn.Click += VattuBtn_Click;
            importBtn.Click += importBtn_Click;
            exportBtn.Click += exportBtn_Click;
            orderBtn.Click += orderBtn_Click;
            creatAccBtn.Click += creatAccBtn_Click;
            ImAndExportBtn.Click += ImAndExportBtn_Click;
            backupBtn.Click += backupBtn_Click;
            changePassBtn.Click += changePassBtn_Click;
            tongHopNhapXuatBtn.Click += tongHopNhapXuatBtn_Click;
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Gradient từ đỏ đậm đến đỏ nhạt
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0), new Point(0, panel.Height),
                Color.FromArgb(220, 38, 38), Color.FromArgb(239, 68, 68)))
            {
                g.FillRectangle(brush, 0, 0, panel.Width, panel.Height);
            }

            // Thêm pattern decoration
            using (Pen pen = new Pen(Color.FromArgb(50, 255, 255, 255), 1))
            {
                for (int i = 0; i < panel.Width; i += 30)
                {
                    g.DrawLine(pen, i, 0, i + 15, panel.Height);
                }
            }
        }

        private void ModernPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Tạo shadow effect
            Rectangle shadowRect = new Rectangle(8, 8, panel.Width - 8, panel.Height - 8);
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
            {
                GraphicsPath shadowPath = GetRoundedRectangle(shadowRect, 20);
                g.FillPath(shadowBrush, shadowPath);
            }

            // Main panel
            Rectangle rect = new Rectangle(0, 0, panel.Width - 8, panel.Height - 8);
            GraphicsPath path = GetRoundedRectangle(rect, 20);

            // Fill với gradient nhẹ
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, Color.White, Color.FromArgb(252, 252, 252), 45f))
            {
                g.FillPath(brush, path);
            }

            // Border với màu đỏ nhạt
            using (Pen pen = new Pen(Color.FromArgb(254, 202, 202), 2))
            {
                g.DrawPath(pen, path);
            }
        }

        private void UserInfoPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            GraphicsPath path = GetRoundedRectangle(rect, 12);

            using (SolidBrush brush = new SolidBrush(panel.BackColor))
            {
                g.FillPath(brush, path);
            }

            using (Pen pen = new Pen(Color.FromArgb(100, 255, 255, 255), 1))
            {
                g.DrawPath(pen, path);
            }
        }

        private void SectionHeader_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            GraphicsPath path = GetRoundedRectangle(rect, 12);

            // Gradient cho section header
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, Color.FromArgb(239, 68, 68), Color.FromArgb(220, 38, 38), 45f))
            {
                g.FillPath(brush, path);
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void LoadLogic()
        {
            
            if (Program.mGroup.Equals("NhanVienRole"))
            {
                backupBtn.Visible = false;
                creatAccBtn.Visible = false;
                tongHopNhapXuatBtn.Visible = false;

                changePassBtn.Location = new Point(40, 230);
            }
        }

        private Button CreateHeaderButton(string text, int x, int y)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Size = new Size(140, 40);
            btn.Location = new Point(x, y);
            btn.BackColor = Color.FromArgb(252, 211, 77);
            btn.ForeColor = Color.FromArgb(120, 53, 15);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(245, 158, 11);
                btn.ForeColor = Color.White;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(252, 211, 77);
                btn.ForeColor = Color.FromArgb(120, 53, 15);
            };

            btn.Paint += (s, e) =>
            {
                Button button = s as Button;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, button.Width - 1, button.Height - 1);
                GraphicsPath path = GetRoundedRectangle(rect, 10);

                using (SolidBrush brush = new SolidBrush(button.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Thêm inner shadow
                using (Pen pen = new Pen(Color.FromArgb(50, 0, 0, 0), 1))
                {
                    Rectangle innerRect = new Rectangle(1, 1, button.Width - 3, button.Height - 3);
                    GraphicsPath innerPath = GetRoundedRectangle(innerRect, 9);
                    g.DrawPath(pen, innerPath);
                }

                TextRenderer.DrawText(g, button.Text, button.Font, rect, button.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            return btn;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private Button CreateModernRedButton(string text, int x, int y, Panel parent)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btn.Size = new Size(480, 60);
            btn.Location = new Point(x, y);
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(55, 65, 81);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(25, 0, 0, 0);
            btn.Parent = parent;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(239, 68, 68);
                btn.ForeColor = Color.White;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(55, 65, 81);
            };

            btn.Paint += (s, e) =>
            {
                Button button = s as Button;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, button.Width - 1, button.Height - 1);
                GraphicsPath path = GetRoundedRectangle(rect, 12);

                // Background với gradient nhẹ
                if (button.BackColor == Color.White)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        rect, Color.White, Color.FromArgb(248, 249, 250), 90f))
                    {
                        g.FillPath(brush, path);
                    }

                    // Border
                    using (Pen pen = new Pen(Color.FromArgb(254, 202, 202), 2))
                    {
                        g.DrawPath(pen, path);
                    }

                    // Left accent border
                    using (Pen accentPen = new Pen(Color.FromArgb(239, 68, 68), 4))
                    {
                        g.DrawLine(accentPen, 2, 10, 2, button.Height - 10);
                    }
                }
                else
                {
                    // Hover state với gradient đỏ
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        rect, Color.FromArgb(239, 68, 68), Color.FromArgb(220, 38, 38), 45f))
                    {
                        g.FillPath(brush, path);
                    }

                    // Yellow accent khi hover
                    using (Pen accentPen = new Pen(Color.FromArgb(252, 211, 77), 4))
                    {
                        g.DrawLine(accentPen, 2, 10, 2, button.Height - 10);
                    }
                }

                Rectangle textRect = new Rectangle(button.Padding.Left, 0,
                    button.Width - button.Padding.Left, button.Height);
                TextRenderer.DrawText(g, button.Text, button.Font, textRect, button.ForeColor,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            };

            parent.Controls.Add(btn);
            return btn;
        }

        // Giữ nguyên tất cả logic events
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.mlogin = "";
            Program.password = "";
            Program.mGroup = "";
            Program.mHoten = "";
            Program.conn.Close();
            FormManager.switchForm(this, new LoginForm());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormNhanVien());
        }

        private void VattuBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormVatTu());
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormPhieuNhap());
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormPhieuXuat());
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormDatHang());
        }

        private void creatAccBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormTaoAcc());
        }

        private void ImAndExportBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormSelectDetail());
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new BackupRestoreForm());
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormDoiMatKhau());
        }

        private void tongHopNhapXuatBtn_Click(object sender, EventArgs e)
        {
            
            Form dateRangeForm = new Form();
            dateRangeForm.Text = "Chọn khoảng thời gian";
            dateRangeForm.Size = new Size(500, 280);
            dateRangeForm.StartPosition = FormStartPosition.CenterScreen;
            dateRangeForm.FormBorderStyle = FormBorderStyle.None;
            dateRangeForm.MaximizeBox = false;
            dateRangeForm.MinimizeBox = false;
            dateRangeForm.BackColor = Color.FromArgb(248, 249, 250);

            // Create main panel for the dialog
            Panel dialogPanel = new Panel()
            {
                Size = new Size(480, 260),
                Location = new Point(10, 10),
                BackColor = Color.White,
                Parent = dateRangeForm
            };
            dialogPanel.Paint += (s, paintArgs) =>
            {
                Graphics g = paintArgs.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Shadow
                Rectangle shadowRect = new Rectangle(5, 5, dialogPanel.Width - 5, dialogPanel.Height - 5);
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
                {
                    GraphicsPath shadowPath = GetRoundedRectangle(shadowRect, 20);
                    g.FillPath(shadowBrush, shadowPath);
                }

                // Main dialog
                Rectangle rect = new Rectangle(0, 0, dialogPanel.Width - 5, dialogPanel.Height - 5);
                GraphicsPath path = GetRoundedRectangle(rect, 20);

                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    g.FillPath(brush, path);
                }
                using (Pen pen = new Pen(Color.FromArgb(239, 68, 68), 3))
                {
                    g.DrawPath(pen, path);
                }
            };

            // Header panel cho dialog
            Panel dialogHeaderPanel = new Panel()
            {
                Size = new Size(460, 60),
                Location = new Point(10, 10),
                BackColor = Color.FromArgb(239, 68, 68),
                Parent = dialogPanel
            };
            dialogHeaderPanel.Paint += (s, paintArgs) =>
            {
                Graphics g = paintArgs.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, dialogHeaderPanel.Width - 1, dialogHeaderPanel.Height - 1);
                GraphicsPath path = GetRoundedRectangle(rect, 15);

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect, Color.FromArgb(239, 68, 68), Color.FromArgb(220, 38, 38), 45f))
                {
                    g.FillPath(brush, path);
                }
            };
            dialogPanel.Controls.Add(dialogHeaderPanel);

            // Title
            Label titleLabel = new Label()
            {
                Text = "📅 Chọn khoảng thời gian báo cáo",
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(70, 20),
                Parent = dialogHeaderPanel
            };
            dialogHeaderPanel.Controls.Add(titleLabel);

            Label fromLabel = new Label()
            {
                Text = "📅 Từ ngày:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(239, 68, 68),
                Location = new Point(50, 100),
                Size = new Size(100, 25),
                Parent = dialogPanel
            };
            DateTimePicker fromDatePicker = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Font = new Font("Segoe UI", 12),
                Location = new Point(170, 100),
                Size = new Size(250, 30),
                MaxDate = DateTime.Now,
                MinDate = new DateTime(2020, 1, 1),
                Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                Parent = dialogPanel
            };

            Label toLabel = new Label()
            {
                Text = "📅 Đến ngày:",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(239, 68, 68),
                Location = new Point(50, 150),
                Size = new Size(100, 25),
                Parent = dialogPanel
            };
            DateTimePicker toDatePicker = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                Font = new Font("Segoe UI", 12),
                Location = new Point(170, 150),
                Size = new Size(250, 30),
                MaxDate = DateTime.Now,
                MinDate = new DateTime(2020, 1, 1),
                Value = DateTime.Now,
                Parent = dialogPanel
            };

            Button submitBtn = CreateModernDialogButton("📊 Xem báo cáo", 120, 200, dialogPanel);
            Button cancelBtn = CreateModernDialogButton("❌ Hủy", 280, 200, dialogPanel, true);

            submitBtn.Click += (s, ev) =>
            {
                this.Enabled = false; // Disable the main form while processing
                
               Console.WriteLine("submit");
                if (fromDatePicker.Value > toDatePicker.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fromDate = fromDatePicker.Value, toDate = toDatePicker.Value;
                dateRangeForm.Close();
                if (this.baocao != null)
                {
                    this.baocao.Close();
                    this.baocao = null;
                }
                try
                {

                    TongHopNhapXuat report = new TongHopNhapXuat(fromDate, toDate);
                    if (!Program.hasData(report))
                    {
                        MessageBox.Show("Không có dữ liệu trong khoảng thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Enabled = true; // Re-enable the main form
                        return;
                    }
                    this.baocao = new FormBaoCao(report);
                    this.baocao.FormClosed += (s2, args) => this.Enabled = true; // Re-enable the main form when report is closed
                    this.baocao.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            cancelBtn.Click += (s, ev) => dateRangeForm.Close();

            dialogPanel.Controls.Add(fromLabel);
            dialogPanel.Controls.Add(fromDatePicker);
            dialogPanel.Controls.Add(toLabel);
            dialogPanel.Controls.Add(toDatePicker);
            dateRangeForm.Controls.Add(dialogPanel);
            dateRangeForm.ShowDialog();
        }

        private Button CreateModernDialogButton(string text, int x, int y, Panel parent, bool isCancel = false)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Size = new Size(140, 40);
            btn.Location = new Point(x, y);
            btn.BackColor = isCancel ? Color.FromArgb(156, 163, 175) : Color.FromArgb(239, 68, 68);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Parent = parent;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = isCancel ? Color.FromArgb(107, 114, 128) : Color.FromArgb(252, 211, 77);
                if (!isCancel) btn.ForeColor = Color.FromArgb(120, 53, 15);
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = isCancel ? Color.FromArgb(156, 163, 175) : Color.FromArgb(239, 68, 68);
                if (!isCancel) btn.ForeColor = Color.White;
            };

            btn.Paint += (s, e) =>
            {
                Button button = s as Button;
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, button.Width - 1, button.Height - 1);
                GraphicsPath path = GetRoundedRectangle(rect, 10);

                if (!isCancel && button.BackColor != Color.FromArgb(252, 211, 77))
                {
                    // Red gradient for primary button
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        rect, Color.FromArgb(239, 68, 68), Color.FromArgb(220, 38, 38), 45f))
                    {
                        g.FillPath(brush, path);
                    }
                }
                else
                {
                    using (SolidBrush brush = new SolidBrush(button.BackColor))
                    {
                        g.FillPath(brush, path);
                    }
                }

                // Add subtle shadow for depth
                if (!isCancel)
                {
                    using (Pen shadowPen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                    {
                        Rectangle shadowRect = new Rectangle(1, 1, button.Width - 2, button.Height - 2);
                        GraphicsPath shadowPath = GetRoundedRectangle(shadowRect, 9);
                        g.DrawPath(shadowPen, shadowPath);
                    }
                }

                TextRenderer.DrawText(g, button.Text, button.Font, rect, button.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            parent.Controls.Add(btn);
            return btn;
        }
    }
}