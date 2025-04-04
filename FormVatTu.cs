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
    public partial class FormVatTu : Form
    {
        private DataTable bangVattu;
        public FormVatTu()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            loadData();
            Console.WriteLine("reload");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("add vattu");
            try{



                MessageBox.Show("Thêm vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vật tư: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsqlvt.Vattu' table. You can move, or remove it, as needed.

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("delete function");
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlvtDataSet);

        }

        private void FormVatTu_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.Vattu' table. You can move, or remove it, as needed.
            vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qlvtDataSet.Vattu);

        }

        private void backBut_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }
    }
}
