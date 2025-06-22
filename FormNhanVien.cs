using DevExpress.XtraLayout.Filtering.Templates;
using QLVT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyvattu
{
    public partial class FormNhanVien : Form
    {
        FormBaoCao formBaoCao = null;
        public FormNhanVien()
        {
            InitializeComponent();

            this.searchInput.KeyPress += KeyPressConstraint.KeyPress_LettersDigitsSpace;
            this.searchInput.Properties.MaxLength = 30;

            this.manvInput.KeyPress += manvInput_KeyPress;
            this.cmndInput.KeyPress += cmndInput_KeyPress;
            this.hoInput.KeyPress += hoInput_KeyPress;
            this.hoInput.TextChanged += hoInput_TextChanged;
            this.tenInput.KeyPress += tenInput_KeyPress;
            this.luongInput.KeyPress += luongInput_KeyPress;

            // Đặt mặc định ngày sinh là ngày hôm qua của 18 năm trước khi mở form
            this.ngaysinhInput.DateTime = DateTime.Now.AddYears(-18).AddDays(-1);
            this.ngaysinhInput.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngaysinhInput.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngaysinhInput.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.ngaysinhInput.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngaysinhInput.Properties.Mask.EditMask = "dd/MM/yyyy";

            // Không cho nhập 2 dấu cách liên tiếp ở địa chỉ
            this.diachiInput.KeyPress += diachiInput_KeyPress;
            this.diachiInput.TextChanged += diachiInput_TextChanged;

            // Thêm sự kiện để chặn nhập text vào NGAYSINH và LUONG trên DataGridView
            this.nhanvienDataGridView.EditingControlShowing += nhanvienDataGridView_EditingControlShowing;

            // Logic nhập tên nhân viên giống tên khách hàng ở phiếu xuất
            this.tenInput.KeyPress += tenInput_KeyPress;
            this.tenInput.TextChanged += tenInput_TextChanged;
        }

        Stack<UndoAction> undoStack = new Stack<UndoAction>();
        private string currentFilter = null;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlvtDataSet);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.Nhanvien' table. You can move, or remove it, as needed.
            // Load dữ liệu từ CSDL
            nhanvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvienTableAdapter.Fill(this.qlvtDataSet.Nhanvien);
            nhanvienBindingSource.DataSource = qlvtDataSet.Nhanvien;

            // Đăng ký sự kiện
            this.nhanvienDataGridView.CellValueChanged += NhanvienDataGridView_CellValueChanged;
            this.nhanvienDataGridView.CellBeginEdit += NhanvienDataGridView_CellBeginEdit;

            // Đảm bảo cột NGAYSINH là CalendarColumn (nếu columns bị reset)
            if (!(nhanvienDataGridView.Columns[5] is DataGridViewCalendarColumn))
            {
                nhanvienDataGridView.Columns.RemoveAt(5);
                var calendarCol = new DataGridViewCalendarColumn();
                calendarCol.DataPropertyName = "NGAYSINH";
                calendarCol.HeaderText = "NGÀY SINH";
                calendarCol.Name = "dataGridViewCalendarColumn_NGAYSINH";
                calendarCol.DefaultCellStyle.Format = "dd/MM/yyyy";
                nhanvienDataGridView.Columns.Insert(5, calendarCol);
            }
            // Đảm bảo cột LUONG luôn tồn tại ở vị trí 6
            bool foundLuong = false;
            foreach (DataGridViewColumn col in nhanvienDataGridView.Columns)
            {
                if (col.DataPropertyName == "LUONG") { foundLuong = true; break; }
            }
            if (!foundLuong)
            {
                var luongCol = new DataGridViewTextBoxColumn();
                luongCol.DataPropertyName = "LUONG";
                luongCol.HeaderText = "LƯƠNG";
                luongCol.Name = "dataGridViewTextBoxColumn7";
                luongCol.MinimumWidth = 6;
                nhanvienDataGridView.Columns.Insert(6, luongCol);
            }
        }

        private void NhanvienDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataRowView rowView = (DataRowView)nhanvienDataGridView.CurrentRow.DataBoundItem;
            DataRow row = rowView.Row;

            int columnIndex = e.ColumnIndex;

            int index = nhanvienBindingSource.Position;
            if (currentFilter != null)
            {
                String manv = row["MANV"].ToString();
                nhanvienBindingSource.RemoveFilter();
                searchInput.Text = "";

                index = nhanvienBindingSource.Find("MANV", manv);
                nhanvienBindingSource.Filter = currentFilter;
                nhanvienBindingSource.Position = nhanvienBindingSource.Find("MANV", manv);
            }

            // Đặt lại focus ô đang edit
            nhanvienDataGridView.CurrentCell = nhanvienDataGridView.Rows[nhanvienBindingSource.Position].Cells[columnIndex];

            // Lưu giá trị cũ vào undoStack
            undoStack.Push(
                new UndoAction
                {
                    Action = ActionType.Update,
                    OldItemArray = row.ItemArray,
                    NewItemArray = null,
                    index = index
                }
            );
        }

        private void nhanvienDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Xác định cột đang edit
            int col = nhanvienDataGridView.CurrentCell.ColumnIndex;
            // NGAYSINH (cột 5): chỉ cho nhập ngày, không cho nhập text
            if (col == 5)
            {
                // Nếu là TextBox thì chặn mọi phím nhập, chỉ cho dùng DatePicker
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= BlockAllKeyPress; // tránh đăng ký nhiều lần
                    tb.KeyPress += BlockAllKeyPress;
                }
            }
            // LUONG (cột 6): chỉ cho nhập số
            else if (col == 6)
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= KeyPress_OnlyDigits;
                    tb.KeyPress += KeyPress_OnlyDigits;
                }
            }
        }

        private void BlockAllKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void KeyPress_OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NhanvienDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu không có dòng đang chọn thì bỏ qua
            if (nhanvienDataGridView.CurrentRow == null) return;

            DataRowView rowView = (DataRowView)nhanvienDataGridView.CurrentRow.DataBoundItem;
            DataRow row = rowView.Row;
            int currentRowIndex = nhanvienDataGridView.CurrentCell.RowIndex;

            // Kiểm tra trùng CMND khi sửa cột CMND 
            if (e.ColumnIndex == 1)// cột CMND
            {
                string cmnd = row["CMND"].ToString().Trim();
                nhanvienBindingSource.RemoveFilter();
                searchInput.Text = "";

                DataRow[] existingRows = qlvtDataSet.Nhanvien.Select($"CMND = '{cmnd}' AND MANV <> '{row["MANV"]}'");
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("CMND này đã tồn tại, không thể cập nhật.");
                    row.ItemArray = undoStack.Pop().OldItemArray;
                    nhanvienBindingSource.Position = currentRowIndex;
                    nhanvienDataGridView.CurrentCell = nhanvienDataGridView.Rows[currentRowIndex].Cells[e.ColumnIndex];
                    return;
                }
            }

            // Kiểm tra NGAYSINH (cột 5)
            if (e.ColumnIndex == 5) // NGAYSINH
            {
                object value = row["NGAYSINH"];
                DateTime ngaysinh;
                if (value == DBNull.Value || value == null || !DateTime.TryParse(value.ToString(), out ngaysinh))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng nhập đúng định dạng ngày.");
                    row.ItemArray = undoStack.Pop().OldItemArray;
                    nhanvienBindingSource.Position = currentRowIndex;
                    nhanvienDataGridView.CurrentCell = nhanvienDataGridView.Rows[currentRowIndex].Cells[e.ColumnIndex];
                    return;
                }
                if (ngaysinh > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không thể là ngày trong tương lai!");
                    row.ItemArray = undoStack.Pop().OldItemArray;
                    nhanvienBindingSource.Position = currentRowIndex;
                    nhanvienDataGridView.CurrentCell = nhanvienDataGridView.Rows[currentRowIndex].Cells[e.ColumnIndex];
                    return;
                }
                int age = DateTime.Now.Year - ngaysinh.Year;
                if (ngaysinh > DateTime.Now.AddYears(-age)) age--; // chính xác tuổi
                if (age < 18)
                {
                    MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!");
                    row.ItemArray = undoStack.Pop().OldItemArray;
                    nhanvienBindingSource.Position = currentRowIndex;
                    nhanvienDataGridView.CurrentCell = nhanvienDataGridView.Rows[currentRowIndex].Cells[e.ColumnIndex];
                    return;
                }
            }

            // Kiểm tra LUONG (cột 6)
            if (e.ColumnIndex == 6) // LUONG
            {
                object value = row["LUONG"];
                double luong;
                if (value == DBNull.Value || value == null || !double.TryParse(value.ToString(), out luong))
                {
                    MessageBox.Show("Lương phải là số hợp lệ!");
                    row.ItemArray = undoStack.Pop().OldItemArray;
                    nhanvienBindingSource.Position = currentRowIndex;
                    nhanvienDataGridView.CurrentCell = nhanvienDataGridView.Rows[currentRowIndex].Cells[e.ColumnIndex];
                    return;
                }
                if (luong < 7000000)
                {
                    MessageBox.Show("Lương phải từ 7.000.000 đồng trở lên!");
                    row.ItemArray = undoStack.Pop().OldItemArray;
                    nhanvienBindingSource.Position = currentRowIndex;
                    nhanvienDataGridView.CurrentCell = nhanvienDataGridView.Rows[currentRowIndex].Cells[e.ColumnIndex];
                    return;
                }
            }

            // Lưu giá trị mới vào undoStack
            if (undoStack.Count > 0)
            {
                UndoAction pre = undoStack.Pop();
                undoStack.Push(
                    new UndoAction
                    {
                        Action = ActionType.Update,
                        OldItemArray = pre.OldItemArray,
                        NewItemArray = row.ItemArray,
                        index = pre.index
                    }
                );
            }

            row.EndEdit();

            MessageBox.Show("Cập nhật thành công");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("reload");
            this.nhanvienTableAdapter.Fill(this.qlvtDataSet.Nhanvien);
            nhanvienBindingSource.RemoveFilter();
            searchInput.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nhanvienBindingSource.EndEdit();
                nhanvienBindingSource.RemoveFilter();
                searchInput.Text = "";
                int check = this.nhanvienTableAdapter.Update(qlvtDataSet.Nhanvien);
                if (check == 0)
                {
                    throw new Exception();
                }
                else
                {
                    MessageBox.Show("Lưu thành công");
                    Program.ExecSqlNonQuery("use qlvt; exec sp_TaoBackupLog 'qlvt'");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            if (undoStack.Count == 0)
            {
                MessageBox.Show("Không có thao tác nào để phục hồi.");
                return;
            }

            UndoAction action = undoStack.Pop();

            this.nhanvienBindingSource.RemoveFilter();
            searchInput.Text = "";

            switch (action.Action)
            {
                case ActionType.Insert:
                    qlvtDataSet.Nhanvien.Rows.RemoveAt(qlvtDataSet.Nhanvien.Rows.Count - 1);
                    MessageBox.Show("Hoàn tác thao tác thêm thành công.");
                    break;

                case ActionType.Update:
                    DataRow updatedRow = qlvtDataSet.Nhanvien.Rows[action.index];
                    updatedRow.ItemArray = action.OldItemArray;
                    nhanvienBindingSource.Position = action.index;
                    MessageBox.Show("Hoàn tác thao tác cập nhật thành công.");
                    break;

                case ActionType.Delete:
                    DataRow newRow = qlvtDataSet.Nhanvien.NewRow();
                    newRow.ItemArray = action.OldItemArray;
                    qlvtDataSet.Nhanvien.Rows.InsertAt(newRow, action.index);
                    nhanvienBindingSource.Position = action.index;
                    MessageBox.Show("Hoàn tác thao tác xóa thành công.");
                    break;

                default:
                    MessageBox.Show("Không có thao tác nào để phục hồi.");
                    break;
            }

            nhanvienBindingSource.ResetBindings(true);
        }

        private void manvInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
            }
        }

        private void cmndInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block invalid input
            }
        }

        private void hoInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập chữ cái, dấu cách, và phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
            // Không cho nhập 2 dấu cách liên tiếp
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string text = textBox.Text;
            if (e.KeyChar == ' ')
            {
                if (text.Length == 0 || text.EndsWith(" "))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void hoInput_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string text = textBox.Text;
            if (string.IsNullOrEmpty(text)) return;
            // Không cho 2 dấu cách liên tiếp
            while (text.Contains("  "))
                text = text.Replace("  ", " ");
            // Viết hoa chữ cái đầu tiên và sau mỗi dấu cách, còn lại chuyển về thường
            var sb = new StringBuilder();
            bool capitalize = true;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c))
                {
                    if (capitalize)
                    {
                        sb.Append(char.ToUpper(c));
                        capitalize = false;
                    }
                    else
                    {
                        sb.Append(char.ToLower(c));
                    }
                }
                else
                {
                    sb.Append(c);
                    if (c == ' ')
                        capitalize = true;
                }
            }
            string newText = sb.ToString();
            if (textBox.Text != newText)
            {
                int selStart = textBox.SelectionStart;
                int diff = textBox.Text.Length - newText.Length;
                textBox.Text = newText;
                textBox.SelectionStart = Math.Max(0, selStart - diff);
            }
        }

        private void tenInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập chữ cái, dấu cách, và phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                return;
            }
            // Không cho nhập 2 dấu cách liên tiếp
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string text = textBox.Text;
            if (e.KeyChar == ' ')
            {
                if (text.Length == 0 || text.EndsWith(" "))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void tenInput_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string text = textBox.Text;
            if (string.IsNullOrEmpty(text)) return;
            // Không cho 2 dấu cách liên tiếp
            while (text.Contains("  "))
                text = text.Replace("  ", " ");
            // Viết hoa chữ cái đầu tiên và sau mỗi dấu cách, còn lại chuyển về thường
            var sb = new StringBuilder();
            bool capitalize = true;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c))
                {
                    if (capitalize)
                    {
                        sb.Append(char.ToUpper(c));
                        capitalize = false;
                    }
                    else
                    {
                        sb.Append(char.ToLower(c));
                    }
                }
                else
                {
                    sb.Append(c);
                    if (c == ' ')
                        capitalize = true;
                }
            }
            string newText = sb.ToString();
            if (textBox.Text != newText)
            {
                int selStart = textBox.SelectionStart;
                int diff = textBox.Text.Length - newText.Length;
                textBox.Text = newText;
                textBox.SelectionStart = Math.Max(0, selStart - diff);
            }
        }

        private void luongInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block invalid input
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Thêm nhân viên");
            // Lấy giá trị từ các trường nhập liệu
            string manvText = this.manvInput.Text.Trim();
            string cmnd = this.cmndInput.Text.Trim();
            string ho = this.hoInput.Text.Trim();
            string ten = this.tenInput.Text.Trim();
            string diachi = this.diachiInput.Text.Trim(); // Thêm trường địa chỉ
            DateTime? ngaysinh = string.IsNullOrEmpty(this.ngaysinhInput.Text)
                ? DateTime.Now.AddYears(-18).AddDays(-1)
                : this.ngaysinhInput.DateTime;
            string luongText = this.luongInput.Text.Trim();
            string ghichu = this.ghichuInput.Text.Trim();

            // Validate inputs
            if (!ValidateInputs(manvText, cmnd, ho, ten, diachi, ngaysinh, luongText))
            {
                return; // Stop execution if validation fails
            }

            try
            {
                // Remove any filters to ensure all records are checked
                nhanvienBindingSource.RemoveFilter();
                searchInput.Text = "";

                // Kiểm tra MANV đã tồn tại
                DataRow[] existingRows = qlvtDataSet.Nhanvien.Select($"MANV = {manvText}");
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, không thể thêm!");
                    return;
                }

                // Kiểm tra CMND đã tồn tại
                DataRow[] existingCmndRows = qlvtDataSet.Nhanvien.Select($"CMND = '{cmnd}'");
                if (existingCmndRows.Length > 0)
                {
                    MessageBox.Show("CMND này đã tồn tại, không thể thêm!");
                    return;
                }

                // Tạo hàng mới cho bảng NhanVien
                DataRow newRow = qlvtDataSet.Nhanvien.NewRow();
                newRow["MANV"] = int.Parse(manvText);
                newRow["CMND"] = cmnd;
                newRow["HO"] = ho;
                newRow["TEN"] = ten;
                newRow["DIACHI"] = diachi;
                newRow["NGAYSINH"] = ngaysinh.Value;
                newRow["LUONG"] = float.Parse(luongText);
                newRow["GHICHU"] = string.IsNullOrEmpty(ghichu) ? "" : ghichu;
                newRow["TRANGTHAIXOA"] = 0; // Mặc định là 0 (chưa xóa)

                // Thêm hàng vào dataset
                qlvtDataSet.Nhanvien.Rows.Add(newRow);

                // Lưu vào stack để hỗ trợ undo (nếu cần)
                undoStack.Push(
                    new UndoAction
                    {
                        Action = ActionType.Insert,
                        OldItemArray = null,
                        NewItemArray = newRow.ItemArray,
                        index = qlvtDataSet.Nhanvien.Rows.Count - 1
                    }
                );

                // Xóa các trường nhập liệu sau khi thêm thành công
                ClearInputs();

                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        private bool ValidateInputs(string manvText, string cmnd, string ho, string ten, string diachi, DateTime? ngaysinh, string luongText)
        {
            // Validate MANV
            if (!int.TryParse(manvText, out int manv) || manv <= 0)
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên dương hợp lệ!");
                return false;
            }

            // Validate CMND
            if (string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("CMND không được để trống!");
                return false;
            }
            if (cmnd.Length > 20 || !cmnd.All(char.IsDigit))
            {
                MessageBox.Show("CMND phải là số và không vượt quá 20 ký tự!");
                return false;
            }

            // Validate Họ và Tên
            if (string.IsNullOrEmpty(ho))
            {
                MessageBox.Show("Họ không được để trống!");
                return false;
            }
            if (ho.Length > 40)
            {
                MessageBox.Show("Họ không được vượt quá 40 ký tự!");
                return false;
            }

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên không được để trống!");
                return false;
            }
            if (ten.Length > 10)
            {
                MessageBox.Show("Tên không được vượt quá 10 ký tự!");
                return false;
            }

            // Validate Địa chỉ
            if (string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                return false;
            }
            if (diachi.Length > 100)
            {
                MessageBox.Show("Địa chỉ không được vượt quá 100 ký tự!");
                return false;
            }

            // Validate Ngày sinh
            if (!ngaysinh.HasValue)
            {
                MessageBox.Show("Ngày sinh không được để trống!");
                return false;
            }
            if (ngaysinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không thể là ngày trong tương lai!");
                return false;
            }
            // Kiểm tra tuổi hợp lệ (ví dụ: ít nhất 18 tuổi)
            if (DateTime.Now.Year - ngaysinh.Value.Year < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!");
                return false;
            }

            // Validate Lương - phải >= 7000000 theo schema
            if (string.IsNullOrEmpty(luongText))
            {
                MessageBox.Show("Lương không được để trống!");
                double l = double.Parse(luongText) ;
                if(l <7000000) {
                    MessageBox.Show("Lương không được nhỏ hơn 7000000!");
                    return false;
                }
                return false;
            }

            if (!float.TryParse(luongText, out float luong))
            {
                MessageBox.Show("Lương phải là số hợp lệ!");
                return false;
            }

            if (luong < 7000000)
            {
                MessageBox.Show("Lương phải từ 7.000.000 đồng trở lên!");
                return false;
            }

            return true;
        }


        private void ClearInputs()
        {
            this.manvInput.Text = "";
            this.cmndInput.Text = "";
            this.hoInput.Text = "";
            this.tenInput.Text = "";
            this.diachiInput.Text = "";
            this.ngaysinhInput.DateTime = DateTime.Now.AddYears(-18).AddDays(-1);
            this.luongInput.Text = "";
            this.ghichuInput.Text = "";
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (nhanvienBindingSource.Current != null)
            {
                var currentRow = (DataRowView)nhanvienBindingSource.Current;
                var nhanvienRow = (qlvtDataSet.NhanvienRow)currentRow.Row;
                int manv = nhanvienRow.MANV;
                // Get the current row's MAVT value
                Console.WriteLine("MANV: " + manv);

                    // Confirm deletion
                    var result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {nhanvienRow.HO} {nhanvienRow.TEN}?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        undoStack.Push(

                            new UndoAction
                            {
                                Action = ActionType.Delete,
                                OldItemArray = nhanvienRow.ItemArray,
                                NewItemArray = null,
                                index = nhanvienBindingSource.Position
                            }
                        );
                        // Delete the row
                        nhanvienRow.Delete();
                        MessageBox.Show("Xóa nhân viên thành công");
                    }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên để xóa");
            }
        }

        private void ngaysinhInput_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nhanVienReportBtn_Click(object sender, EventArgs e)
        {
            this.nhanVienReportBtn.Enabled = false; // Disable the button to prevent multiple clicks

            if(formBaoCao != null && !formBaoCao.IsDisposed)
            {
                formBaoCao.Close(); // Close the existing report form if it is open
                formBaoCao = null; // Set to null to allow a new report to be created
            }
            NhanVienReport report = new NhanVienReport();
            this.formBaoCao = new FormBaoCao(report);
            if (report.RowCount <= 0)
            {
                MessageBox.Show("Báo cáo không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.nhanVienReportBtn.Enabled = true;
            }
            else
            {
                formBaoCao.FormClosed += (s, args) => this.nhanVienReportBtn.Enabled = true;
                FormManager.switchForm(this, formBaoCao);
            }
        }

        private string EscapeLikeValue(string value)
        {
            return value
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");
        }

        private void searchInput_EditValueChanged(object sender, EventArgs e)
        {
            string searchText = EscapeLikeValue(searchInput.Text.Trim());

            if (!string.IsNullOrEmpty(searchText))
            {
                nhanvienBindingSource.Filter = $"CONVERT(MANV, 'System.String') LIKE '%{searchText}%' OR TEN LIKE '%{searchText}%' OR HO LIKE '%{searchText}%'";
                currentFilter = nhanvienBindingSource.Filter;
            }
            else
            {
                nhanvienBindingSource.RemoveFilter();
                currentFilter = null;
            }
            labelNoResult.Visible = nhanvienBindingSource.Count == 0;
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchInput.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                nhanvienBindingSource.Filter = $"CONVERT(MANV, 'System.String') LIKE '%{searchText}%' OR TEN LIKE '%{searchText}%' OR HO LIKE '%{searchText}%'";

                currentFilter = nhanvienBindingSource.Filter;
            }
            else
            {
                nhanvienBindingSource.RemoveFilter();
                searchInput.Text = "";

                currentFilter = null;
            }
            labelNoResult.Visible = nhanvienBindingSource.Count == 0;
        }

        private void diachiInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập ký tự, số, dấu cách, dấu phẩy, dấu chấm, và phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
            // Không cho nhập 2 dấu cách liên tiếp hoặc các dấu phân cách liên tiếp (., ,, .., .,, ,., ...)
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string text = textBox.Text;
            char last = text.Length > 0 ? text[text.Length - 1] : '\0';
            if ((e.KeyChar == ' ' && (text.Length == 0 || last == ' ')) ||
                ((e.KeyChar == ',' || e.KeyChar == '.') && (text.Length == 0 || last == ' ' || last == ',' || last == '.')))
            {
                e.Handled = true;
                return;
            }
        }

        private void diachiInput_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as DevExpress.XtraEditors.TextEdit;
            string oldText = textBox.Text;
            if (string.IsNullOrEmpty(oldText)) return;
            int oldSelStart = textBox.SelectionStart;

            // Lưu lại text trước khi format để so sánh
            string before = oldText;
            int beforeSel = oldSelStart;

            // Format lại text
            string text = oldText;
            // Không cho 2 dấu cách liên tiếp
            while (text.Contains("  "))
                text = text.Replace("  ", " ");
            // Không cho các dấu phân cách liên tiếp (., ,, .., .,, ,., ...)
            string[] bads = { ",,", "..", ",.", ".,", ",,,", "...", ",.,", ".,.", ",..", "..,", ".,," };
            bool replaced;
            do {
                replaced = false;
                foreach (var bad in bads)
                {
                    int idx = text.IndexOf(bad);
                    if (idx != -1)
                    {
                        text = text.Remove(idx + 1, bad.Length - 1);
                        replaced = true;
                        if (oldSelStart > idx + 1)
                            oldSelStart -= (bad.Length - 1);
                    }
                }
            } while (replaced);
            // Không cho dấu phẩy hoặc chấm ở đầu hoặc cuối chuỗi
            while (text.StartsWith(",") || text.StartsWith("."))
            {
                text = text.Substring(1);
                if (oldSelStart > 0) oldSelStart--;
            }
            while (text.EndsWith(",") || text.EndsWith("."))
            {
                text = text.Substring(0, text.Length - 1);
                if (oldSelStart > text.Length) oldSelStart = text.Length;
            }

            // Xác định nếu vừa nhập dấu phẩy/chấm thì con trỏ phải đứng sau dấu đó
            // (kể cả khi nhập ở giữa chuỗi)
            if (text != before) {
                // Tìm vị trí đầu tiên mà text khác before
                int diffIdx = 0;
                while (diffIdx < text.Length && diffIdx < before.Length && text[diffIdx] == before[diffIdx])
                    diffIdx++;
                // Nếu nhập dấu phẩy/chấm ở giữa
                if (oldSelStart > 0 &&
                    (beforeSel > 0 && (before[beforeSel-1] == ',' || before[beforeSel-1] == '.')) &&
                    (diffIdx == beforeSel-1 || diffIdx == beforeSel))
                {
                    // Đặt con trỏ sau dấu vừa nhập
                    oldSelStart = diffIdx + 1;
                }
                else if (oldSelStart > text.Length) {
                    oldSelStart = text.Length;
                }
            }
            if (textBox.Text != text)
            {
                textBox.Text = text;
                textBox.SelectionStart = Math.Max(0, Math.Min(oldSelStart, textBox.Text.Length));
            }
        }

    }
}
