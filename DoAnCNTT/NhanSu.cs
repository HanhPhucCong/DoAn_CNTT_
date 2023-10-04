using System;
using System.Collections.Generic;
using System.Data;
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
        private string trinhdo;
        private string chucvu;



        public string Manhansu { get => manhansu; set => manhansu = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Trinhdo { get => trinhdo; set => trinhdo = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }


        public NhanSu ()
        {
            hoten = "";
            gioitinh = "";
            diachi = "";
            trinhdo = "";
            chucvu = "";
        }
        public NhanSu(string Manhansu, string Hoten, DateTime Ngaysinh, string Gioitinh, string Diachi, string Trinhdo, string Chucvu)
        {
            this.manhansu = Manhansu;
            this.hoten = Hoten;
            this.ngaysinh = Ngaysinh;
            this.gioitinh = Gioitinh;
            this.diachi = Diachi;
            this.trinhdo = Trinhdo;
            this.chucvu = Chucvu;
        } 
    }
}
