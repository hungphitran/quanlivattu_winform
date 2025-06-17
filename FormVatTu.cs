using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Charts.Native;
using DevExpress.CodeParser;
using DevExpress.DashboardCommon.DataProcessing;
using DevExpress.DataAccess.Native.Data;
using DevExpress.PivotGrid.QueryMode;
using DevExpress.Utils.Html.Internal;
using DevExpress.XtraReports;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraRichEdit.Mouse;
using QLVT;
using DataTable = DevExpress.DataAccess.Native.Data.DataTable;

namespace quanlyvattu
{
    public partial class FormVatTu : Form
    {
        //private Stack<VattuValueSet> st_vattu;

        Stack<UndoAction> undoStack = new Stack<UndoAction>();


        private Form formBaoCao;

        private string currentFilter = null;

        public FormVatTu()
        {
            InitializeComponent();
            this.searchInput.KeyPress += KeyPressConstraint.KeyPress_LettersDigitsSpace;
            this.searchInput.Properties.MaxLength = 30;
            this.mavtInput.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToUppercase_NoSpace;
            this.mavtInput.Properties.MaxLength = 4;
            this.tenvtInput.KeyPress += KeyPressConstraint.KeyPress_LettersDigitsSpace;
            this.tenvtInput.Properties.MaxLength = 30;
            this.donvitinhInput.KeyPress += KeyPressConstraint.KeyPress_LettersDigitsSpace;
            this.donvitinhInput.Properties.MaxLength = 15;

            // disable all input in groupControl
            this.mavtTextEdit.Enabled= false;
            this.tenvtTextEdit.Enabled = false;
            this.dvtTextEdit.Enabled = false;
            this.soluongtonSpinEdit.Enabled = false;

        }

        private void FormVatTu_Load_1(object sender, EventArgs e)
        {
            // Existing code
            vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qlvtDataSet.Vattu);
            vattuBindingSource.DataSource = qlvtDataSet.Vattu;
            // Subscribe to the RowChanged event for Vattu
            this.vattuDataGridView.CellValueChanged += VattuDataGridView_CellValueChanged;
            // Subscribe to the CurrentChanged event for BeginEdit
            this.vattuDataGridView.CellBeginEdit += VattuDataGridView_CellBeginEdit;
            //this.vattuDataGridView.CellEndEdit += VattuDataGridView_CellEndEdit;
            this.vattuDataGridView.EditingControlShowing += VattuDataGridView_EditingControlShowing;
            // Try all possible variants of the column name - debugging approach
            vattuDataGridView.Columns[3].ReadOnly = true;
        }

        private void VattuDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Get the column index of the cell being edited
            int columnIndex = vattuDataGridView.CurrentCell.ColumnIndex;

