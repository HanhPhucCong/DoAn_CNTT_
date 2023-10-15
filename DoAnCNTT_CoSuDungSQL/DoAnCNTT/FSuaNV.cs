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
            tbChucVu.Text = Const.NewNhanVien.Loainhansu;
            tbMaNhanVien.Text = Const.NewNhanVien.Manhansu;
            tbCongViec.Text = Const.NewNhanVien.Congviec;
            tbPhongBan.Text = Const.NewNhanVien.Phong;
        }
        private void FSuaNV_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
            tbCongViec.DataSource = Const.Listcongviet;
            tbPhongBan.DataSource = Const.Listphong;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            int indexx = -1;
            if (string.IsNullOrEmpty(tbTen.Text) || dtNgaySinh.Value == null || string.IsNullOrEmpty(tbGioiTinh.Text) || string.IsNullOrEmpty(tbDiaChi.Text) || string.IsNullOrEmpty(tbTrinhDo.Text) || string.IsNullOrEmpty(tbCongViec.Text) || string.IsNullOrEmpty(tbPhongBan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            for (int i = 0; i < ListNhanVien.Instance.Listnhanvien.Count; i++)
                if (ListNhanVien.Instance.Listnhanvien[i].Manhansu == Const.NewNhanVien.Manhansu)
                    indexx = i;
            ListNhanVien.Instance.Listnhanvien[indexx].Hoten = tbTen.Text;
            ListNhanVien.Instance.Listnhanvien[indexx].Ngaysinh = dtNgaySinh.Value;
            ListNhanVien.Instance.Listnhanvien[indexx].Gioitinh = tbGioiTinh.Text;
            ListNhanVien.Instance.Listnhanvien[indexx].Diachi = tbDiaChi.Text;
            ListNhanVien.Instance.Listnhanvien[indexx].Trinhdo = tbTrinhDo.Text;
            ListNhanVien.Instance.Listnhanvien[indexx].Congviec = tbCongViec.Text;
            ListNhanVien.Instance.Listnhanvien[indexx].Phong= tbPhongBan.Text;
            this.Close();
        }
    }
}
