using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class ListCongNhan
    {
        private static ListCongNhan instance;
        private List<CongNhan> listcongnhan;
        public static ListCongNhan Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListCongNhan();
                return instance;
            }
            set => instance = value;
        }
        public List<CongNhan> Listcongnhan { get => listcongnhan; set => listcongnhan = value; }
        private ListCongNhan()
        {
            listcongnhan = new List<CongNhan>();
            listcongnhan.Add(new CongNhan("CN1", "Hanh Phuc Cong 1", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Cong nhan", "Bac 2", "To xay dung", "Nhom 2"));
        }
    }
}
