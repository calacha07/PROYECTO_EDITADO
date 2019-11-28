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
    public partial class FrmTema1 : Form
    {
      

        public FrmTema1()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender,LinkLabelLinkClickedEventArgs e)

        {

           

        }

        private void Label2_Click(object sender, EventArgs e)
        {
      
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTema11 for3 = new FrmTema11();
            for3.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrincipal for1 = new FrmPrincipal();
            for1.Show();
        }

        private void Link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
