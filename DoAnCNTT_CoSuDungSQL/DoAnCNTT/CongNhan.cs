using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class CongNhan:NhanSu
    {
        private string bac;
        private string to;
        private string nhom;
        public string Bac { get => bac; set => bac = value; }
        public string To { get => to; set => to = value; }
        public string Nhom { get => nhom; set => nhom = value; }
        public CongNhan() : base()
        {
            bac = "";
            to = "";
            nhom = "";
        }
        public CongNhan(string Manhansu, string Hoten, DateTime Ngaysinh, string Gioitinh, string Diachi, string Trinhdo, string Loainhansu, string Bac, string To, string Nhom) : base(Manhansu, Hoten, Ngaysinh, Gioitinh, Diachi, Trinhdo, Loainhansu)
        {
            this.bac = Bac;
            this.to = To;
            this.nhom = Nhom;
        }
    }
}
