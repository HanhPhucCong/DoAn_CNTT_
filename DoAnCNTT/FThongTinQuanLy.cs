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
    public partial class FThongTinQuanLy : Form
    {
        public FThongTinQuanLy()
        {
            InitializeComponent();
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewNhanSu.Hoten;
            tbNgaySinh.Text = Const.NewNhanSu.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewNhanSu.Gioitinh;
            tbDiaChi.Text = Const.NewNhanSu.Diachi;
            tbTrinhDo.Text = Const.NewNhanSu.Trinhdo;
            tbChucVu.Text = Const.NewNhanSu.Chucvu;
            tbMaNhanVien.Text = Const.NewNhanSu.Manhansu;
        }
        private void FThongTin_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
    }
}
