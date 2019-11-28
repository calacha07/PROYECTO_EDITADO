using PROYECTO.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO.Nivel1;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmVariables : Form
    {
        public FrmVariables()
        {
            InitializeComponent();
        }

		private void FrmVariables_Load(object sender, EventArgs e)
		{
			
		}

		public void conceptos()
		{
			
		}

		private void cbVariable_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmEntero entero = new frmEntero();
            entero.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            Frminstruccion entero = new Frminstruccion();
            entero.Show();
        }

        private void txtConceptos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
