using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVT;
using quanlyvattu.qlvtDataSetTableAdapters;

namespace quanlyvattu
{
    public partial class FormTaoDDH : Form
    {
        private static string GenerateOrderId(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public FormTaoDDH()
        {
            InitializeComponent();
            this.soLuongEditor.KeyPress += KeyPressConstraint.KeyPress_OnlyDigits;
            if (!danhSachDatHang.Columns.Contains("Delete"))
            {
                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                danhSachDatHang.Columns.Add(deleteButton);
            }
            this.danhSachDatHang.CellContentClick += danhSachDatHang_CellContentClick;
            this.danhSachDatHang.UserDeletedRow += danhSachDatHang_UserDeletedRow;
            this.danhSachDatHang.CellValueChanged += danhSachDatHang_CellValueChanged;
            this.donGiaEditor.KeyPress += KeyPressConstraint.KeyPress_OnlyDigits;
            this.danhSachDatHang.EditingControlShowing += danhSachDatHang_EditingControlShowing;
            this.userTextEdit.Text = Program.mHoten;
            this.nhaccEditor.KeyPress += KeyPressConstraint.KeyPress_LettersDigitsSpace;
            this.maddhEditor.Text = GenerateOrderId();
        }


        private void danhSachDatHang_EndEdit(object sender, EventArgs e)
        {
            updateTotalCost();
        }


        private void FormTaoDDH_Load(object sender, EventArgs e)
        {
           this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qlvtDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qlvtDataSet.DatHang);
            // TODO: This line of code loads data into the 'qlvtDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qlvtDataSet.DatHang);
            // TODO: This line of code loads data into the 'qlvtDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qlvtDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qlvtDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qlvtDataSet.Vattu);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormDatHang());
        }
        private void updateVattuComboBox()
        {
            this.vattuBindingSource1.Filter= null;
            String[] seleted_vattu = new String[danhSachDatHang.Rows.Count];
            for (int i = 0; i < danhSachDatHang.Rows.Count; i++)
            {
                Console.WriteLine(danhSachDatHang.Rows[i].Cells[0].Value.ToString());
                seleted_vattu[i] = danhSachDatHang.Rows[i].Cells[0].Value.ToString();
            }
            Console.WriteLine(seleted_vattu);
            String filter = $"MAVT NOT IN ('{string.Join("','", seleted_vattu)}')";
            this.vattuBindingSource1.Filter = filter;    

            Console.WriteLine("filter: " + filter);
        }
        private void updateTotalCost()
        {
            double sum = 0.0;
            foreach (DataGridViewRow row in danhSachDatHang.Rows)
            {
                if (row.Cells["DONGIA"].Value != null && row.Cells["SOLUONG"].Value != null)
                {
                    double cost = row.Cells["DONGIA"].Value.ToString().Equals("") ? 0 : double.Parse(row.Cells["DONGIA"].Value.ToString());
                    int quantity = row.Cells["SOLUONG"].Value.ToString().Equals("") ? 0 : int.Parse(row.Cells["SOLUONG"].Value.ToString());
                    sum += cost * quantity;
                }
            }
            this.tongTienEditor.EditValue = sum;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            var vattu = this.vattuComboBox.SelectedItem as DataRowView;
            if (vattu == null)
            {
                MessageBox.Show("Vui lòng chọn vật tư!");
                return;
            }
            if(this.soLuongEditor.EditValue == null || this.donGiaEditor.EditValue == null
                || this.soLuongEditor.EditValue.ToString().Equals("") || this.donGiaEditor.EditValue.ToString().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số lượng và đơn giá hợp lệ!");
                return;
            }
            int quantity = int.Parse(this.soLuongEditor.EditValue.ToString());
            Double cost = double.Parse(this.donGiaEditor.EditValue.ToString());
            Console.WriteLine(vattu["MAVT"].ToString() + quantity + cost);
            if (quantity > 0 && cost > 0)
            {
                this.danhSachDatHang.Rows.Add(vattu["MAVT"].ToString(), vattu["TENVT"].ToString(), quantity, cost);
                updateTotalCost();
                updateVattuComboBox();
                this.soLuongEditor.EditValue = 1;
                this.donGiaEditor.EditValue = 1;
                this.vattuComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }
        private void danhSachDatHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.danhSachDatHang.Rows[e.RowIndex].Cells["SOLUONG"].Value == null 
                ||this.danhSachDatHang.Rows[e.RowIndex].Cells["SOLUONG"].Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đúng số lượng!");
                this.danhSachDatHang.Rows[e.RowIndex].Cells["SOLUONG"].Value = 1;
                return;
            }
            if (this.danhSachDatHang.Rows[e.RowIndex].Cells["DONGIA"].Value == null ||
                this.danhSachDatHang.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đúng đơn giá!");
                this.danhSachDatHang.Rows[e.RowIndex].Cells["DONGIA"].Value = 1;
                return;
            }
            if (e.ColumnIndex == 1)//soluong
            { 
                int quantity = int.Parse(this.danhSachDatHang.Rows[e.RowIndex].Cells["SOLUONG"].Value.ToString());
                if (quantity ==null || quantity <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                }
            }
            if (e.ColumnIndex == 2)//dongia
            {
                double cost = double.Parse(this.danhSachDatHang.Rows[e.RowIndex].Cells["DONGIA"].Value.ToString());
                if (cost == null || cost <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá hợp lệ!");
                }
            }
            updateTotalCost();
        }
        private void danhSachDatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (danhSachDatHang.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                danhSachDatHang.Rows.RemoveAt(e.RowIndex);
                updateVattuComboBox();

                Console.WriteLine("size: " + vattuBindingSource1.Count);
                updateTotalCost();
            }
        }
        private void danhSachDatHang_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            updateTotalCost();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(this.danhSachDatHang.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách đặt hàng không được trống!");
                return;
            }
            if (nhaccEditor.EditValue == "")
            {
                MessageBox.Show("Nhà cung cấp không được trống!");
                return;
            }
            String maddh = this.maddhEditor.EditValue.ToString();
            String manv = Program.manv;
            String nhacc = this.nhaccEditor.EditValue.ToString();
            DateTime ngay = DateTime.Now.Date;
            this.datHangTableAdapter.Insert(maddh, ngay,nhacc, int.Parse(Program.manv));

            foreach (DataGridViewRow row in danhSachDatHang.Rows)
            {
                if (row.Cells["MAVT"].Value != null && row.Cells["SOLUONG"].Value != null && row.Cells["DONGIA"].Value != null)
                {
                    String mavt = row.Cells["MAVT"].Value.ToString();
                    int quantity = int.Parse(row.Cells["SOLUONG"].Value.ToString());
                    double cost = double.Parse(row.Cells["DONGIA"].Value.ToString());
                    this.cTDDHTableAdapter.Insert(maddh, mavt, quantity, cost);
                }
            }
            MessageBox.Show("Đặt hàng thành công!");
            FormManager.switchForm(this, new FormDatHang());
        }
        private void danhSachDatHang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Remove any existing handler to avoid attaching multiple times
            e.Control.KeyPress -= KeyPressConstraint.KeyPress_OnlyDigits;

            // Check if the current column is SOLUONG or DONGIA
            int colIndex = danhSachDatHang.CurrentCell.ColumnIndex;
            string colName = danhSachDatHang.Columns[colIndex].Name;
            if (colName == "SOLUONG" || colName == "DONGIA")
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += KeyPressConstraint.KeyPress_OnlyDigits;
                }
            }
        }

    }
}
