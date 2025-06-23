using DevExpress.XtraCharts.Native;
using DevExpress.XtraRichEdit.Model;
using QLVT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyvattu
{
    public partial class FormTaoPhieuNhap : Form
    {
        int[] maxSoluong;
        float[] maxDongia ;
        public FormTaoPhieuNhap(String maddh)
        {
            InitializeComponent();
            this.nhanvienEditor.EditValue = Program.mHoten;

            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Fill(this.qlvtDataSet.sp_BaoCaoDonDatHangChuaNhap);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qlvtDataSet.DatHang);
            this.datHangBindingSource.DataSource = this.qlvtDataSet.DatHang;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qlvtDataSet.CTDDH);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qlvtDataSet.PhieuNhap);
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qlvtDataSet.CTPN);


            this.datHangBindingSource.Filter = $"MasoDDH = '{maddh}'";

            this.maPNEditor.KeyPress += KeyPressConstraint.KeyPress_OnlyAsciiLettersAndDigits_ToUppercase_NoSpace;
            this.maPNEditor.Properties.MaxLength = 8;

            this.cTDDHDataGridView.EditingControlShowing += cTDDHDataGridView_EditingControlShowing;
            this.cTDDHDataGridView.CellEndEdit += cTDDHDataGridView_CellEndEdit;

            DataRow[] dataRows = qlvtDataSet.CTDDH.Select($"MasoDDH = '{maddh}'");

            maxDongia= new float[dataRows.Length];
            maxSoluong = new int[dataRows.Length];
            foreach (DataRow row in dataRows)
            {
                maxSoluong[Array.IndexOf(dataRows, row)] = int.Parse(row["SOLUONG"].ToString());
                maxDongia[Array.IndexOf(dataRows, row)] = float.Parse(row["DONGIA"].ToString());
            }
        }
        private void cTDDHDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //// Remove any existing handler to avoid attaching multiple times
            e.Control.KeyPress -= KeyPressConstraint.KeyPress_OnlyDigits;

            if (cTDDHDataGridView.CurrentCell.ColumnIndex == 2)//soluong
            {
                // Attach your custom KeyPress event handler
                e.Control.KeyPress += KeyPressConstraint.KeyPress_OnlyDigits;
            }
            else if (cTDDHDataGridView.CurrentCell.ColumnIndex == 3)//dongia
            {
                // Attach your custom KeyPress event handler
                e.Control.KeyPress += KeyPressConstraint.KeyPress_OnlyDigits;
            }
        }

        private void cTDDHDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (cTDDHDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đúng số lượng!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cTDDHDataGridView.Rows[e.RowIndex].Cells[2].Value = maxSoluong[e.RowIndex];
                    return;
                }
                int soluong = int.Parse(cTDDHDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (soluong==0 || soluong > maxSoluong[e.RowIndex])
                {
                    MessageBox.Show("số lượng không hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cTDDHDataGridView.Rows[e.RowIndex].Cells[2].Value = maxSoluong[e.RowIndex];
                }
            }
            else
            {
                if(cTDDHDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đúng đơn giá!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cTDDHDataGridView.Rows[e.RowIndex].Cells[3].Value = maxDongia[e.RowIndex];
                    return;
                }
                int dongia = int.Parse(cTDDHDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (dongia == 0 )
                {
                    MessageBox.Show("đơn giá không hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cTDDHDataGridView.Rows[e.RowIndex].Cells[3].Value = maxDongia[e.RowIndex];
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormDatHang());
        }
        //private void addBtn_Click(object sender, EventArgs e)
        //{
        //    string masoDDH = masoDDHTextEdit.Text.Trim();
        //    int manv = int.Parse(Program.manv);
        //    DateTime ngay = dateTimePicker.Value;
        //    String mapn = this.maPNEditor.EditValue.ToString().Trim();
        //    if (mapn.Length == 0 || mapn.Length > 8)
        //    {
        //        MessageBox.Show("Mã phiếu nhập không hợp lệ");
        //        return;
        //    }

        //    if (this.qlvtDataSet.PhieuNhap.FindByMAPN(mapn) != null)
        //    {
        //        MessageBox.Show("Mã phiếu nhập đã tồn tại");
        //        return;
        //    }




        //    qlvtDataSet.CTPNDataTable ctphieuNhapTable = new qlvtDataSet.CTPNDataTable();
        //    HashSet<string> addedVatTu = new HashSet<string>();
        //    foreach (DataGridViewRow row in cTDDHDataGridView.Rows)
        //    {
        //        if (row.IsNewRow) continue;

        //        string mavt = row.Cells[1].Value.ToString();
        //        if (addedVatTu.Contains(mavt)) continue;

        //        // Kiểm tra trùng trong database
        //        bool exists = false;
        //        using (SqlCommand cmdCheck = new SqlCommand(
        //            "SELECT COUNT(*) FROM CTPN WHERE MAPN = @MAPN AND MAVT = @MAVT", Program.conn))
        //        {
        //            cmdCheck.Parameters.AddWithValue("@MAPN", mapn);
        //            cmdCheck.Parameters.AddWithValue("@MAVT", mavt);
        //            int count = (int)cmdCheck.ExecuteScalar();
        //            if (count > 0) exists = true;
        //        }
        //        if (exists) continue; // Bỏ qua nếu đã tồn tại trong DB

        //        int soluong = int.Parse(row.Cells[2].Value.ToString());
        //        float dongia = float.Parse(row.Cells[3].Value.ToString());

        //        ctphieuNhapTable.Rows.Add(mapn, mavt, soluong, dongia);
        //        addedVatTu.Add(mavt);
        //    }
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand("phieu_nhap_hang", Program.conn))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cmd.Parameters.AddWithValue("@MAPN", mapn);
        //            cmd.Parameters.AddWithValue("@NGAY", ngay.ToString("yyyy-MM-dd"));
        //            cmd.Parameters.AddWithValue("@MasoDDH", masoDDH);
        //            cmd.Parameters.AddWithValue("@MANV", manv);
        //            int result = cmd.ExecuteNonQuery();
        //            if (result == 0)
        //            {
        //                MessageBox.Show("Lỗi khi thêm phiếu nhập");
        //                return;
        //            }
        //            else
        //            {
        //                // Thay vì dùng: int check = cTPNTableAdapter.Update(ctphieuNhapTable);
        //                bool hasError = false;
        //                foreach (DataRow row in ctphieuNhapTable.Rows)
        //                {
        //                    string mavt = row["MAVT"].ToString();
        //                    int soluong = int.Parse(row["SOLUONG"].ToString());
        //                    float dongia = float.Parse(row["DONGIA"].ToString());

        //                    // Kiểm tra lại lần nữa trước khi insert
        //                    using (SqlCommand cmdCheck = new SqlCommand(
        //                        "SELECT COUNT(*) FROM CTPN WHERE MAPN = @MAPN AND MAVT = @MAVT", Program.conn))
        //                    {
        //                        cmdCheck.Parameters.AddWithValue("@MAPN", mapn);
        //                        cmdCheck.Parameters.AddWithValue("@MAVT", mavt);
        //                        int count = (int)cmdCheck.ExecuteScalar();
        //                        if (count > 0) continue; // Đã tồn tại, bỏ qua
        //                    }

        //                    using (SqlCommand cmdInsert = new SqlCommand(
        //                        "INSERT INTO CTPN (MAPN, MAVT, SOLUONG, DONGIA) VALUES (@MAPN, @MAVT, @SL, @DG)", Program.conn))
        //                    {
        //                        cmdInsert.Parameters.AddWithValue("@MAPN", mapn);
        //                        cmdInsert.Parameters.AddWithValue("@MAVT", mavt);
        //                        cmdInsert.Parameters.AddWithValue("@SL", soluong);
        //                        cmdInsert.Parameters.AddWithValue("@DG", dongia);
        //                        try
        //                        {
        //                            cmdInsert.ExecuteNonQuery();
        //                        }
        //                        catch
        //                        {
        //                            hasError = true;
        //                        }
        //                    }
        //                }
        //                if (hasError)
        //                {
        //                    MessageBox.Show("Có lỗi khi thêm một số chi tiết phiếu nhập.");
        //                }
        //                else
        //                {
        //                    // Cập nhật số lượng vật tư
        //                    foreach (DataRow row in ctphieuNhapTable.Rows)
        //                    {
        //                        string mavt = row["MAVT"].ToString();
        //                        int soluong = int.Parse(row["SOLUONG"].ToString());

        //                        using (SqlCommand cmdUpdate = new SqlCommand(
        //                            "UPDATE VATTU SET SOLUONGTON = SOLUONGTON + @SL WHERE MAVT = @MAVT", Program.conn))
        //                        {
        //                            cmdUpdate.Parameters.AddWithValue("@SL", soluong);
        //                            cmdUpdate.Parameters.AddWithValue("@MAVT", mavt);
        //                            cmdUpdate.ExecuteNonQuery();
        //                        }
        //                    }

        //                    MessageBox.Show("Phiếu nhập đã được tạo thành công!");
        //                    Program.ExecSqlNonQuery("use qlvt; exec sp_TaoBackupLog 'qlvt'");
        //                    FormManager.switchForm(this, new FormDatHang());
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
        //    }
        //}

        private void addBtn_Click(object sender, EventArgs e)
        {
            string masoDDH = masoDDHTextEdit.Text.Trim();
            int manv = int.Parse(Program.manv);
            DateTime ngay = dateTimePicker.Value;
            string mapn = this.maPNEditor.EditValue.ToString().Trim();

            if (mapn.Length == 0 || mapn.Length > 8)
            {
                MessageBox.Show("Mã phiếu nhập không hợp lệ");
                return;
            }

            if (this.qlvtDataSet.PhieuNhap.FindByMAPN(mapn) != null)
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại");
                return;
            }

            // ✅ Validate lại dữ liệu chi tiết
            foreach (DataGridViewRow row in cTDDHDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string mavt = row.Cells[1].Value?.ToString();
                string soluongStr = row.Cells[2].Value?.ToString();
                string dongiaStr = row.Cells[3].Value?.ToString();

                if (string.IsNullOrWhiteSpace(mavt) || string.IsNullOrWhiteSpace(soluongStr) || string.IsNullOrWhiteSpace(dongiaStr))
                {
                    MessageBox.Show("Dữ liệu vật tư không được để trống!");
                    return;
                }

                if (!int.TryParse(soluongStr, out int sl) || sl <= 0)
                {
                    MessageBox.Show($"Số lượng không hợp lệ tại vật tư {mavt}!");
                    return;
                }

                if (!float.TryParse(dongiaStr, out float dg) || dg <= 0)
                {
                    MessageBox.Show($"Đơn giá không hợp lệ tại vật tư {mavt}!");
                    return;
                }
            }

            qlvtDataSet.CTPNDataTable ctphieuNhapTable = new qlvtDataSet.CTPNDataTable();
            HashSet<string> addedVatTu = new HashSet<string>();

            foreach (DataGridViewRow row in cTDDHDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string mavt = row.Cells[1].Value.ToString();
                if (addedVatTu.Contains(mavt)) continue;

                // Kiểm tra trùng trong database
                using (SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM CTPN WHERE MAPN = @MAPN AND MAVT = @MAVT", Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@MAPN", mapn);
                    cmdCheck.Parameters.AddWithValue("@MAVT", mavt);
                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0) continue;
                }

                int soluong = int.Parse(row.Cells[2].Value.ToString());
                float dongia = float.Parse(row.Cells[3].Value.ToString());

                ctphieuNhapTable.Rows.Add(mapn, mavt, soluong, dongia);
                addedVatTu.Add(mavt);
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("phieu_nhap_hang", Program.conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAPN", mapn);
                    cmd.Parameters.AddWithValue("@NGAY", ngay.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MasoDDH", masoDDH);
                    cmd.Parameters.AddWithValue("@MANV", manv);

                    cmd.ExecuteNonQuery();
                }

                // Thêm chi tiết phiếu nhập
                bool hasError = false;
                foreach (DataRow row in ctphieuNhapTable.Rows)
                {
                    string mavt = row["MAVT"].ToString();
                    int soluong = int.Parse(row["SOLUONG"].ToString());
                    float dongia = float.Parse(row["DONGIA"].ToString());

                    using (SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM CTPN WHERE MAPN = @MAPN AND MAVT = @MAVT", Program.conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@MAPN", mapn);
                        cmdCheck.Parameters.AddWithValue("@MAVT", mavt);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0) continue;
                    }

                    using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO CTPN (MAPN, MAVT, SOLUONG, DONGIA) VALUES (@MAPN, @MAVT, @SL, @DG)", Program.conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@MAPN", mapn);
                        cmdInsert.Parameters.AddWithValue("@MAVT", mavt);
                        cmdInsert.Parameters.AddWithValue("@SL", soluong);
                        cmdInsert.Parameters.AddWithValue("@DG", dongia);
                        try
                        {
                            cmdInsert.ExecuteNonQuery();
                        }
                        catch
                        {
                            hasError = true;
                        }
                    }
                }

                if (hasError)
                {
                    MessageBox.Show("Có lỗi khi thêm một số chi tiết phiếu nhập.\nPhiếu sẽ bị hủy.");

                    // Xóa phiếu nhập đã thêm
                    using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM PHIEUNHAP WHERE MAPN = @MAPN", Program.conn))
                    {
                        cmdDelete.Parameters.AddWithValue("@MAPN", mapn);
                        cmdDelete.ExecuteNonQuery();
                    }

                    return;
                }

                // Cập nhật tồn kho nếu mọi thứ thành công
                foreach (DataRow row in ctphieuNhapTable.Rows)
                {
                    string mavt = row["MAVT"].ToString();
                    int soluong = int.Parse(row["SOLUONG"].ToString());

                    using (SqlCommand cmdUpdate = new SqlCommand("UPDATE VATTU SET SOLUONGTON = SOLUONGTON + @SL WHERE MAVT = @MAVT", Program.conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@SL", soluong);
                        cmdUpdate.Parameters.AddWithValue("@MAVT", mavt);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Phiếu nhập đã được tạo thành công!");
                Program.ExecSqlNonQuery("use qlvt; exec sp_TaoBackupLog 'qlvt'");
                FormManager.switchForm(this, new FormDatHang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
            }
        }


        private void FormTaoPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.qlvtDataSet.CTPN);
            // TODO: This line of code loads data into the 'qlvtDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qlvtDataSet.PhieuNhap);

        }
    }
}
