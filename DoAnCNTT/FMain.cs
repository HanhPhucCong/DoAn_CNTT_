using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
            tbGioiTinh.DataSource = Const.Listgioitinh;
            tbTrinhDo.DataSource = Const.Listtrinhdo;
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
                toolStripDropDownButton2.Enabled = false;
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
                case "Quản lý":
                    GanConstQuanLy(index);
                    break;
                case "Kỹ sư":
                    GanConstKySu(index);
                    break;
                case "Nhân viên":
                    GanConstNhanVien(index);
                    break;
                case "Công nhân":
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
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xem.");
                return;
            }
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quản lý":
                    LoadFormQuanLy();
                    break;
                case "Kỹ sư":
                    LoadFormKySu();
                    break;
                case "Nhân viên":
                    LoadFormNhanVien();
                    break;
                case "Công nhân":
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
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xem.");
                return;
            }
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quản lý":
                    LoadFormQuanLy();
                    break;
                case "Kỹ sư":
                    LoadFormKySu();
                    break;
                case "Nhân viên":
                    LoadFormNhanVien();
                    break;
                case "Công nhân":
                    LoadFormCongNhan();
                    break;
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDanhSach();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xóa.");
                return;
            }
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quản lý":
                    LoadSuaQL();
                    break;
                case "Kỹ sư":
                    LoadSuaKS();
                    break;
                case "Nhân viên":
                    LoadSuaNV();
                    break;
                case "Công nhân":
                    LoadSuaCN();
                    break;
            }
        }

        private void lbxoa_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xóa.");
                return;
            }
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quản lý":
                    XoaQL();
                    break;
                case "Kỹ sư":
                    XoaKS();
                    break;
                case "Nhân viên":
                    XoaNV();
                    break;
                case "Công nhân":
                    XoaCN();
                    break;
            }
        }
        void XoaNV()
        {
            int indexx = -1;
            for (int i = 0; i < ListNhanVien.Instance.Listnhanvien.Count; i++)
                if (ListNhanVien.Instance.Listnhanvien[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListNhanVien.Instance.Listnhanvien.RemoveAt(indexx);
            ListNhanSu.Instance.Listnhansu.RemoveAt(index);
            LoadDanhSach();
        }
        void XoaQL()
        {
            int indexx = -1;
            for (int i = 0; i < ListQuanLy.Instance.Listquanly.Count; i++)
                if (ListQuanLy.Instance.Listquanly[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListQuanLy.Instance.Listquanly.RemoveAt(indexx);
            ListNhanSu.Instance.Listnhansu.RemoveAt(index);
            LoadDanhSach();
        }
        void XoaCN()
        {
            int indexx = -1;
            for (int i = 0; i < ListCongNhan.Instance.Listcongnhan.Count; i++)
                if (ListCongNhan.Instance.Listcongnhan[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListCongNhan.Instance.Listcongnhan.RemoveAt(indexx);
            ListNhanSu.Instance.Listnhansu.RemoveAt(index);
            LoadDanhSach();
        }
        void XoaKS()
        {
            int indexx = -1;
            for (int i = 0; i < ListKySu.Instance.Listkysu.Count; i++)
                if (ListKySu.Instance.Listkysu[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListKySu.Instance.Listkysu.RemoveAt(indexx);
            ListNhanSu.Instance.Listnhansu.RemoveAt(index);
            LoadDanhSach();
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để sửa.");
                return;
            }
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quản lý":
                    LoadSuaQL();
                    break;
                case "Kỹ sư":
                    LoadSuaKS();
                    break;
                case "Nhân viên":
                    LoadSuaNV();
                    break;
                case "Công nhân":
                    LoadSuaCN();
                    break;
            }
        }
        void LoadSuaKS()
        {
            FSuaKS form = new FSuaKS();
            form.FormClosed += Form_FormClosed1;
            form.ShowDialog();
        }
        private void Form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            int indexx = -1;
            for (int i = 0; i < ListKySu.Instance.Listkysu.Count; i++)
                if (ListKySu.Instance.Listkysu[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListNhanSu.Instance.Listnhansu[index].Hoten = ListKySu.Instance.Listkysu[indexx].Hoten;
            ListNhanSu.Instance.Listnhansu[index].Ngaysinh = ListKySu.Instance.Listkysu[indexx].Ngaysinh;
            ListNhanSu.Instance.Listnhansu[index].Diachi = ListKySu.Instance.Listkysu[indexx].Diachi;
            ListNhanSu.Instance.Listnhansu[index].Gioitinh = ListKySu.Instance.Listkysu[indexx].Gioitinh;
            ListNhanSu.Instance.Listnhansu[index].Trinhdo = ListKySu.Instance.Listkysu[indexx].Trinhdo;
            LoadDanhSach();
        }
        void LoadSuaQL()
        {
            FSuaQL form = new FSuaQL();
            form.FormClosed += Form_FormClosed2;
            form.ShowDialog();
        }
        private void Form_FormClosed2(object sender, FormClosedEventArgs e)
        {
            int indexx = -1;
            for (int i = 0; i < ListQuanLy.Instance.Listquanly.Count; i++)
                if (ListQuanLy.Instance.Listquanly[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListNhanSu.Instance.Listnhansu[index].Hoten = ListQuanLy.Instance.Listquanly[indexx].Hoten;
            ListNhanSu.Instance.Listnhansu[index].Ngaysinh = ListQuanLy.Instance.Listquanly[indexx].Ngaysinh;
            ListNhanSu.Instance.Listnhansu[index].Diachi = ListQuanLy.Instance.Listquanly[indexx].Diachi;
            ListNhanSu.Instance.Listnhansu[index].Gioitinh = ListQuanLy.Instance.Listquanly[indexx].Gioitinh;
            ListNhanSu.Instance.Listnhansu[index].Trinhdo = ListQuanLy.Instance.Listquanly[indexx].Trinhdo;
            LoadDanhSach();
        }
        void LoadSuaNV()
        {
            FSuaNV form = new FSuaNV();
            form.FormClosed += Form_FormClosed3;
            form.ShowDialog();
        }
        private void Form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            int indexx = -1;
            for (int i = 0; i < ListNhanVien.Instance.Listnhanvien.Count; i++)
                if (ListNhanVien.Instance.Listnhanvien[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListNhanSu.Instance.Listnhansu[index].Hoten = ListNhanVien.Instance.Listnhanvien[indexx].Hoten;
            ListNhanSu.Instance.Listnhansu[index].Ngaysinh = ListNhanVien.Instance.Listnhanvien[indexx].Ngaysinh;
            ListNhanSu.Instance.Listnhansu[index].Diachi = ListNhanVien.Instance.Listnhanvien[indexx].Diachi;
            ListNhanSu.Instance.Listnhansu[index].Gioitinh = ListNhanVien.Instance.Listnhanvien[indexx].Gioitinh;
            ListNhanSu.Instance.Listnhansu[index].Trinhdo = ListNhanVien.Instance.Listnhanvien[indexx].Trinhdo;
            LoadDanhSach();
        }
        void LoadSuaCN()
        {
            FSuaCN form = new FSuaCN();
            form.FormClosed += Form_FormClosed4;
            form.ShowDialog();
        }
        private void Form_FormClosed4(object sender, FormClosedEventArgs e)
        {
            int indexx = -1;
            for (int i = 0; i < ListCongNhan.Instance.Listcongnhan.Count; i++)
                if (ListCongNhan.Instance.Listcongnhan[i].Manhansu == ListNhanSu.Instance.Listnhansu[index].Manhansu)
                    indexx = i;
            ListNhanSu.Instance.Listnhansu[index].Hoten = ListCongNhan.Instance.Listcongnhan[indexx].Hoten;
            ListNhanSu.Instance.Listnhansu[index].Ngaysinh = ListCongNhan.Instance.Listcongnhan[indexx].Ngaysinh;
            ListNhanSu.Instance.Listnhansu[index].Diachi = ListCongNhan.Instance.Listcongnhan[indexx].Diachi;
            ListNhanSu.Instance.Listnhansu[index].Gioitinh = ListCongNhan.Instance.Listcongnhan[indexx].Gioitinh;
            ListNhanSu.Instance.Listnhansu[index].Trinhdo = ListCongNhan.Instance.Listcongnhan[indexx].Trinhdo;
            LoadDanhSach();
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để sửa.");
                return;
            }
            switch (ListNhanSu.Instance.Listnhansu[index].Chucvu)
            {
                case "Quản lý":
                    LoadSuaQL();
                    break;
                case "Kỹ sư":
                    LoadSuaKS();
                    break;
                case "Nhân viên":
                    LoadSuaNV();
                    break;
                case "Công nhân":
                    LoadSuaCN();
                    break;
            }
        }

        private void thêmQuảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Const.NewQuanLy = null;
            Const.NewNhanSu = null;
            FThemQL form = new FThemQL();
            form.FormClosed += Form_FormClosed5;
            form.ShowDialog();
        }

        private void Form_FormClosed5(object sender, FormClosedEventArgs e)
        {
            if (Const.NewQuanLy != null)
            {
                ListQuanLy.Instance.Listquanly.Add(Const.NewQuanLy);
                ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
                LoadDanhSach();
            }
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Const.NewNhanVien = null;
            Const.NewNhanSu = null;
            FThemNV form = new FThemNV();
            form.FormClosed += Form_FormClosed6;
            form.ShowDialog();
        }

        private void Form_FormClosed6(object sender, FormClosedEventArgs e)
        {
            if (Const.NewNhanVien != null)
            {
                ListNhanVien.Instance.Listnhanvien.Add(Const.NewNhanVien);
                ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
                LoadDanhSach();
            }
        }

        private void thêmKỹSưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Const.NewKySu = null;
            Const.NewNhanSu = null;
            FThemKS form = new FThemKS();
            form.FormClosed += Form_FormClosed7;
            form.ShowDialog();
        }

        private void Form_FormClosed7(object sender, FormClosedEventArgs e)
        {
            if (Const.NewKySu != null)
            {
                ListKySu.Instance.Listkysu.Add(Const.NewKySu);
                ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
                LoadDanhSach();
            }
        }

        private void thêmCôngNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Const.NewCongNhan = null;
            Const.NewNhanSu = null;
            FThemCN form = new FThemCN();
            form.FormClosed += Form_FormClosed8;
            form.ShowDialog();
        }

        private void Form_FormClosed8(object sender, FormClosedEventArgs e)
        {
            if (Const.NewCongNhan != null)
            {
                ListCongNhan.Instance.Listcongnhan.Add(Const.NewCongNhan);
                ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
                LoadDanhSach();
            }
        }
        public void ExportToExcel(DataTable dataTable)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Danh sách";

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = "Danh sách";
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "24";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã nhân viên";
            cl1.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ và tên";
            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày sinh";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Giới tính";
            cl4.ColumnWidth = 15.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Địa chỉ";
            cl5.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Trình độ";
            cl6.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Chức vụ";
            cl7.ColumnWidth = 18.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                    arr[row, col] = dataRow[col];
            }

            int rowStart = 4;
            int colStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 2;
            int colEnd = dataTable.Columns.Count;

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            range.Value2 = arr;

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void xuatfilebang_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã nhân viên");
            DataColumn col2 = new DataColumn("Họ và tên");
            DataColumn col3 = new DataColumn("Ngày sinh");
            DataColumn col4 = new DataColumn("Giới tính");
            DataColumn col5 = new DataColumn("Địa chỉ");
            DataColumn col6 = new DataColumn("Trình độ");
            DataColumn col7 = new DataColumn("Chức vụ");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = dataGridViewRow.Cells[0].Value;
                dataRow[1] = dataGridViewRow.Cells[1].Value;
                dataRow[2] = dataGridViewRow.Cells[2].Value;
                dataRow[3] = dataGridViewRow.Cells[3].Value;
                dataRow[4] = dataGridViewRow.Cells[4].Value;
                dataRow[5] = dataGridViewRow.Cells[5].Value;
                dataRow[6] = dataGridViewRow.Cells[6].Value;

                dataTable.Rows.Add(dataRow);
            }
            ExportToExcel(dataTable);
        }
        private void côngNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcelCN(ListCongNhan.Instance.Listcongnhan);
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcelNV(ListNhanVien.Instance.Listnhanvien);
        }
        private void kỷSưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcelKS(ListKySu.Instance.Listkysu);
        }
        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportToExcelQL(ListQuanLy.Instance.Listquanly);
        }
        private void Xuatexcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("Mã nhân viên");
            DataColumn col2 = new DataColumn("Họ và tên");
            DataColumn col3 = new DataColumn("Ngày sinh");
            DataColumn col4 = new DataColumn("Giới tính");
            DataColumn col5 = new DataColumn("Địa chỉ");
            DataColumn col6 = new DataColumn("Trình độ");
            DataColumn col7 = new DataColumn("Chức vụ");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = dataGridViewRow.Cells[0].Value;
                dataRow[1] = dataGridViewRow.Cells[1].Value;
                dataRow[2] = dataGridViewRow.Cells[2].Value;
                dataRow[3] = dataGridViewRow.Cells[3].Value;
                dataRow[4] = dataGridViewRow.Cells[4].Value;
                dataRow[5] = dataGridViewRow.Cells[5].Value;
                dataRow[6] = dataGridViewRow.Cells[6].Value;

                dataTable.Rows.Add(dataRow);
            }
            ExportToExcel(dataTable);
        }
        public void ExportToExcelCN(List<CongNhan> danhSachCongNhan)
        {
            Excel.Application excelApp = new Excel.Application();

            if (excelApp != null)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];


                excelWorksheet.Cells[1, 1] = "Mã nhân sự";
                excelWorksheet.Cells[1, 2] = "Họ tên";
                excelWorksheet.Cells[1, 3] = "Ngày sinh";
                excelWorksheet.Cells[1, 4] = "Giới tính";
                excelWorksheet.Cells[1, 5] = "Địa chỉ";
                excelWorksheet.Cells[1, 6] = "Trình độ";
                excelWorksheet.Cells[1, 7] = "Chức vụ";
                excelWorksheet.Cells[1, 8] = "Bậc";
                excelWorksheet.Cells[1, 9] = "Tổ";
                excelWorksheet.Cells[1, 10] = "Nhóm";

                ((Excel.Range)excelWorksheet.Columns[1]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[2]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[3]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[4]).ColumnWidth = 15;
                ((Excel.Range)excelWorksheet.Columns[5]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[6]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[7]).ColumnWidth = 18;
                ((Excel.Range)excelWorksheet.Columns[8]).ColumnWidth = 10;
                ((Excel.Range)excelWorksheet.Columns[9]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[10]).ColumnWidth = 10;
                for (int i = 0; i < danhSachCongNhan.Count; i++)
                {
                    CongNhan cn = danhSachCongNhan[i];
                    excelWorksheet.Cells[i + 2, 1] = cn.Manhansu;
                    excelWorksheet.Cells[i + 2, 2] = cn.Hoten;
                    excelWorksheet.Cells[i + 2, 3] = cn.Ngaysinh.ToString("dd/MM/yyyy");
                    excelWorksheet.Cells[i + 2, 4] = cn.Gioitinh;
                    excelWorksheet.Cells[i + 2, 5] = cn.Diachi;
                    ((Excel.Range)excelWorksheet.Cells[i + 2, 6]).NumberFormat = "@";
                    excelWorksheet.Cells[i + 2, 6] = cn.Trinhdo.ToString();
                    excelWorksheet.Cells[i + 2, 7] = cn.Chucvu;
                    excelWorksheet.Cells[i + 2, 8] = cn.Bac;
                    excelWorksheet.Cells[i + 2, 9] = cn.To;
                    excelWorksheet.Cells[i + 2, 10] = cn.Nhom;
                }
                excelApp.Visible = true;
            }
        }
        public void ExportToExcelNV(List<NhanVien> danhSachNhanVien)
        {
            Excel.Application excelApp = new Excel.Application();

            if (excelApp != null)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];


                excelWorksheet.Cells[1, 1] = "Mã nhân sự";
                excelWorksheet.Cells[1, 2] = "Họ tên";
                excelWorksheet.Cells[1, 3] = "Ngày sinh";
                excelWorksheet.Cells[1, 4] = "Giới tính";
                excelWorksheet.Cells[1, 5] = "Địa chỉ";
                excelWorksheet.Cells[1, 6] = "Trình độ";
                excelWorksheet.Cells[1, 7] = "Chức vụ";
                excelWorksheet.Cells[1, 8] = "Công việc";
                excelWorksheet.Cells[1, 9] = "Phòng";

                ((Excel.Range)excelWorksheet.Columns[1]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[2]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[3]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[4]).ColumnWidth = 15;
                ((Excel.Range)excelWorksheet.Columns[5]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[6]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[7]).ColumnWidth = 18;
                ((Excel.Range)excelWorksheet.Columns[8]).ColumnWidth = 18;
                ((Excel.Range)excelWorksheet.Columns[9]).ColumnWidth = 18;
                for (int i = 0; i < danhSachNhanVien.Count; i++)
                {
                    NhanVien nv = danhSachNhanVien[i];
                    excelWorksheet.Cells[i + 2, 1] = nv.Manhansu;
                    excelWorksheet.Cells[i + 2, 2] = nv.Hoten;
                    excelWorksheet.Cells[i + 2, 3] = nv.Ngaysinh.ToString("dd/MM/yyyy");
                    excelWorksheet.Cells[i + 2, 4] = nv.Gioitinh;
                    excelWorksheet.Cells[i + 2, 5] = nv.Diachi;
                    ((Excel.Range)excelWorksheet.Cells[i + 2, 6]).NumberFormat = "@";
                    excelWorksheet.Cells[i + 2, 6] = nv.Trinhdo.ToString();
                    excelWorksheet.Cells[i + 2, 7] = nv.Chucvu;
                    excelWorksheet.Cells[i + 2, 8] = nv.Congviec;
                    excelWorksheet.Cells[i + 2, 9] = nv.Phong;
                }
                excelApp.Visible = true;
            }
        }
        public void ExportToExcelKS(List<KySu> danhSachKySu)
        {
            Excel.Application excelApp = new Excel.Application();

            if (excelApp != null)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];


                excelWorksheet.Cells[1, 1] = "Mã nhân sự";
                excelWorksheet.Cells[1, 2] = "Họ tên";
                excelWorksheet.Cells[1, 3] = "Ngày sinh";
                excelWorksheet.Cells[1, 4] = "Giới tính";
                excelWorksheet.Cells[1, 5] = "Địa chỉ";
                excelWorksheet.Cells[1, 6] = "Trình độ";
                excelWorksheet.Cells[1, 7] = "Chức vụ";
                excelWorksheet.Cells[1, 8] = "Ngành đào tạo";
                excelWorksheet.Cells[1, 9] = "Bộ phận";

                ((Excel.Range)excelWorksheet.Columns[1]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[2]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[3]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[4]).ColumnWidth = 15;
                ((Excel.Range)excelWorksheet.Columns[5]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[6]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[7]).ColumnWidth = 18;
                ((Excel.Range)excelWorksheet.Columns[8]).ColumnWidth = 18;
                ((Excel.Range)excelWorksheet.Columns[9]).ColumnWidth = 18;
                for (int i = 0; i < danhSachKySu.Count; i++)
                {
                    KySu ks = danhSachKySu[i];
                    excelWorksheet.Cells[i + 2, 1] = ks.Manhansu;
                    excelWorksheet.Cells[i + 2, 2] = ks.Hoten;
                    excelWorksheet.Cells[i + 2, 3] = ks.Ngaysinh.ToString("dd/MM/yyyy");
                    excelWorksheet.Cells[i + 2, 4] = ks.Gioitinh;
                    excelWorksheet.Cells[i + 2, 5] = ks.Diachi;
                    ((Excel.Range)excelWorksheet.Cells[i + 2, 6]).NumberFormat = "@";
                    excelWorksheet.Cells[i + 2, 6] = ks.Trinhdo.ToString();
                    excelWorksheet.Cells[i + 2, 7] = ks.Chucvu;
                    excelWorksheet.Cells[i + 2, 8] = ks.Nganhdaotao;
                    excelWorksheet.Cells[i + 2, 9] = ks.Bophan;
                }
                excelApp.Visible = true;
            }
        }
        public void ExportToExcelQL(List<QuanLy> danhSachQuanLy)
        {
            Excel.Application excelApp = new Excel.Application();

            if (excelApp != null)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];


                excelWorksheet.Cells[1, 1] = "Mã nhân sự";
                excelWorksheet.Cells[1, 2] = "Họ tên";
                excelWorksheet.Cells[1, 3] = "Ngày sinh";
                excelWorksheet.Cells[1, 4] = "Giới tính";
                excelWorksheet.Cells[1, 5] = "Địa chỉ";
                excelWorksheet.Cells[1, 6] = "Trình độ";
                excelWorksheet.Cells[1, 7] = "Chức vụ";


                ((Excel.Range)excelWorksheet.Columns[1]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[2]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[3]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[4]).ColumnWidth = 15;
                ((Excel.Range)excelWorksheet.Columns[5]).ColumnWidth = 25;
                ((Excel.Range)excelWorksheet.Columns[6]).ColumnWidth = 12;
                ((Excel.Range)excelWorksheet.Columns[7]).ColumnWidth = 18;
                ;
                for (int i = 0; i < danhSachQuanLy.Count; i++)
                {
                    QuanLy ql = danhSachQuanLy[i];
                    excelWorksheet.Cells[i + 2, 1] = ql.Manhansu;
                    excelWorksheet.Cells[i + 2, 2] = ql.Hoten;
                    excelWorksheet.Cells[i + 2, 3] = ql.Ngaysinh.ToString("dd/MM/yyyy");
                    excelWorksheet.Cells[i + 2, 4] = ql.Gioitinh;
                    excelWorksheet.Cells[i + 2, 5] = ql.Diachi;
                    ((Excel.Range)excelWorksheet.Cells[i + 2, 6]).NumberFormat = "@";
                    excelWorksheet.Cells[i + 2, 6] = ql.Trinhdo.ToString();
                    excelWorksheet.Cells[i + 2, 7] = ql.Chucvu;
                }
                excelApp.Visible = true;
            }
        }

        private void ButtonTimkiem_Click(object sender, EventArgs e)
        {
            List<NhanSu> ListNhanSuTim = TimKiem(ListNhanSu.Instance.Listnhansu, tbMaNhanVien.Text, tbHoTen.Text, tbNgaySinh.Value, tbGioiTinh.Text, tbDiaChi.Text, tbTrinhDo.Text, tbChucVu.Text);

        }
        public List<NhanSu> TimKiem(List<NhanSu> danhSachNhanSu, string manhansu, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string trinhdo, string chucvu)
        {
            var ketqua = danhSachNhanSu;

            if (!string.IsNullOrEmpty(manhansu))
                ketqua = ketqua.Where(ns => ns.Manhansu.Contains(manhansu)).ToList();

            if (!string.IsNullOrEmpty(hoten))
                ketqua = ketqua.Where(ns => ns.Hoten.Contains(hoten)).ToList();

            if (ngaysinh != null)
                ketqua = ketqua.Where(ns => ns.Ngaysinh == ngaysinh).ToList();

            if (!string.IsNullOrEmpty(gioitinh))
                ketqua = ketqua.Where(ns => ns.Gioitinh.Contains(gioitinh)).ToList();

            if (!string.IsNullOrEmpty(diachi))
                ketqua = ketqua.Where(ns => ns.Diachi.Contains(diachi)).ToList();

            if (!string.IsNullOrEmpty(trinhdo))
                ketqua = ketqua.Where(ns => ns.Trinhdo.Contains(trinhdo)).ToList();

            if (!string.IsNullOrEmpty(chucvu))
                ketqua = ketqua.Where(ns => ns.Chucvu.Contains(chucvu)).ToList();

            return ketqua;
        }
    }
}