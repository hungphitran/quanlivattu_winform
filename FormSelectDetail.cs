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
    public partial class FormSelectDetail : Form
    {
        public Form formBaoCao=null;
        public FormSelectDetail()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
                // Lấy giá trị từ các điều khiển
            String loaiBaoCao = this.typeComboBox.SelectedItem.ToString();
            DateTime tuNgay = this.fromDateInput.Value.Date;
            DateTime denNgay = this.toDateInput.Value.Date;

            if (formBaoCao != null)
            {
                    formBaoCao.Close();
            }

            if (loaiBaoCao.Equals("NHAP"))
            { 
                formBaoCao = new FormBaoCao(new BaoCaoChiTietNhap(tuNgay, denNgay));
            }
            else
            {
                formBaoCao = new FormBaoCao(new BaoCaoChiTietXuat( tuNgay, denNgay));
            }

            formBaoCao.Show();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }
    }
}
