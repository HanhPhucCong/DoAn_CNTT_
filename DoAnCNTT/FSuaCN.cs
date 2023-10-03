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
    public partial class FSuaCN : Form
    {
        public FSuaCN()
        {
            InitializeComponent();
        }

        private void FSuaCN_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewCongNhan.Hoten;
            dtNgaySinh.Text = Const.NewCongNhan.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewCongNhan.Gioitinh;
            tbDiaChi.Text = Const.NewCongNhan.Diachi;
            tbTrinhDo.Text = Const.NewCongNhan.Trinhdo;
            tbChucVu.Text = Const.NewCongNhan.Chucvu;
            tbMaNhanVien.Text = Const.NewCongNhan.Manhansu;
            tbBac.Text = Const.NewCongNhan.Bac;
            tbTo.Text = Const.NewCongNhan.To;
            tbNhom.Text = Const.NewCongNhan.Nhom;
        }

        private void sua_Click(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
