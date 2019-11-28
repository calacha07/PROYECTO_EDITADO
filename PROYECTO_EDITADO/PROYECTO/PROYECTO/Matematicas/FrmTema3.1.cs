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
    public partial class FrmTema31 : Form
    {
        public FrmTema31()
        {
            InitializeComponent();
        }

        private void FormRa4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema3 ra3 = new FrmTema3();
            ra3.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema3 ra3 = new FrmTema3();
            ra3.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema5 nuevo5 = new FrmTema5();
            nuevo5.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=JhXkQulf9MM"); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=WYwmA8coUsQ");
        }
    }
}
