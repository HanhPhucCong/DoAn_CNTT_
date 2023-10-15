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
            if (Const.NewUser == Listuser.Instance.listAccout[index])
                xoa.Enabled = loaitaikhoan.Enabled = false;
            else
                xoa.Enabled = loaitaikhoan.Enabled = true;
        }
        void loadDanhSach()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Listuser.Instance.listAccout;
            Const.LuuDanhSachNguoiDung(Listuser.Instance.listAccout);
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
            for (int i = 0; i < Listuser.Instance.listAccout.Count; i++)
            {
                if (Listuser.Instance.listAccout[i].Name == tentaikhoan.Text && Listuser.Instance.listAccout[i].Pass == matkhau.Text)
                    return;
            }
            string name = tentaikhoan.Text;
            string pass = matkhau.Text;
            string loai = loaitaikhoan.Text;
            Listuser.Instance.listAccout.Add(new User (name, pass, loai));
            tentaikhoan.Text = "";
            matkhau.Text = "";
            loadDanhSach();
        }
        private void sua_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một User trước khi sử dụng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < Listuser.Instance.listAccout.Count; i++)
            {
                if (Listuser.Instance.listAccout[i].Name == tentaikhoan.Text && Listuser.Instance.listAccout[i].Pass == matkhau.Text)
                    return;
            }
            string name = tentaikhoan.Text;
            string pass = matkhau.Text;
            string loai = loaitaikhoan.Text;
            Listuser.Instance.listAccout[index].Name = name;
            Listuser.Instance.listAccout[index].Pass = pass;
            Listuser.Instance.listAccout[index].Loai = loai;
            tentaikhoan.Text = "";
            matkhau.Text = "";
            loadDanhSach();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn một User trước khi sử dụng.", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            Listuser.Instance.listAccout.RemoveAt(index);
            tentaikhoan.Text = "";
            matkhau.Text = "";
            loadDanhSach();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
