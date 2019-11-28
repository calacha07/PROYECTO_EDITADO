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
    public partial class FrmTema5 : Form
    {
        public FrmTema5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema51 nuevo51 = new FrmTema51();
            nuevo51.Show();
        }

        private void FrmTema5_Load(object sender, EventArgs e)
        {

        }
    }
}
