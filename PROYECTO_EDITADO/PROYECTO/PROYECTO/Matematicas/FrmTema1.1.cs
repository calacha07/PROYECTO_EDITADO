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
    public partial class FrmTema11 : Form
    {
        public FrmTema11()
        {
            InitializeComponent();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrincipal frmp = new FrmPrincipal();
            frmp.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTema1 for2 = new FrmTema1();
            for2.Show();
        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=FIjylOufxyU");
        }

        private void Link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=jdqwzCL_PG0");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
