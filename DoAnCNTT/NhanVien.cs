using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class NhanVien : NhanSu
    {
        private string congviec;
        private string phong;
        public string Phong { get => phong; set => phong = value; }
        public string Congviec { get => congviec; set => congviec = value; }
        public NhanVien() : base()
        {
            congviec = "";
            phong = "";
        }
        public NhanVien(string Manhansu, string Hoten, DateTime Ngaysinh, string Gioitinh, string Diachi, string Trinhdo, string Chucvu, string Congviec, string Phong) : base()
        {
            this.congviec = Congviec;
            this.phong = Phong;
        }
    }
}
