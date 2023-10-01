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
    public partial class FPhong : Form
    {
        public FPhong()
        {
            InitializeComponent();
        }

        private void FPhong_Load(object sender, EventArgs e)
        {
            listBoxPhong.DataSource = Const.Listphong;
        }
    }
}
