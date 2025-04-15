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

            // Kiểm tra trùng CMND khi sửa cột CMND (giả sử cột CMND là cột thứ 2)
            if (e.ColumnIndex == 2)
            {
                string cmnd = row["CMND"].ToString();
                nhanvienBindingSource.RemoveFilter();
                DataRow[] existingRows = qlvtDataSet.Nhanvien.Select($"CMND = '{cmnd}' AND MANV <> '{row["MANV"]}'");
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("CMND này đã tồn tại, không thể cập nhật.");
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

            Console.WriteLine("Giá trị cũ: " + string.Join(",", undoStack.Peek().OldItemArray));
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
            // Nếu không phải số và không phải phím điều khiển (backspace, delete...)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn nhập
            }
        }

        private void hoInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự nhập vào không phải chữ cái, không phải phím điều khiển và không phải dấu cách
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Chặn nhập
            }
        }

        private void tenInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự nhập vào không phải chữ cái, không phải phím điều khiển và không phải dấu cách
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Chặn nhập
            }
        }

        private void luongInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nếu ký tự nhập vào không phải chữ cái, không phải phím điều khiển và không phải dấu cách
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Chặn nhập
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

            // Kiểm tra và chuyển đổi dữ liệu
            if (!int.TryParse(manvText, out int manv))
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên hợp lệ!");
                return;
            }

            if (string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Chưa nhập đủ thông tin bắt buộc (CMND, Họ, Tên)!");
                return;
            }

            if (cmnd.Length > 12 || ho.Length > 40 || ten.Length > 10 || diachi.Length > 100)
            {
                MessageBox.Show("Độ dài thông tin vượt quá giới hạn (CMND: 20, Họ: 40, Tên: 10, Địa chỉ: 100 ký tự)!");
                return;
            }

            float? luong = null;
            if (!string.IsNullOrEmpty(luongText))
            {
                if (!float.TryParse(luongText, out float luongParsed))
                {
                    MessageBox.Show("Lương phải là số hợp lệ!");
                    return;
                }
                luong = luongParsed;
            }

            try
            {
                // Kiểm tra MANV đã tồn tại
                DataRow[] existingRows = qlvtDataSet.Nhanvien.Select($"MANV = {manv}");
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, không thể thêm!");
                    return;
                }

                // Tạo hàng mới cho bảng NhanVien
                DataRow newRow = qlvtDataSet.Nhanvien.NewRow();
                newRow["MANV"] = manv;
                newRow["CMND"] = cmnd;
                newRow["HO"] = ho;
                newRow["TEN"] = ten;
                newRow["DIACHI"] = diachi;
                newRow["NGAYSINH"] = ngaysinh.Value;
                newRow["LUONG"] = luong.Value;
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
                this.manvInput.Text = "";
                this.cmndInput.Text = "";
                this.hoInput.Text = "";
                this.tenInput.Text = "";
                this.diachiInput.Text = "";
                this.ngaysinhInput.Text = "";
                this.luongInput.Text = "";
                this.ghichuInput.Text = "";

                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete button clicked");
            if (nhanvienBindingSource.Current != null)
            {
                var currentRow = (DataRowView)nhanvienBindingSource.Current;
                var nhanvienRow = (qlvtDataSet.NhanvienRow)currentRow.Row;
                int manv = nhanvienRow.MANV;
                // Get the current row's MAVT value
                Console.WriteLine("MANV: " + manv);


                //if (checkDeleteable(mavt))
                //{
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
                //}
                //else
                //{
                //    MessageBox.Show("Không thể xóa vật tư đã được nhập hay xuất!");
                //}
            }
            else
            {
                MessageBox.Show("Chưa chọn nhân viên để xóa");
            }
        }

        private void ngaysinhInput_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
