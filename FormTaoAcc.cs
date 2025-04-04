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
using System.Windows.Forms.VisualStyles;
using QLVT;

namespace quanlyvattu
{
    public partial class FormTaoAcc : Form
    {
        public FormTaoAcc()
        {
            InitializeComponent();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string pass = this.txtPass.Text;
            bool isAdmin = this.adminBtn.Checked;

            string query = "exec sp_addlogin '"+username+"' , '" +pass+"' "+"'qlvt'";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new FormNhanVien());
        }

        private void nhanvienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanvienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qlvtDataSet);

        }

        private void FormTaoAcc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlvtDataSet.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanvienTableAdapter.Fill(this.qlvtDataSet.Nhanvien);

        }
    }
}
