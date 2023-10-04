using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class ListKySu
    {
        private static ListKySu instance;
        private List<KySu> listkysu;
        public static ListKySu Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListKySu();
                return instance;
            }
            set => instance = value;
        }
        public List<KySu> Listkysu { get => listkysu; set => listkysu = value; }
        private ListKySu()
        {
            listkysu = new List<KySu>();
            listkysu.Add(new KySu("KS1", "Hanh Phuc Cong 3", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Kỹ sư", "Ngành xây dựng", "Thiết kế"));
            listkysu.Add(new KySu("KS2", "Hanh Phuc Cong 7", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Kỹ sư", "Ngành xây dựng", "Thiết kế"));
        }
    }
}
