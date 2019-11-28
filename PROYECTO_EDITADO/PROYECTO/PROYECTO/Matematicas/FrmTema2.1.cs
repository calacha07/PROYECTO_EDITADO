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
    public partial class FrmTema21 : Form
    {
        public FrmTema21()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrincipal frmp = new FrmPrincipal();
            frmp.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema2 ra1 = new FrmTema2();
            ra1.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?time_continue=6&v=9rj5h_rDlNY");
        }

        private void FormRa2_Load(object sender, EventArgs e)
        {
           
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=KdBkGpPpAf0");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
