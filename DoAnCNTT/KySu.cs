using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public  class KySu : NhanSu
    {
        private string nganhdaotao;
        private string bophan;
        public string Nganhdaotao { get => nganhdaotao; set => nganhdaotao = value; }
        public string Bophan { get => bophan; set => bophan = value; }
        public KySu() 
        {
            nganhdaotao = "";
            bophan = "";
        }
        public KySu(string Manhansu, string Hoten, DateTime Ngaysinh, string Gioitinh, string Diachi, string Trinhdo, string Chucvu, string Nganhdaotao, string Bophan) : base()
        {
            this.Nganhdaotao = nganhdaotao;
            this.Bophan = bophan;
        }
    }
}
