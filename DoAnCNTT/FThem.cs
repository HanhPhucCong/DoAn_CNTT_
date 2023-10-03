using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNTT
{
    public partial class FThem : Form
    {
        public FThem()
        {
            InitializeComponent();
        }
        private void btThemQl_Click(object sender, EventArgs e)
        {
            Const.NewQuanLy = null;
            Const.NewNhanSu = null;
            FThemQL form = new FThemQL();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListQuanLy.Instance.Listquanly.Add(Const.NewQuanLy);
            ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            Const.NewNhanVien = null;
            Const.NewNhanSu = null;
            FThemNV form = new FThemNV();
            form.FormClosed += Form_FormClosed3;
            form.ShowDialog();
        }

        private void Form_FormClosed3(object sender, FormClosedEventArgs e)
        {
            ListNhanVien.Instance.Listnhanvien.Add(Const.NewNhanVien);
            ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
        }

        private void btThemKS_Click(object sender, EventArgs e)
        {
            Const.NewKySu = null;
            Const.NewNhanSu = null;
            FThemKS form = new FThemKS();
            form.FormClosed += Form_FormClosed2;
            form.ShowDialog();
        }

        private void Form_FormClosed2(object sender, FormClosedEventArgs e)
        {
            ListKySu.Instance.Listkysu.Add(Const.NewKySu);
            ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
        }

        private void btThemCN_Click(object sender, EventArgs e)
        {
            Const.NewCongNhan = null;
            Const.NewNhanSu = null;
            FThemCN form = new FThemCN();
            form.FormClosed += Form_FormClosed1;
            form.ShowDialog();
        }

        private void Form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            ListCongNhan.Instance.Listcongnhan.Add(Const.NewCongNhan);
            ListNhanSu.Instance.Listnhansu.Add(Const.NewNhanSu);
        }
    }
}
