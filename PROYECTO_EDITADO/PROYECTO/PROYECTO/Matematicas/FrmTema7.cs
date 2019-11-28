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
    public partial class FrmTema7 : Form
    {
        public FrmTema7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema71 nuevo71 = new FrmTema71();
            nuevo71.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }
    }
}
