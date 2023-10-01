using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class ListQuanLy
    {
        private static ListQuanLy instance;
        private List<QuanLy> listquanly;
        public static ListQuanLy Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListQuanLy();
                return instance;
            }
            set => instance = value;
        }
        public List<QuanLy> Listnhansu { get => listquanly; set => listquanly = value; }
    }
}
