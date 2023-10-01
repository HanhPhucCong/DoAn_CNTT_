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
    public partial class FMain : Form
    {
        int index = -1;
        public bool isExit = true;
        public event EventHandler Logout;
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            PhanLoai();
            foreach(var item in ListNhanSu.Instance.Listnhansu)
            {
                dataGridView1.Rows.Add(item.Manhansu, item.Hoten, item.Ngaysinh.ToShortDateString(), item.Gioitinh, item.Diachi, item.Trinhdo, item.Chucvu);
            }
        }
        void PhanLoai()
        {
            if (Const.loai != "Quan ly")
            {
                Them.Enabled = false;
                Xoa.Enabled = false;
                Sua.Enabled = false;
                quảnLýToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                toolStripLabel1.Enabled = false;
                lbxoa.Enabled = false;
                toolStripLabel2.Enabled = false;
            }
        }
        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                if (MessageBox.Show("Bạn Muốn Thoát ?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Application.Exit(); ;
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTaiKhoan form = new FTaiKhoan();
            form.Show();
            this.Hide();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPhong form = new FPhong();
            form.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListNhanSu.Instance.Listnhansu.Count)
                return;
            Const.NewNhanSu = new NhanSu();
            Const.NewNhanSu.Manhansu = ListNhanSu.Instance.Listnhansu[index].Manhansu;
            Const.NewNhanSu.Hoten = ListNhanSu.Instance.Listnhansu[index].Hoten;
            Const.NewNhanSu.Ngaysinh = ListNhanSu.Instance.Listnhansu[index].Ngaysinh;
            Const.NewNhanSu.Gioitinh = ListNhanSu.Instance.Listnhansu[index].Gioitinh;
            Const.NewNhanSu.Diachi = ListNhanSu.Instance.Listnhansu[index].Diachi;
            Const.NewNhanSu.Trinhdo = ListNhanSu.Instance.Listnhansu[index].Trinhdo;
            Const.NewNhanSu.Chucvu = ListNhanSu.Instance.Listnhansu[index].Chucvu;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FThongTinQuanLy form = new FThongTinQuanLy();
            form.ShowDialog();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FThongTinQuanLy form = new FThongTinQuanLy();
            form.ShowDialog();
        }
        private void Them_Click(object sender, EventArgs e)
        {
            FThem form = new FThem();
            form.ShowDialog();
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FThem form = new FThem();
            form.ShowDialog();
        }
    }
}
