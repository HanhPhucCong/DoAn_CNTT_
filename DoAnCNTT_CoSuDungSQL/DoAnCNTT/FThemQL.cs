using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCNTT
{
    public partial class FThemQL : Form
    {
        public FThemQL()
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

            Const.NewQuanLy = new QuanLy(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu);
            Const.NewNhanSu = new NhanSu(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FThemQL_Load(object sender, EventArgs e)
        {
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
        }
    }
}
