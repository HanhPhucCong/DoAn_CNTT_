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
        private bool loai;

        public string Name { get => name; set => name = value; }
        public string Pass { get => pass; set => pass = value; }
        public bool Loai { get => loai; set => loai = value; }

        public User(string Name, string Pass, bool Loai)
        {
            this.name = Name;
            this.pass = Pass;
            this.loai = Loai;
        }
    }
}
