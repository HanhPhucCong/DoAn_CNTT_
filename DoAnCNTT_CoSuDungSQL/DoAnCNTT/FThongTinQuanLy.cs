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
            tbTen.Text = Const.NewQuanLy.Hoten;
            tbNgaySinh.Text = Const.NewQuanLy.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewQuanLy.Gioitinh;
            tbDiaChi.Text = Const.NewQuanLy.Diachi;
            tbTrinhDo.Text = Const.NewQuanLy.Trinhdo;
            tbChucVu.Text = Const.NewQuanLy.Loainhansu;
            tbMaNhanVien.Text = Const.NewQuanLy.Manhansu;
        }
        private void FThongTin_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
