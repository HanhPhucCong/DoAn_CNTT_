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
    public partial class FSuaCN : Form
    {
        public FSuaCN()
        {
            InitializeComponent();
        }

        private void FSuaCN_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
            tbTo.DataSource = Const.Listto;
            tbNhom.DataSource = Const.Listnhom;
            tbBac.DataSource = Const.Listbac;
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
            int indexx = -1;
            for (int i = 0; i < ListCongNhan.Instance.Listcongnhan.Count; i++)
                if (ListCongNhan.Instance.Listcongnhan[i].Manhansu == Const.NewCongNhan.Manhansu)
                    indexx = i;
            ListCongNhan.Instance.Listcongnhan[indexx].Hoten = tbTen.Text;
            ListCongNhan.Instance.Listcongnhan[indexx].Ngaysinh = dtNgaySinh.Value;
            ListCongNhan.Instance.Listcongnhan[indexx].Gioitinh = tbGioiTinh.Text;
            ListCongNhan.Instance.Listcongnhan[indexx].Diachi = tbDiaChi.Text;
            ListCongNhan.Instance.Listcongnhan[indexx].Trinhdo = tbTrinhDo.Text;
            ListCongNhan.Instance.Listcongnhan[indexx].Bac = tbBac.Text;
            ListCongNhan.Instance.Listcongnhan[indexx].To = tbTo.Text;
            ListCongNhan.Instance.Listcongnhan[indexx].Nhom = tbNhom.Text;
            this.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
