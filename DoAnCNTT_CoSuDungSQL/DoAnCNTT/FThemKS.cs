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
    public partial class FThemKS : Form
    {
        public FThemKS()
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

            string bophan = tbBoPhan.Text;
            if (string.IsNullOrEmpty(bophan))
            {
                MessageBox.Show("Bộ phận không được để trống");
                return;
            }

            string nganhdaotao = tbNganhDaoTao.Text;
            if (string.IsNullOrEmpty(nganhdaotao))
            {
                MessageBox.Show("Ngành đào tạo không được để trống");
                return;
            }

            Const.NewKySu = new KySu(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu, nganhdaotao, bophan);
            Const.NewNhanSu = new NhanSu(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FThemKS_Load(object sender, EventArgs e)
        {
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
            tbBoPhan.DataSource = Const.Listbophan;
            tbNganhDaoTao.DataSource = Const.Listnganh;
        }
    }
}
