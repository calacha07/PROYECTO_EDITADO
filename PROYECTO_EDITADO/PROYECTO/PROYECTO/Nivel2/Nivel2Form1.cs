using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO;
using PROYECTO.Menu;

namespace EJERCICIOS
{
    public partial class FrmNivel2Principal : Form
    {
       
        public FrmNivel2Principal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmNivel2condicionalSimple ejercicio1 = new frmNivel2condicionalSimple();

            ejercicio1.Show();
            this.Close();
        }

        private void FrmNivel2Principal_Load(object sender, EventArgs e)
        {

        }

		private void btnRegresar_Click(object sender, EventArgs e)
		{
            IntroduccionLvl2 regresar = new IntroduccionLvl2();
            regresar.Show();
            Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
