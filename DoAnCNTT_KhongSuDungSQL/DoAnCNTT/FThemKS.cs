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
            DateTime ngaysinh = dtNgaySinh.Value;
            string gioitinh = tbGioiTinh.Text;
            string diachi = tbDiaChi.Text;
            string trinhdo = tbTrinhDo.Text;
            string manhanvien = tbMaNhanVien.Text;
            string chucvu = tbChucVu.Text;
            string bophan = tbBoPhan.Text;
            string nganhdaotao = tbNganhDaoTao.Text;

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
