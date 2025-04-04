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

namespace quanlyvattu
{
    public partial class FormDatHang : Form
    {
        public FormDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();

        }

        private void FormDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsqlvt.DatHang' table. You can move, or remove it, as needed.

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void datHangBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.qlvtDataSet);

        }

        private void FormDatHang_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.DatHang' table. You can move, or remove it, as needed.ư
            this.datHangTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter1.Fill(this.qlvtDataSet.DatHang);

        }

        private void datHangBindingSource2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource2.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlvtDataSet1);

        }

        private void FormDatHang_Load_2(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet1.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qlvtDataSet1.CTDDH);
            // TODO: This line of code loads data into the 'qlvtDataSet1.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qlvtDataSet1.DatHang);

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this,new Dashboard());
        }
    }
}
