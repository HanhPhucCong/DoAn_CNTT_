using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCNTT
{
    public partial class FThemQL : Form
    {
        public FThemQL()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text;
            DateTime ngaysinh = dtNgaySinh.Value;
            string gioitinh = tbGioiTinh.Text;
            string diachi = tbDiaChi.Text;
            string trinhdo = tbTrinhDo.Text;
            string manhanvien = tbMaNhanVien.Text;
            string chucvu = tbChucVu.Text;

            Const.NewQuanLy = new QuanLy(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu);
            Const.NewNhanSu = new NhanSu(manhanvien, ten, ngaysinh, gioitinh, diachi, trinhdo, chucvu);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
