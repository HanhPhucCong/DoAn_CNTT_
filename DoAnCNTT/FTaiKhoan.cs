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
    public partial class FTaiKhoan : Form
    {
        int index = -1;
        List<string> listAccout = new List<string>() { "Quan ly", "Nhan Vien", " Ky su", "Cong nhan" };
        public FTaiKhoan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index = e.RowIndex;
            if (index < 0)
                return;
            tentaikhoan.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            matkhau.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            switch (Listuser.Instance.listAccout[index].Loai)
            {
                case "Quan ly":
                    loaitaikhoan.Text = "Quan ly";
                    break;
                case "Ky su":
                    loaitaikhoan.Text = "Ky su";
                    break;
                case "Nhan vien":
                    loaitaikhoan.Text = "Nhan vien";
                    break;
                case "Cong nhan":
                    loaitaikhoan.Text = "Cong nhan";
                    break;
            }
        }
        void loadDanhSach()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Listuser.Instance.listAccout;
            dataGridView1.Refresh();
        }
        private void FTaiKhoan_Load(object sender, EventArgs e)
        {
            loaitaikhoan.DataSource = listAccout;
            loadDanhSach();
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (tentaikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản bạn muốn thêm.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tentaikhoan.Focus();
                return;
            }
            if (matkhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu của tài khoản bạn muốn thêm.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                matkhau.Focus();
                return;
            }
            if (loaitaikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập loại tài khoản bạn muốn thêm.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                loaitaikhoan.Focus();
                return;
            }

            string name = tentaikhoan.Text;
            string pass = matkhau.Text;
            string loai = layLoaitaikhoan();
            Listuser.Instance.listAccout.Add(new User (name, pass, loai));
            loadDanhSach();
        }
        string layLoaitaikhoan()
        {
            string loaiTK = "";
            switch (loaitaikhoan.Text)
            {
                case "Quan ly":
                    loaiTK = "Quan ly";
                    break;
                case "Ky su":
                    loaiTK = "Ky su";
                    break;
                case "Nhan vien":
                    loaiTK = "Nhan vien";
                    break;
                case "Cong nhan":
                    loaiTK = "Cong nhan";
                    break;
            }
            return loaiTK;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một User trước khi sử dụng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = tentaikhoan.Text;
            string pass = matkhau.Text;
            string loai = layLoaitaikhoan();
            Listuser.Instance.listAccout[index].Name = name;
            Listuser.Instance.listAccout[index].Pass = pass;
            Listuser.Instance.listAccout[index].Loai = loai;
            loadDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một User trước khi sử dụng.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if(loaitaikhoan.Text == "Quan ly")
            {
                MessageBox.Show("Bạn không thêr xóa tài khoản của  Quản lý khác.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Listuser.Instance.listAccout.RemoveAt(index);
            loadDanhSach();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát ?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit(); ;
        }
    }
}
