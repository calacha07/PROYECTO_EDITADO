using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.Menu;
using PROYECTO.Nivel5;

namespace LoginProyecto
{
    
	public partial class FrmNivel5 : Form
	{
        
		public FrmNivel5()
		{
			InitializeComponent();
		}

		private void clbConcepto_SelectedIndexChanged(object sender, EventArgs e)
		{
			}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void txtConceptos_TextChanged(object sender, EventArgs e)
		{

		}

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            FrmNivel5Prueba pregunta1 = new FrmNivel5Prueba();
            pregunta1.Show();
            this.Hide();
        }

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			Close();
			Nivel5Introduccion introduccion = new Nivel5Introduccion();
			introduccion.Show();
		}

		private void lblConcepto_Click(object sender, EventArgs e)
		{

		}

		private void FrmNivel5_Load(object sender, EventArgs e)
		{
            lblTitulo.Select();
		}
	}
}
