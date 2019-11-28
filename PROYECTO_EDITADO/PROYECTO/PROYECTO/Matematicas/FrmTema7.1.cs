using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematicas.Repaso
{
    public partial class FrmTema71 : Form
    {
        public FrmTema71()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema7 nuevo7 = new FrmTema7();
            nuevo7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema72 nuevo72 = new FrmTema72();
            nuevo72.Show();
        }
    }
}
