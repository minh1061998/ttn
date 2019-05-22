using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom
{
    public partial class FormDANHMUC : Form
    {
        public FormDANHMUC()
        {
            InitializeComponent();
        }

        private void btnKKSL_Click(object sender, EventArgs e)
        {
            FormKKSL KKSL = new FormKKSL();
            KKSL.ShowDialog();
        }

        private void btnCT_KKSL_Click(object sender, EventArgs e)
        {
            FormCT_KKSL CTKKSL = new FormCT_KKSL();
            CTKKSL.ShowDialog();
        }

        private void btnKKCL_Click(object sender, EventArgs e)
        {
            FormKKCL KKCL = new FormKKCL();
            KKCL.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCT_KKCL CTKKCL = new FormCT_KKCL();
            CTKKCL.ShowDialog();
        }
    }
}
