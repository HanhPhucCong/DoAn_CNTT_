using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnCNTT
{
    public partial class FPhong : Form
    { 
        int index = -1;
        public FPhong()
        {
            InitializeComponent();
        }
        void loadDanhSach()
        {
           listBoxPhong.DataSource = null;
           listBoxPhong.DataSource = Const.Listphong;
        }

        private void FPhong_Load(object sender, EventArgs e)
        {
            loadDanhSach();
        }

        private void listBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxPhong.SelectedIndex;
            if (index < 0)
                return;
            tenphong.Text = Const.Listphong[index];
           
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (tenphong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng bạn muốn thêm.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tenphong.Focus();
                return;
            }
            string Phong = tenphong.Text;
            if (Kiemtra())
            {
                MessageBox.Show("Tên phòng đã tồn tại.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            Const.Listphong.Add(Phong);
            loadDanhSach();
            MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        bool Kiemtra()
        {
            string Phong = tenphong.Text;
            for (int i = 0; i < Const.Listphong.Count; i++)
                if (Phong == Const.Listphong[i])
                    return true;
            return false;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (tenphong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tên phòng bạn muốn sửa.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tenphong.Focus();
                return;
            }
            string Phong = tenphong.Text;
            if (Kiemtra())
            {
                MessageBox.Show("Tên phòng đã tồn tại.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            Const.Listphong[index] = Phong;
            loadDanhSach();
            MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (tenphong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tên phòng bạn muốn xóa.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tenphong.Focus();
                return;
            }
            Const.Listphong.RemoveAt(index);
            loadDanhSach();
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát ?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit(); ;
        }
    }
}
