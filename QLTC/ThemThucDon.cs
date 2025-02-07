﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class ThemThucDon : Form
    {
        public ThemThucDon()
        {
            InitializeComponent();
        }
        private void ThemThucDon_Load(object sender, EventArgs e)
        {

        }
        DataDichVuTableAdapters.MONANTableAdapter DanhSachMonAn = new DataDichVuTableAdapters.MONANTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tenMonAn.Text == "Nhập tên món ăn" || tenMonAn.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (donGiaMonAn.Text == "Nhập đơn giá món ăn" || donGiaMonAn.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DanhSachMonAn.KiemTraMonAn(tenMonAn.Text).Count != 0)
            {
                MessageBox.Show("Món ăn đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int donGia = int.Parse(donGiaMonAn.Text);
                string monAn = tenMonAn.Text;
                DanhSachMonAn.InsertThucDon(monAn, donGia);
                MessageBox.Show("Thêm món " + monAn + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void donGiaMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
