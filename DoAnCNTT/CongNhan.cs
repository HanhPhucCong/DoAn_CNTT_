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
        public CongNhan() { }
    }
}