            // Check if the editing control is a TextBox
            if (e.Control is TextBox textBox)
            {
                //// Remove any existing event handlers to prevent multiple subscriptions
                textBox.KeyPress -= KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_NoSpace;
                textBox.KeyPress -= KeyPressConstraint.KeyPress_LettersDigitsSpace;
                textBox.KeyPress -= KeyPressConstraint.KeyPress_OnlyDigits;
                textBox.KeyPress -= KeyPressConstraint.KeyPress_OnlyLetters;

                switch (columnIndex)
                {
                    case 0:
                        // For MAVT column
                        textBox.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToUppercase_NoSpace;
                        textBox.MaxLength = 4;
                        break;

                    case 1:
                        // For TENVT column
                        textBox.KeyPress += KeyPressConstraint.KeyPress_LettersDigitsSpace;
                        textBox.MaxLength = 30;
                        break;
                    case 2:
                        // For DVT column
                        textBox.KeyPress += KeyPressConstraint.KeyPress_LettersDigitsSpace;
                        textBox.MaxLength = 15;
                        break;
                }
            }
        }
        //private void VattuDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        DataRowView rowView = (DataRowView)vattuDataGridView.CurrentRow.DataBoundItem;
        //        DataRow row = rowView.Row;

        //        if (e.ColumnIndex == 0) // MAVT column
        //        {
        //            String mavt = row["MAVT"].ToString().Trim();
        //            DataRow[] existingRows = qlvtDataSet.Vattu.Select($"MAVT = '{mavt}')");
        //            if (existingRows.Length > 1)
        //            {
        //                MessageBox.Show("Mã vật tư đã tồn tại, không thể cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                row.RejectChanges(); // Revert to the original value
        //                return;
        //            }
        //        }

        //        // Get the pre-edit state from undo stack
        //        if (undoStack.Count > 0)
        //        {
        //            UndoAction pre = undoStack.Pop();

        //            // Check if values have actually changed
        //            bool hasChanged = false;
        //            if (pre.OldItemArray.Length == row.ItemArray.Length)
        //            {
        //                for (int i = 0; i < pre.OldItemArray.Length; i++)
        //                {
        //                    // Compare each value in the arrays
        //                    if (!Equals(pre.OldItemArray[i], row.ItemArray[i]))
        //                    {
        //                        hasChanged = true;
        //                        break;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                hasChanged = true; // Different array lengths indicate change
        //            }

        //            if (hasChanged)
        //            {
        //                // Only push to stack if there's an actual change
        //                undoStack.Push(new UndoAction
        //                {
        //                    Action = ActionType.Update,
        //                    OldItemArray = pre.OldItemArray,
        //                    NewItemArray = row.ItemArray,
        //                    index = pre.index
        //                });
        //                Console.WriteLine("Changes detected and saved to undo stack");
        //            }
        //            else
        //            {
        //                // No changes, put the pre-edit state back
        //                undoStack.Push(pre);
        //                Console.WriteLine("No changes detected");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi kết thúc chỉnh sửa: " + ex.Message, "Lỗi",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void VattuDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView rowView = (DataRowView)vattuDataGridView.CurrentRow.DataBoundItem;
                DataRow row = rowView.Row;

                // Kiểm tra trùng MAVT khi sửa cột MAVT (cột 0)
                if (e.ColumnIndex == 0)
                {
                    String mavt = row["MAVT"].ToString();
                    vattuBindingSource.RemoveFilter();
                    searchInput.Text = "";

                    // Check for duplicates excluding the current row
                    DataRow[] existingRows = qlvtDataSet.Vattu.Select($"MAVT = '{mavt}'");
                    if (existingRows.Length > 1)
                    {
                        MessageBox.Show("Mã vật tư đã tồn tại, không thể cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.RejectChanges(); // Revert the change
                        return;
                    }
                }

                // Kiểm tra trùng tên vt khi sửa cột TENVT (cột 1)
                if (e.ColumnIndex == 1)
                {
                    String tenvt = row["TENVT"].ToString();
                    vattuBindingSource.RemoveFilter();
                    searchInput.Text = "";

                    // Check for duplicates excluding the current row
                    DataRow[] existingRows = qlvtDataSet.Vattu.Select($"TENVT = '{tenvt}' AND NOT (MAVT = '{row["MAVT"]}')");
                    if (existingRows.Length > 0)
                    {
                        MessageBox.Show("Tên vật tư đã tồn tại, không thể cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.RejectChanges(); // Revert the change
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
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Get the current row and revert changes
                DataRowView rowView = (DataRowView)vattuDataGridView.CurrentRow.DataBoundItem;
                rowView.Row.RejectChanges();
            }
        }


        private void VattuDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataRowView rowView = (DataRowView)vattuDataGridView.CurrentRow.DataBoundItem;
            DataRow row = rowView.Row;

            // Lấy chỉ số cột mà người dùng nhấn vào
            int columnIndex = e.ColumnIndex;

            // Lấy tên cột (nếu cần)
            //string columnName = vattuDataGridView.Columns[columnIndex].Name;

            int index =vattuBindingSource.Position;
            if (currentFilter != null)
            {
                String mavt = row["MAVT"].ToString();
                vattuBindingSource.RemoveFilter();
                index = vattuBindingSource.Find("MAVT", mavt);
                vattuBindingSource.Filter = currentFilter;
                vattuBindingSource.Position = vattuBindingSource.Find("MAVT",mavt);

            }
            // Đặt focus vào ô tương ứng sau khi áp dụng lại filter
            vattuDataGridView.CurrentCell = vattuDataGridView.Rows[vattuBindingSource.Position].Cells[columnIndex];

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
        private void backBut_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            String mavt = this.mavtInput.Text.Trim();
            String tenvt = this.tenvtInput.Text.Trim();
            String dvt = this.donvitinhInput.Text.Trim();
            // Kiểm tra các trường nhập liệu

                try
                {
                    // Kiểm tra MAVT đã tồn tại
                    vattuBindingSource.RemoveFilter();
                    searchInput.Text = "";
                    DataRow[] existingRows = qlvtDataSet.Vattu.Select($"MAVT = '{mavt}'");
                    if (existingRows.Length > 0)
                    {
                        MessageBox.Show("Mã vật tư đã tồn tại, không thể thêm");
                        return;

                    }

                    existingRows = qlvtDataSet.Vattu.Select($"TENVT = '{tenvt}'");
                    if (existingRows.Length>0)
                    {
                        MessageBox.Show("Tên vật tư đã tồn tại");
                        return;
                    }

                    DataRow newRow = qlvtDataSet.Vattu.NewRow();
                    // gán giá trị...

                    newRow["MAVT"] = mavt;
                    newRow["TENVT"] = tenvt;
                    newRow["DVT"] = dvt;
                    newRow["SOLUONGTON"] = 0; // Giá trị mặc định cho số lượng tồn
                    qlvtDataSet.Vattu.Rows.Add(newRow);

                    undoStack.Push(
                        new UndoAction
                        {
                            Action = ActionType.Insert,
                            OldItemArray = null,
                            NewItemArray = newRow.ItemArray,
                            index = qlvtDataSet.Vattu.Rows.Count - 1
                        }
                    );
                    // Xóa các trường nhập liệu
                    this.mavtInput.Text = "";
                    this.tenvtInput.Text = "";
                    this.donvitinhInput.Text = "";

                    MessageBox.Show("Thêm vật tư thành công");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Lỗi khi thêm vật tư: " + ex.Message);
                }
        }



        private void reloadBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("reload");
            this.vattuTableAdapter.Fill(this.qlvtDataSet.Vattu);
            vattuBindingSource.RemoveFilter();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                vattuBindingSource.EndEdit();
                vattuBindingSource.RemoveFilter();
                int check = this.vattuTableAdapter.Update(qlvtDataSet.Vattu);
                if (check == 0)
                {
                    MessageBox.Show("Không có thay đổi nào để lưu.");
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

            this.vattuBindingSource.RemoveFilter();
            this.searchInput.Text= "";

            switch (action.Action)
            {
                case ActionType.Insert:
                    // Xóa dòng đã thêm
                    qlvtDataSet.Vattu.Rows.RemoveAt(qlvtDataSet.Vattu.Rows.Count - 1);
                    MessageBox.Show("Hoàn tác thành công.");
                    break;
                case ActionType.Update:
                    // Khôi phục giá trị cũ
                    DataRow updatedRow = qlvtDataSet.Vattu.Rows[action.index] ;
                    updatedRow.ItemArray = action.OldItemArray;
                    vattuBindingSource.Position = action.index;
                    MessageBox.Show("Hoàn tác thành công.");
                    break;
                case ActionType.Delete:
                    // Thêm lại dòng đã xóa
                    DataRow newRow = qlvtDataSet.Vattu.NewRow();
                    newRow.ItemArray = action.OldItemArray;
                    qlvtDataSet.Vattu.Rows.InsertAt(newRow, action.index);
                    vattuBindingSource.Position = action.index;
                    MessageBox.Show("Hoàn tác thành công.");
                    break;
                default:
                    MessageBox.Show("Không có thao tác nào để phục hồi.");
                    return;

                
            }

            //vattuBindingSource.Filter = filterBackup;
            //searchInput.Text = currentText;
            vattuBindingSource.ResetBindings(true);
        }


        public bool checkDeleteable(String mavt)
        {
            Console.WriteLine("check: "+mavt);
            System.Data.DataTable dt = Program.ExecSqlDataTable($"DECLARE @kq INT; EXEC @kq = sp_check_vattu_co_the_xoa @mavt = '{mavt}'; SELECT @kq AS KetQua;");

            if (dt.Rows.Count > 0)
            {
                int result = Convert.ToInt32(dt.Rows[0]["KetQua"]);

                return result == 1;
            }
            else
            {
                return false;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete button clicked");
            if (vattuBindingSource.Current != null)
            {
                var currentRow = (DataRowView)vattuBindingSource.Current;
                var vattuRow = (qlvtDataSet.VattuRow)currentRow.Row;
                String mavt = vattuRow.MAVT;
                // Get the current row's MAVT value
                Console.WriteLine("MAVT: " + mavt);


                if (checkDeleteable(mavt))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Bạn có chắc muốn xóa vật tư {vattuRow.MAVT}?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        undoStack.Push(
                        
                            new UndoAction
                            {
                                Action = ActionType.Delete,
                                OldItemArray = vattuRow.ItemArray,
                                NewItemArray = null,
                                index = vattuBindingSource.Position
                            }
                        );
                        // Delete the row
                        vattuRow.Delete();
                        MessageBox.Show("Xóa vật tư thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa vật tư đã được nhập hay xuất!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn vật tư để xóa");
            }
        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchInput.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                vattuBindingSource.Filter = $"MAVT LIKE '%{searchText}%' OR TENVT LIKE '%{searchText}%'";
                currentFilter = vattuBindingSource.Filter;
            }
            else
            {
                vattuBindingSource.RemoveFilter();
                currentFilter = null;
            }
        }


        private void lichSuVattuBtn_Click(object sender, EventArgs e)
        {

            if (formBaoCao != null)
            {
                formBaoCao.Close();
            }
            String mavt = this.mavtTextEdit.Text;
            string tenvt = this.tenvtTextEdit.Text;

            LichSuVattuReport report = new LichSuVattuReport(mavt, tenvt);
            formBaoCao = new FormBaoCao(report);
            if (report.RowCount <= 0)
            {
                MessageBox.Show("Báo cáo không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else formBaoCao.Show();
        }

        private void listVattuBtn_Click(object sender, EventArgs e)
        {
            if (formBaoCao != null)
            {
                formBaoCao.Close();
            }
            String mavt = this.mavtTextEdit.Text;
            reportVattu report = new reportVattu();
            formBaoCao = new FormBaoCao(report);
            if (report.RowCount <= 0)
            {
                MessageBox.Show("Báo cáo không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else formBaoCao.Show();
        }

    }
}
