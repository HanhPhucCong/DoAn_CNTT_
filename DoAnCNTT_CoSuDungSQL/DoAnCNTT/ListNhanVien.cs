using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class ListNhanVien
    {
        private static ListNhanVien instance;
        private List<NhanVien> listnhanvien;
        public static ListNhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListNhanVien();
                return instance;
            }
            set => instance = value;
        }
        public List<NhanVien> Listnhanvien { get => listnhanvien; set => listnhanvien = value; }
        private ListNhanVien()
        {
            listnhanvien = new List<NhanVien>();
            //listnhanvien.Add(new NhanVien("NV1", "Hanh Phuc Cong 2", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Nhân viên", "Kế toán", "Phòng kế toán"));
        }
    }
}
