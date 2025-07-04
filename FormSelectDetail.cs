﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.DataAccess.Sql;
using QLVT;

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
            this.fromDateInput.MaxDate = DateTime.Now;
            this.fromDateInput.MinDate = new DateTime(2020, 1, 1);
            this.fromDateInput.Value = DateTime.Now.Date.AddDays(-1);

            this.toDateInput.Format = DateTimePickerFormat.Custom;
            this.toDateInput.CustomFormat = "dd/MM/yyyy";
            this.toDateInput.MaxDate = DateTime.Now.Date;
            this.toDateInput.MinDate = new DateTime(2020, 1, 1);
            this.toDateInput.Value = DateTime.Now.Date;


        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.submitBtn.Enabled = false;
            // Lấy giá trị từ các điều khiển
            if (this.typeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn loại báo cáo");
                this.submitBtn.Enabled = true;
                return;
            }
            String loaiBaoCao = this.typeComboBox.SelectedItem.ToString();
            DateTime tuNgay = this.fromDateInput.Value.Date;
            DateTime denNgay = this.toDateInput.Value.Date;

            if (formBaoCao != null )
            {
                    formBaoCao.Close();
                    formBaoCao = null;
            }



            if (DateTime.Compare(tuNgay, denNgay) !=-1)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc");
                this.submitBtn.Enabled = true;
                return;
            }

            if (loaiBaoCao.Equals("NHAP"))
            { 
                BaoCaoChiTietNhap baoCaoChiTietNhap = new BaoCaoChiTietNhap(tuNgay, denNgay);

                // kiểm tra báo cáo có dữ liệu không
                if (!Program.hasData(baoCaoChiTietNhap))
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này");
                    this.submitBtn.Enabled = true;
                    return;
                }
                formBaoCao = new FormBaoCao(baoCaoChiTietNhap);
                
            }
            else
            {

                BaoCaoChiTietXuat baoCaoChiTietXuat = new BaoCaoChiTietXuat(tuNgay, denNgay);
                // kiểm tra báo cáo có dữ liệu không
                if (!Program.hasData(baoCaoChiTietXuat))
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này");
                    this.submitBtn.Enabled = true;
                    return;
                }
                formBaoCao = new FormBaoCao(baoCaoChiTietXuat);

            }
            formBaoCao.FormClosed += (s, args) => this.submitBtn.Enabled = true;
            formBaoCao.Show();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            FormManager.switchForm(this, new Dashboard());
        }

    }
}
