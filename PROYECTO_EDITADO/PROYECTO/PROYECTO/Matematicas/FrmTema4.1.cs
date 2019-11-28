using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Matematicas.Repaso
{
    public partial class FrmTema41 : Form
    {
        public FrmTema41()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema4 ra51 = new FrmTema4();
            ra51.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=WAA54Jyz-q8");
        }

        private void FrmTema41_Load(object sender, EventArgs e)
        {

        }
    }
}
