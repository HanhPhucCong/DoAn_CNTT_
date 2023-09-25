using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class NhanSu
    {
        private string manhansu;
        private string hoten;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sodienthoai;
        private string trinhdo;
        private string chucvu;
        private string congviec;


        public string Manhansu { get => manhansu; set => manhansu = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Trinhdo { get => trinhdo; set => trinhdo = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Congviec { get => congviec; set => congviec = value; }

        public NhanSu ()
        {
            hoten = "";
            gioitinh = "";
            diachi = "";
            sodienthoai = "";
            trinhdo = "";
            chucvu = "";
        }
        public NhanSu(string Manhansu, string Hoten, DateTime Ngaysinh, string Gioitinh, string Diachi, string Sodienthoai, string Trinhdo, string Chucvu, string Congviec)
        {
            this.manhansu = Manhansu;
            this.hoten = Hoten;
            this.ngaysinh = Ngaysinh;
            this.gioitinh = Gioitinh;
            this.diachi = Diachi;
            this.sodienthoai = Sodienthoai;
            this.trinhdo = Trinhdo;
            this.chucvu = Chucvu;
            this.congviec = Congviec;
        }  
    }
}
