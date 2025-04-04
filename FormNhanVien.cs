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
using QLVT;

namespace quanlyvattu
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();

        }


        public void SaveData()
        {
            Console.WriteLine("saving function");

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Console.WriteLine("reload employee from database");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this,new FormTaoAcc());
        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvienTableAdapter.Fill(this.qlvtDataSet.Nhanvien);
            // TODO: This line of code loads data into the 'dsqlvt.Nhanvien' table. You can move, or remove it, as needed.

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this,new Dashboard());
        }

    }
}
