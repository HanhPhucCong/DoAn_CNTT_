using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class Const
    {
        public static NhanSu NewNhanSu = null;
        public static NhanVien NewNhanVien = null;
        public static QuanLy NewQuanLy = null;
        public static CongNhan NewCongNhan = null;
        public static KySu NewKySu = null;
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
    }
}