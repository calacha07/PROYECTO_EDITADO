using PROYECTO.Menu;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTema1 for2 = new FrmTema1();
            for2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema5 nuevo5 = new FrmTema5();
            nuevo5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema6 nuevo6 = new FrmTema6();
            nuevo6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema7 nuevo7 = new FrmTema7();
            nuevo7.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema2 ra12= new FrmTema2();
            ra12.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema3 ra3 = new FrmTema3();
            ra3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTema4 ra51 = new FrmTema4();
            ra51.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
