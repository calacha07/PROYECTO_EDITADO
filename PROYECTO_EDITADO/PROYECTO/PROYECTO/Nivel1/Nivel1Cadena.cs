using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCadena : Form
    {
        public frmCadena()
        {
            InitializeComponent();
            lblCadena.Select();
        }

        private void frmCadena_Load(object sender, EventArgs e)
        {

        }

        

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            frmReal real = new frmReal();
            real.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click_2(object sender, EventArgs e)
        {
            Close();
            FrmBooleano boolean = new FrmBooleano();
            boolean.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
