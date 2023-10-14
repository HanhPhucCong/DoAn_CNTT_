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
    public partial class FThongTinCongNhan : Form
    {
        public FThongTinCongNhan()
        {
            InitializeComponent();
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewCongNhan.Hoten;
            tbNgaySinh.Text = Const.NewCongNhan.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewCongNhan.Gioitinh;
            tbDiaChi.Text = Const.NewCongNhan.Diachi;
            tbTrinhDo.Text = Const.NewCongNhan.Trinhdo;
            tbChucVu.Text = Const.NewCongNhan.Loainhansu;
            tbMaNhanVien.Text = Const.NewCongNhan.Manhansu;
            tbBac.Text = Const.NewCongNhan.Bac;
            tbTo.Text = Const.NewCongNhan.To;
            tbNhom.Text = Const.NewCongNhan.Nhom;
        }
        private void FThongTinCongNhan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
