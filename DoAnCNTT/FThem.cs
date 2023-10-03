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
            FThemQL form = new FThemQL();
            form.ShowDialog();
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            FThemNV form = new FThemNV();
            form.ShowDialog();
        }

        private void btThemKS_Click(object sender, EventArgs e)
        {
            FThemKS form = new FThemKS();
            form.ShowDialog();
        }

        private void btThemCN_Click(object sender, EventArgs e)
        {
            FThemCN form = new FThemCN();
            form.ShowDialog();
        }
    }
}
