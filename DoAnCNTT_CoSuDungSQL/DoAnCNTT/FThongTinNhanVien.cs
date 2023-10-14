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
    public partial class FThongTinNhanVien : Form
    {
        public FThongTinNhanVien()
        {
            InitializeComponent();
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewNhanVien.Hoten;
            tbNgaySinh.Text = Const.NewNhanVien.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewNhanVien.Gioitinh;
            tbDiaChi.Text = Const.NewNhanVien.Diachi;
            tbTrinhDo.Text = Const.NewNhanVien.Trinhdo;
            tbChucVu.Text = Const.NewNhanVien.Loainhansu;
            tbMaNhanVien.Text = Const.NewNhanVien.Manhansu;
            tbCongViec.Text = Const.NewNhanVien.Congviec;
            tbPhongBan.Text = Const.NewNhanVien.Phong;
        }
        private void FThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
