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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        bool KiemTraLogin(string userName, string passWard)
        {
            for ( int i = 0; i< Listuser.Instance.listAccout.Count; i++)
                if (userName == Listuser.Instance.listAccout[i].Name && passWard == Listuser.Instance.listAccout[i].Pass)
                {
                    Const.loai = Listuser.Instance.listAccout[i].Loai;
                    return true;
                }
            return false;
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string Name = tTaiKhoan.Text;
            string Pass = tMatKhau.Text;
            if (KiemTraLogin(Name, Pass))
            {
                FMain form = new FMain();
                form.Show();
                this.Hide();
                form.Logout += Form_Logout;
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản bạn nhập không đúng vui lòng kiểm tra lại. ", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                tTaiKhoan.Focus();
                return;
            }
        }

        private void Form_Logout(object sender, EventArgs e)
        {
            (sender as FMain).isExit = false;
            (sender as FMain).Hide();
            this.Show();
        }

        private void FDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tMatKhau.UseSystemPasswordChar = false;
            if (!checkBox1.Checked)
                tMatKhau.UseSystemPasswordChar = true;
        }
    }
}
