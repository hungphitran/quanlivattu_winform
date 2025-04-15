using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering.Helpers;

namespace quanlyvattu
{
    public partial class FormSelectDetail : Form
    {
        public Form formBaoCao=null;
        public FormSelectDetail()
        {
            InitializeComponent();
            this.fromDateInput.Format = DateTimePickerFormat.Custom;
            this.fromDateInput.CustomFormat = "dd/MM/yyyy";
            this.toDateInput.Format = DateTimePickerFormat.Custom;
            this.toDateInput.CustomFormat = "dd/MM/yyyy";

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển
            if (this.typeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn loại báo cáo");
                return;
            }
            String loaiBaoCao = this.typeComboBox.SelectedItem.ToString();
            DateTime tuNgay = this.fromDateInput.Value.Date;
            DateTime denNgay = this.toDateInput.Value.Date;

            if (formBaoCao != null )
            {
                    formBaoCao.Close();
            }



            if (DateTime.Compare(tuNgay, denNgay) != -1)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc");
                return;
            }

            if (loaiBaoCao.Equals("NHAP"))
            { 
                BaoCaoChiTietNhap baoCaoChiTietNhap = new BaoCaoChiTietNhap(tuNgay, denNgay);
                // kiểm tra báo cáo có dữ liệu không
                if (baoCaoChiTietNhap.DataMember.Length<=0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này");
                    return;
                }
                formBaoCao = new FormBaoCao(baoCaoChiTietNhap);
                
            }
            else
            {
                BaoCaoChiTietXuat baoCaoChiTietXuat = new BaoCaoChiTietXuat(tuNgay, denNgay);
                // kiểm tra báo cáo có dữ liệu không
                if (baoCaoChiTietXuat.DataMember.Length <= 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này");
                    return;
                }
                formBaoCao = new FormBaoCao(baoCaoChiTietXuat);
            }

            formBaoCao.Show();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

    }
}
