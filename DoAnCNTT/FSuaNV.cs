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
    public partial class FSuaNV : Form
    {
        public FSuaNV()
        {
            InitializeComponent();
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewNhanVien.Hoten;
            dtNgaySinh.Text = Const.NewNhanVien.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewNhanVien.Gioitinh;
            tbDiaChi.Text = Const.NewNhanVien.Diachi;
            tbTrinhDo.Text = Const.NewNhanVien.Trinhdo;
            tbChucVu.Text = Const.NewNhanVien.Chucvu;
            tbMaNhanVien.Text = Const.NewNhanVien.Manhansu;
            tbCongViec.Text = Const.NewNhanVien.Congviec;
            tbPhongBan.Text = Const.NewNhanVien.Phong;
        }
        private void FSuaNV_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {

        }
    }
}
