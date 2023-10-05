using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class Listuser
    {
        private static Listuser instance;
        private List<User> listAccount;
        public List<User> listAccout { get => listAccount; set => listAccount = value;  }
        public static Listuser Instance
        {
            get
            {
                if(instance == null)
                    instance = new Listuser();
                return instance;
            }
            set => instance = value;
        }
        private Listuser ()
        {
            listAccount = new List<User> ();
            //listAccout.Add(new User("hanhphucong", "28122003", "Quan ly"));
            //listAccout.Add(new User("hanhphucong1", "28122003", "Ky su"));
            //listAccout.Add(new User("hanhphucong2", "28122003", "Nhan vien"));
            //listAccout.Add(new User("hanhphucong3", "28122003", "Cong nhan"));
        }
    }
}
