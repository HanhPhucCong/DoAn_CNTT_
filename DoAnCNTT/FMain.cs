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
    public partial class FMain : Form
    {
        int index = -1;
        public bool isExit = true;
        public event EventHandler Logout;
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            PhanLoai();
            LoadDanhSach();
        }
        void LoadDanhSach()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ListNhanSu.Instance.Listnhansu)
                dataGridView1.Rows.Add(item.Manhansu, item.Hoten, item.Ngaysinh.ToShortDateString(), item.Gioitinh, item.Diachi, item.Trinhdo, item.Chucvu);
        }
        void PhanLoai()
        {
            if (Const.loai != "Quan ly")
            {
                Them.Enabled = false;
                Xoa.Enabled = false;
                Sua.Enabled = false;
                quảnLýToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                toolStripLabel1.Enabled = false;
                lbxoa.Enabled = false;
                toolStripLabel2.Enabled = false;
            }
        }
        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                if (MessageBox.Show("Bạn Muốn Thoát ?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Application.Exit(); ;
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTaiKhoan form = new FTaiKhoan();
            form.Show();
            this.Hide();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPhong form = new FPhong();
            form.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
                return;
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quan ly":
                    GanConstQuanLy(index);
                    break;
                case "Ky su":
                    GanConstKySu(index);
                    break;
                case "Nhan vien":
                    GanConstNhanVien(index);
                    break;
                case "Cong nhan":
                    GanConstCongNhan(index);
                    break;
            }
        }
        void GanConstCongNhan(int index)
        {
            int indexx = -1;
            for (int i = 0; i < ListCongNhan.Instance.Listcongnhan.Count; i++)
                if (ListCongNhan.Instance.Listcongnhan[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            Const.NewCongNhan = new CongNhan();
            Const.NewCongNhan.Manhansu = ListCongNhan.Instance.Listcongnhan[indexx].Manhansu;
            Const.NewCongNhan.Hoten = ListCongNhan.Instance.Listcongnhan[indexx].Hoten;
            Const.NewCongNhan.Ngaysinh = ListCongNhan.Instance.Listcongnhan[indexx].Ngaysinh;
            Const.NewCongNhan.Gioitinh = ListCongNhan.Instance.Listcongnhan[indexx].Gioitinh;
            Const.NewCongNhan.Diachi = ListCongNhan.Instance.Listcongnhan[indexx].Diachi;
            Const.NewCongNhan.Trinhdo = ListCongNhan.Instance.Listcongnhan[indexx].Trinhdo;
            Const.NewCongNhan.Chucvu = ListCongNhan.Instance.Listcongnhan[indexx].Chucvu;
            Const.NewCongNhan.Bac = ListCongNhan.Instance.Listcongnhan[indexx].Bac;
            Const.NewCongNhan.To = ListCongNhan.Instance.Listcongnhan[indexx].To;
            Const.NewCongNhan.Nhom = ListCongNhan.Instance.Listcongnhan[indexx].Nhom;
        }
        void GanConstKySu(int index)
        {
            int indexx = -1;
            for (int i = 0; i < ListKySu.Instance.Listkysu.Count; i++)
                if (ListKySu.Instance.Listkysu[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            Const.NewKySu = new KySu();
            Const.NewKySu.Manhansu = ListKySu.Instance.Listkysu[indexx].Manhansu;
            Const.NewKySu.Hoten = ListKySu.Instance.Listkysu[indexx].Hoten;
            Const.NewKySu.Ngaysinh = ListKySu.Instance.Listkysu[indexx].Ngaysinh;
            Const.NewKySu.Gioitinh = ListKySu.Instance.Listkysu[indexx].Gioitinh;
            Const.NewKySu.Diachi = ListKySu.Instance.Listkysu[indexx].Diachi;
            Const.NewKySu.Trinhdo = ListKySu.Instance.Listkysu[indexx].Trinhdo;
            Const.NewKySu.Chucvu = ListKySu.Instance.Listkysu[indexx].Chucvu;
            Const.NewKySu.Bophan = ListKySu.Instance.Listkysu[indexx].Bophan;
            Const.NewKySu.Nganhdaotao = ListKySu.Instance.Listkysu[indexx].Nganhdaotao;
        }
        void GanConstNhanVien(int index)
        {
            int indexx = -1;
            for (int i = 0; i < ListNhanVien.Instance.Listnhanvien.Count; i++)
                if (ListNhanVien.Instance.Listnhanvien[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            Const.NewNhanVien = new NhanVien();
            Const.NewNhanVien.Manhansu = ListNhanVien.Instance.Listnhanvien[indexx].Manhansu;
            Const.NewNhanVien.Hoten = ListNhanVien.Instance.Listnhanvien[indexx].Hoten;
            Const.NewNhanVien.Ngaysinh = ListNhanVien.Instance.Listnhanvien[indexx].Ngaysinh;
            Const.NewNhanVien.Gioitinh = ListNhanVien.Instance.Listnhanvien[indexx].Gioitinh;
            Const.NewNhanVien.Diachi = ListNhanVien.Instance.Listnhanvien[indexx].Diachi;
            Const.NewNhanVien.Trinhdo = ListNhanVien.Instance.Listnhanvien[indexx].Trinhdo;
            Const.NewNhanVien.Chucvu = ListNhanVien.Instance.Listnhanvien[indexx].Chucvu;
            Const.NewNhanVien.Congviec = ListNhanVien.Instance.Listnhanvien[indexx].Congviec;
            Const.NewNhanVien.Phong = ListNhanVien.Instance.Listnhanvien[indexx].Phong;
        }
        void GanConstQuanLy(int index)
        {
            int indexx = -1;
            for (int i = 0; i < ListQuanLy.Instance.Listquanly.Count; i++)
                if (ListQuanLy.Instance.Listquanly[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            Const.NewQuanLy = new QuanLy();
            Const.NewQuanLy.Manhansu = ListQuanLy.Instance.Listquanly[indexx].Manhansu;
            Const.NewQuanLy.Hoten = ListQuanLy.Instance.Listquanly[indexx].Hoten;
            Const.NewQuanLy.Ngaysinh = ListQuanLy.Instance.Listquanly[indexx].Ngaysinh;
            Const.NewQuanLy.Gioitinh = ListQuanLy.Instance.Listquanly[indexx].Gioitinh;
            Const.NewQuanLy.Diachi = ListQuanLy.Instance.Listquanly[indexx].Diachi;
            Const.NewQuanLy.Trinhdo = ListQuanLy.Instance.Listquanly[indexx].Trinhdo;
            Const.NewQuanLy.Chucvu = ListQuanLy.Instance.Listquanly[indexx].Chucvu;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            switch(ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quan ly":
                    LoadFormQuanLy();
                    break;
                case "Ky su":
                    LoadFormKySu();
                    break;
                case "Nhan vien":
                    LoadFormNhanVien();
                    break;
                case "Cong nhan":
                    LoadFormCongNhan();
                    break;
            }
        }
        void LoadFormCongNhan()
        {
            FThongTinCongNhan form = new FThongTinCongNhan();
            form.ShowDialog();
        }
        void LoadFormKySu()
        {
            FThongTinKySu form = new FThongTinKySu();
            form.ShowDialog();
        }
        void LoadFormNhanVien()
        {
            FThongTinNhanVien form = new FThongTinNhanVien();
            form.ShowDialog();
        }
        void LoadFormQuanLy()
        {
            FThongTinQuanLy form = new FThongTinQuanLy();
            form.ShowDialog();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quan ly":
                    LoadFormQuanLy();
                    break;
                case "Ky su":
                    LoadFormKySu();
                    break;
                case "Nhan vien":
                    LoadFormNhanVien();
                    break;
                case "Cong nhan":
                    LoadFormCongNhan();
                    break;
            }
        }
        private void Them_Click(object sender, EventArgs e)
        {
            FThem form = new FThem();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDanhSach();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FThem form = new FThem();
            form.ShowDialog();
        }
    }
}
