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
        public List<QuanLy> Listquanly { get => listquanly; set => listquanly = value; }
        private ListQuanLy()
        {
            listquanly = new List<QuanLy>();
            //listquanly.Add(new QuanLy("QL1", "Hanh Phuc Cong", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Quản lý"));
        }
    }
}
