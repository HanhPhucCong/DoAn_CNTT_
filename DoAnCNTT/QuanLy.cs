using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class QuanLy : NhanSu
    {
        public QuanLy():base() 
        {
        }
        public QuanLy(string Manhansu, string Hoten, DateTime Ngaysinh, string Gioitinh, string Diachi, string Trinhdo, string Chucvu) : base(Manhansu, Hoten, Ngaysinh, Gioitinh, Diachi, Trinhdo, Chucvu) { }
    }
}
