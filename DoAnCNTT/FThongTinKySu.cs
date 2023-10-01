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
    public partial class FThongTinKySu : Form
    {
        public FThongTinKySu()
        {
            InitializeComponent();
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewKySu.Hoten;
            tbNgaySinh.Text = Const.NewKySu.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewKySu.Gioitinh;
            tbDiaChi.Text = Const.NewKySu.Diachi;
            tbTrinhDo.Text = Const.NewKySu.Trinhdo;
            tbChucVu.Text = Const.NewKySu.Chucvu;
            tbMaNhanVien.Text = Const.NewKySu.Manhansu;
            tbBoPhan.Text = Const.NewKySu.Bophan;
            tbNganhDaoTao.Text = Const.NewKySu.Nganhdaotao;
        }
        private void FThongTinKySu_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
    }
}
