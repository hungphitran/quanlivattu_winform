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
using DevExpress.DashboardCommon.DataProcessing;
using DevExpress.XtraRichEdit.Mouse;
using QLVT;

namespace quanlyvattu
{
    public partial class FormVatTu : Form
    {
        private Stack<qlvtDataSet.VattuDataTable> st_vattu;

        private Form formBaoCao;
        public FormVatTu()
        {
            InitializeComponent();
            st_vattu = new Stack<qlvtDataSet.VattuDataTable>();
        }

        private void FormVatTu_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.Vattu' table. You can move, or remove it, as needed.
            vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qlvtDataSet.Vattu);
            st_vattu.Push(qlvtDataSet.Vattu.Copy() as qlvtDataSet.VattuDataTable);

            vattuBindingSource.DataSource = qlvtDataSet.Vattu;

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            Console.WriteLine("add");
            String mavt = this.mavtInput.Text;
            String tenvt = this.tenvtInput.Text;
            String dvt = this.donvitinhInput.Text;

            if (validate.valid_mavt(mavt) && validate.valid_tenvt(tenvt) && validate.valid_mavt(dvt))
            {

                // Check if the MAVT already exists
                vattuBindingSource.RemoveFilter();
                DataRow[] existingRows = qlvtDataSet.Vattu.Select($"MAVT = '{mavt}'");
                if (existingRows.Length > 0)
                {
                    MessageBox.Show("Mã vật tư đã tồn tại, không thể thêm");
                    return;
                }


                st_vattu.Push(qlvtDataSet.Vattu.Copy() as qlvtDataSet.VattuDataTable);
                this.qlvtDataSet.Vattu.AddVattuRow(mavt, tenvt, dvt, 0);
                this.mavtInput.Text = "";
                this.tenvtInput.Text = "";
                this.donvitinhInput.Text = "";
            }
            else
            {
                MessageBox.Show("chưa nhập đủ thông tin");
            }
            Console.WriteLine(mavt + "-" + tenvt + "-" + dvt);
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
                vattuBindingSource.RemoveFilter();
                int check = this.vattuTableAdapter.Update(qlvtDataSet);
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
            if (st_vattu.Count > 1)
            {
                st_vattu.Pop();
                qlvtDataSet.Vattu.Clear();
                qlvtDataSet.Vattu.Merge(st_vattu.Peek());
                MessageBox.Show("Undo thành công");
            }
            else
            {
                MessageBox.Show("Không có thao tác nào để hoàn tác");
            }
        }

        public bool checkDeleteable(String mavt)
        {
            DataTable dt = Program.ExecSqlDataTable($"DECLARE @kq INT; EXEC @kq = sp_check_vattu_co_the_xoa @mavt = '{mavt}'; SELECT @kq AS KetQua;");

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
            Console.WriteLine("delete clicked");
            if (vattuBindingSource.Current != null)
            {
                vattuBindingSource.RemoveFilter();
                var currentRow = (DataRowView)vattuBindingSource.Current;
                var vattuRow = (qlvtDataSet.VattuRow)currentRow.Row;

                String mavt = vattuRow.MAVT;

                if (checkDeleteable(mavt))
                {
                    // Confirm deletion
                    var result = MessageBox.Show($"Bạn có chắc muốn xóa {vattuRow.MAVT}?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        st_vattu.Push(qlvtDataSet.Vattu.Copy() as qlvtDataSet.VattuDataTable);
                        vattuRow.Delete();
                        //vattuTableAdapter.Update(qlvtDataSet.Vattu);
                        MessageBox.Show("Xóa vật tư thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa vật tư đã được nhập hay xuất!!!");
                }
            }
            else
            {
                MessageBox.Show("chưa chọn vật tư");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchInput.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                vattuBindingSource.Filter = $"MAVT LIKE '%{searchText}%' OR TENVT LIKE '%{searchText}%'";
            }
            else
            {
                vattuBindingSource.RemoveFilter();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Console.Write("changed");
            try
            {
                // Save changes to the dataset
                vattuBindingSource.EndEdit();
                st_vattu.Push(qlvtDataSet.Vattu.Copy() as qlvtDataSet.VattuDataTable);
                //vattuTableAdapter.Update(qlvtDataSet.Vattu);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void lichSuVattuBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("lichSuVattuBtn_Click triggered");


            if (formBaoCao != null)
            {
                formBaoCao.Close();
            }
            String mavt = this.mAVTTextEdit.Text;

            formBaoCao = new FormBaoCao( new LichSuVattuReport(mavt));
            formBaoCao.Show();
            //if (checkDeleteable(mavt))
            //{
            //    MessageBox.Show("Vật tư chưa được nhập / xuất hay đặt");
            //    return;
            //}
        }
    }
}
