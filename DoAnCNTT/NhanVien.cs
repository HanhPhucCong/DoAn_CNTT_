using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class NhanVien : NhanSu
    {
        private string thuocbac;
        private string thuocto;
        private string thuocnhom;
        public string Thuocbac { get => thuocbac; set => thuocbac = value; }
        public string Thuocto { get => thuocto; set => thuocto = value; }
        public string Thuocnhom { get => thuocnhom; set => thuocnhom = value; }
        public NhanVien() { }
    }
}
