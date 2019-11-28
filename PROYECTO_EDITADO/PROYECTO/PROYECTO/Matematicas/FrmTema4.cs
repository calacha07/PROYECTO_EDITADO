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
    public partial class FrmTema4 : Form
    {
        public FrmTema4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema41 ra52 = new FrmTema41();
            ra52.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ptLogo_Click(object sender, EventArgs e)
        {


        }
    }
}
