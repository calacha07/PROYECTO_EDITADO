using PROYECTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProyecto
{
	public partial class FrmNivel5Prueba : Form
	{

        
        
		public FrmNivel5Prueba()
		{
			InitializeComponent();
		}

        private void lblPregunta1_Click(object sender, EventArgs e)
        {

        }

        private void Nivel5Prueba_Load(object sender, EventArgs e)
        {
            lblTituloNivelUno.Select();
        }

        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
			
			if ((this.rbRespuestaUno.Checked == false) && (this.rbRespuestaDos.Checked == false) && (this.rbRespuestaTres.Checked == false) && (this.rbRespuestaCuatro.Checked == false))
			{
				MessageBox.Show("Debe seleccionar una respuesta.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			 else if (rbRespuestaTres.Checked == true)
            {
                FrmNivel5PruebaDos pregunta2 = new FrmNivel5PruebaDos();
                AuxiliarNivel.contarNivel5++;


                pregunta2.Show();
				this.Close();
			}
			else
			{
                FrmNivel5PruebaDos pregunta2 = new FrmNivel5PruebaDos();
                pregunta2.Show();
				this.Close();
			}
			


		}
        
        private void ckbRespuestaTres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbRespuestaTres_CheckedChanged(object sender, EventArgs e)
        {
           
        }

		private void gpPreguntas_Enter(object sender, EventArgs e)
		{

		}

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmNivel5 nivel5 = new FrmNivel5();
            nivel5.Show();
        }
    }
}
