using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DoAnCNTT
{
    public class Const
    {
        public static NhanSu NewNhanSu = null;
        public static NhanVien NewNhanVien = null;
        public static QuanLy NewQuanLy = null;
        public static CongNhan NewCongNhan = null;
        public static KySu NewKySu = null;
        public static User NewUser = null;
        public static string loai;

        public static List<string> Listgioitinh = new List<string>() { "Nam", "Nư", "Giới tính thứ 3", "Không xác định" };
        public static List<string> Listtrinhdo = new List<string>() { "1/12", "2/12", "3/12", "4/12", "5/12", "6/12", "7/12", "8/12", "9/12", "10/12", "11/12", "12/12", "Cao đẳng", "Đại học" };

        public static List<string> Listphong = new List<string>() { "Phòng nhân sự", "Phòng công nghệ", "Phòng kế toán", "Phòng xây dựng", "Phòng thiết kế" };
        public static List<string> Listcongviet = new List<string>() { "Kế toán", "Xây dựng", "Thiết kế", "Giám sát công trình", "Công nhân" };

        public static List<string> Listbac = new List<string>() { "Bậc 1", "Bậc 2", "Bậc 3", "Bậc 4", "Bậc 5", "Bậc 6", "Bậc 7" };
        public static List<string> Listto = new List<string>() { "Tổ xây dựng", "Tổ thiết kế", "Tổ công nghệ", "Tổ Kế toán", "Tổ kinh doanh" };
        public static List<string> Listnhom = new List<string>() { "Nhóm 1", "Nhóm 2", "Nhóm 3", "Nhóm 4", "Nhóm 5", "Nhóm 6", "Nhóm 7" };


        public static List<string> Listbophan = new List<string>() { "Bộ phận xây dựng", "Bộ phận thiết kế", "Bộp phận công nghệ thông tin", "Bộp phận quản lý" };
        public static List<string> Listnganh = new List<string>() { "Ngành thiết kế", "Ngành công nghệ thông tin", "Ngành xây dựng", "Ngành kinh doanh" };

        public static void LuuDanhSachNguoiDung(List<User> danhSachNguoiDung)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<User>));
            TextWriter txtWriter = new StreamWriter(@"NguoiDung.xml");

            xs.Serialize(txtWriter, danhSachNguoiDung);

            txtWriter.Close();
        }
        public static List<User> DocDanhSachNguoiDung()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<User>));
            StreamReader reader = new StreamReader(@"NguoiDung.xml");

            List<User> danhSachNguoiDung = (List<User>)xs.Deserialize(reader);
            reader.Close();

            return danhSachNguoiDung;
        }

        public static void LuuDanhSachNhanSu(List<NhanSu> danhSachNhanSu)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<NhanSu>));
            TextWriter txtWriter = new StreamWriter(@"NhanSu.xml");

            xs.Serialize(txtWriter, danhSachNhanSu);

            txtWriter.Close();
        }
        public static List<NhanSu> DocDanhSachNhanSu()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<NhanSu>));
            StreamReader reader = new StreamReader(@"NhanSu.xml");

            List<NhanSu> danhSachNhanSu = (List<NhanSu>)xs.Deserialize(reader);
            reader.Close();

            return danhSachNhanSu;
        }
        public static void LuuDanhSachKySu(List<KySu> danhSachKySu)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<KySu>));
            TextWriter txtWriter = new StreamWriter(@"KySu.xml");

            xs.Serialize(txtWriter, danhSachKySu);

            txtWriter.Close();
        }

        public static List<KySu> DocDanhSachKySu()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<KySu>));
            StreamReader reader = new StreamReader(@"KySu.xml");

            List<KySu> danhSachKySu = (List<KySu>)xs.Deserialize(reader);
            reader.Close();

            return danhSachKySu;
        }
        public static void LuuDanhSachCongNhan(List<CongNhan> danhSachCongNhan)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<CongNhan>));
            TextWriter txtWriter = new StreamWriter(@"CongNhan.xml");

            xs.Serialize(txtWriter, danhSachCongNhan);

            txtWriter.Close();
        }

        public static List<CongNhan> DocDanhSachCongNhan()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<CongNhan>));
            StreamReader reader = new StreamReader(@"CongNhan.xml");

            List<CongNhan> danhSachCongNhan = (List<CongNhan>)xs.Deserialize(reader);
            reader.Close();

            return danhSachCongNhan;
        }
        public static void LuuDanhSachQuanLy(List<QuanLy> danhSachQuanLy)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<QuanLy>));
            TextWriter txtWriter = new StreamWriter(@"QuanLy.xml");

            xs.Serialize(txtWriter, danhSachQuanLy);

            txtWriter.Close();
        }

        public static List<QuanLy> DocDanhSachQuanLy()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<QuanLy>));
            StreamReader reader = new StreamReader(@"QuanLy.xml");

            List<QuanLy> danhSachQuanLy = (List<QuanLy>)xs.Deserialize(reader);
            reader.Close();

            return danhSachQuanLy;
        }
        public static void LuuDanhSachNhanVien(List<NhanVien> danhSachNhanVien)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<NhanVien>));
            TextWriter txtWriter = new StreamWriter(@"NhanVien.xml");

            xs.Serialize(txtWriter, danhSachNhanVien);

            txtWriter.Close();
        }

        public static List<NhanVien> DocDanhSachNhanVien()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<NhanVien>));
            StreamReader reader = new StreamReader(@"NhanVien.xml");

            List<NhanVien> danhSachNhanVien = (List<NhanVien>)xs.Deserialize(reader);
            reader.Close();

            return danhSachNhanVien;
        }
    }
}