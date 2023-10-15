using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNTT
{
    public partial class FThemCN : Form
    {
        public FThemCN()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text;
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên không được để trống");
                return;
            }

            DateTime ngaysinh = dtNgaySinh.Value;

            string gioitinh = tbGioiTinh.Text;
            if (string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Giới tính không được để trống");
                return;
            }

            string diachi = tbDiaChi.Text;
            if (string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Địa chỉ không được để trống");
                return;
            }

            string trinhdo = tbTrinhDo.Text;
            if (string.IsNullOrEmpty(trinhdo))
            {
                MessageBox.Show("Trình độ không được để trống");
                return;
            }

            string manhanvien = tbMaNhanVien.Text;
            if (string.IsNullOrEmpty(manhanvien))
            {
                MessageBox.Show("Mã nhân viên không được để trống");
                return;
            }

            string chucvu = tbChucVu.Text;
            if (string.IsNullOrEmpty(chucvu))
            {
                MessageBox.Show("Chức vụ không được để trống");
                return;
            }

            string bac = tbBac.Text;
            if (string.IsNullOrEmpty(bac))
            {
                MessageBox.Show("Bậc không được để trống");
                return;
            }

            string to = tbTo.Text;
            if (string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Tổ không được để trống");
                return;
            }

            string nhom = tbNhom.Text;
            if (string.IsNullOrEmpty(nhom))
            {
                MessageBox.Show("Nhóm không được để trống");
                return;
            }

            Const.NewCongNhan = new CongNhan(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu, bac, to, nhom);
            Const.NewNhanSu = new NhanSu(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu);
            this.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FThemCN_Load(object sender, EventArgs e)
        {
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
            tbTo.DataSource = Const.Listto;
            tbNhom.DataSource = Const.Listnhom;
            tbBac.DataSource = Const.Listbac;
        }
    }
}
