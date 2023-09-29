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
        List<string> listAccout = new List<string>() { "Quan ly", "Nhan Vien", " Ky su" };
        public FTaiKhoan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            tentaikhoan.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            matkhau.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }
        void loadDanhSach()
        {
            dataGridView1.DataSource = Listuser.Instance.listAccout;
        }
        private void FTaiKhoan_Load(object sender, EventArgs e)
        {
            loaitaikhoan.DataSource = listAccout;
            loadDanhSach();
        }
    }
}
