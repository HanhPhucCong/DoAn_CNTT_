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
    public partial class FSuaQL : Form
    {
        public FSuaQL()
        {
            InitializeComponent();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            int indexx = -1;
            if (string.IsNullOrEmpty(tbTen.Text) || dtNgaySinh.Value == null || string.IsNullOrEmpty(tbGioiTinh.Text) || string.IsNullOrEmpty(tbDiaChi.Text) || string.IsNullOrEmpty(tbTrinhDo.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            for (int i = 0; i < ListQuanLy.Instance.Listquanly.Count; i++)
                if (ListQuanLy.Instance.Listquanly[i].Manhansu == Const.NewQuanLy.Manhansu)
                    indexx = i;
            ListQuanLy.Instance.Listquanly[indexx].Hoten = tbTen.Text;
            ListQuanLy.Instance.Listquanly[indexx].Ngaysinh = dtNgaySinh.Value;
            ListQuanLy.Instance.Listquanly[indexx].Gioitinh = tbGioiTinh.Text;
            ListQuanLy.Instance.Listquanly[indexx].Diachi = tbDiaChi.Text;
            ListQuanLy.Instance.Listquanly[indexx].Trinhdo = tbTrinhDo.Text;
            this.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LoadThongTin()
        {
            tbTen.Text = Const.NewQuanLy.Hoten;
            dtNgaySinh.Text = Const.NewQuanLy.Ngaysinh.ToShortDateString();
            tbGioiTinh.Text = Const.NewQuanLy.Gioitinh;
            tbDiaChi.Text = Const.NewQuanLy.Diachi;
            tbTrinhDo.Text = Const.NewQuanLy.Trinhdo;
            tbChucVu.Text = Const.NewQuanLy.Loainhansu;
            tbMaNhanVien.Text = Const.NewQuanLy.Manhansu;
        }
        private void FSuaQL_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
        }
    }
}
