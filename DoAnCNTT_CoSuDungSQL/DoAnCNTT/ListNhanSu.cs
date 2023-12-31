﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNTT
{
    public class ListNhanSu
    {
        private static ListNhanSu instance;
        private List<NhanSu> listnhansu;
        public static ListNhanSu Instance 
        {
            get
            {
                if (instance == null)
                    instance = new ListNhanSu();
                return instance;
            }
            set => instance = value; 
        }
        public List<NhanSu> Listnhansu { get =>  listnhansu; set => listnhansu = value; }
        private ListNhanSu()
        {
            listnhansu = new List<NhanSu>();
            //listnhansu.Add(new NhanSu("QL1", "Hanh Phuc Cong", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Quản lý"));
            //listnhansu.Add(new NhanSu("CN1", "Hanh Phuc Cong 1", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Công nhân"));
            //listnhansu.Add(new NhanSu("NV1", "Hanh Phuc Cong 2", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Nhân viên"));
            //listnhansu.Add(new NhanSu("KS1", "Hanh Phuc Cong 3", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Kỹ sư"));
            //listnhansu.Add(new NhanSu("KS2", "Hanh Phuc Cong 7", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Kỹ sư"));
            //listnhansu.Add(new NhanSu("CN2", "Hanh Phuc Cong 11", new DateTime(2003, 12, 28), "Nam", "Ho Chi Minh", "12/12", "Công nhân"));

        }
    }
}
