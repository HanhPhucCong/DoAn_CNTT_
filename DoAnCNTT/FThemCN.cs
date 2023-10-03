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
            DateTime ngaysinh = dtNgaySinh.Value;
            string gioitinh = tbGioiTinh.Text;
            string diachi = tbDiaChi.Text;
            string trinhdo = tbTrinhDo.Text;
            string manhanvien = tbMaNhanVien.Text;
            string chucvu = tbChucVu.Text;
            string bac = tbBac.Text;
            string to = tbTo.Text;
            string nhom = tbNhom.Text;

            Const.NewCongNhan = new CongNhan(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu, bac, to, nhom);
            Const.NewNhanSu = new NhanSu(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu);
            this.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
