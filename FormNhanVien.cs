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
        public FormNhanVien()
        {
            InitializeComponent();

            this.cmndInput.KeyPress += cmndInput_KeyPress;
            this.hoInput.KeyPress += hoInput_KeyPress;
            this.tenInput.KeyPress += tenInput_KeyPress;
            this.luongInput.KeyPress += luongInput_KeyPress;
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

        private void NhanvienDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu không có dòng đang chọn thì bỏ qua
            if (nhanvienDataGridView.CurrentRow == null) return;

            DataRowView rowView = (DataRowView)nhanvienDataGridView.CurrentRow.DataBoundItem;
            DataRow row = rowView.Row;

            // Kiểm tra trùng CMND khi sửa cột CMND 
            if (e.ColumnIndex == 1)// cột CMND
            {
                string cmnd = row["CMND"].ToString().Trim();
                nhanvienBindingSource.RemoveFilter();
                DataRow[] existingRows = qlvtDataSet.Nhanvien.Select($"CMND = '{cmnd}' AND MANV <> '{row["MANV"]}'");
                Console.WriteLine("CMND: " + cmnd + " - " + existingRows.Length);
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("CMND này đã tồn tại, không thể cập nhật.");
                    // Phục hồi giá trị cũ
                    row.ItemArray = undoStack.Pop().OldItemArray;
                    nhanvienBindingSource.Position = 0;
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
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nhanvienBindingSource.EndEdit();
                nhanvienBindingSource.RemoveFilter();
                int check = this.nhanvienTableAdapter.Update(qlvtDataSet.Nhanvien);
                if (check == 0)
                {
                    throw new Exception();
                }
                else
                {
                    MessageBox.Show("Lưu thành công");
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
            // Only allow letters and spaces
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Block invalid input
            }
        }

        private void tenInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow letters and spaces
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Block invalid input
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
            DateTime? ngaysinh = this.ngaysinhInput.DateTime; // Nullable DateTime
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
            this.ngaysinhInput.Text = "";
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
            FormBaoCao form = new FormBaoCao(new NhanVienReport());
            form.Show();
        }

    }
}
