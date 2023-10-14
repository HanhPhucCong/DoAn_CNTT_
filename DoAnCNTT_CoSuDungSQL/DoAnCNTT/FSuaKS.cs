using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNTT
{
    public partial class FSuaKS : Form
    {
        public FSuaKS()
        {
            InitializeComponent();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            int indexx = -1;
            for (int i = 0; i < ListKySu.Instance.Listkysu.Count; i++)
                if (ListKySu.Instance.Listkysu[i].Manhansu == Const.NewKySu.Manhansu)
                    indexx = i;
            ListKySu.Instance.Listkysu[indexx].Hoten = tbTen.Text;
            ListKySu.Instance.Listkysu[indexx].Ngaysinh = dtNgaySinh.Value;
            ListKySu.Instance.Listkysu[indexx].Gioitinh = tbGioiTinh.Text;
            ListKySu.Instance.Listkysu[indexx].Diachi = tbDiaChi.Text;
            ListKySu.Instance.Listkysu[indexx].Trinhdo = tbTrinhDo.Text;
            ListKySu.Instance.Listkysu[indexx].Bophan = tbBoPhan.Text;
            ListKySu.Instance.Listkysu[indexx].Nganhdaotao = tbNganhDaoTao.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FSuaKS_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
            tbBoPhan.DataSource = Const.Listbophan;
            tbNganhDaoTao.DataSource = Const.Listnganh;
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewKySu.Hoten;
            dtNgaySinh.Text = Const.NewKySu.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewKySu.Gioitinh;
            tbDiaChi.Text = Const.NewKySu.Diachi;
            tbTrinhDo.Text = Const.NewKySu.Trinhdo;
            tbChucVu.Text = Const.NewKySu.Loainhansu;
            tbMaNhanVien.Text = Const.NewKySu.Manhansu;
            tbBoPhan.Text = Const.NewKySu.Bophan;
            tbNganhDaoTao.Text = Const.NewKySu.Nganhdaotao;
        }
    }
}
