using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class User
    {
        private string name;
        private string pass;
        private string loai;

        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Loai { get => loai; set => loai = value; }

        public User ()
        {
            name = "";
            pass = "";
            loai = "";
        }
        public User(string Name, string Pass, string Loai)
        {
            this.name = Name;
            this.pass = Pass;
            this.loai = Loai;
        }
    }
}
