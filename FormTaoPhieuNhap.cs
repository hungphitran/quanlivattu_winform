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
    public partial class FormTaoPhieuNhap : Form
    {
        public FormTaoPhieuNhap()
        {
            InitializeComponent();
        }

        private void NhapVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qlvtDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qlvtDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qlvtDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'qlvtDataSet.sp_BaoCaoDonDatHangChuaNhap' table. You can move, or remove it, as needed.
            this.sp_BaoCaoDonDatHangChuaNhapTableAdapter.Fill(this.qlvtDataSet.sp_BaoCaoDonDatHangChuaNhap);
            
            this.ngayInput.Value = DateTime.Now;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void ngayInput_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
