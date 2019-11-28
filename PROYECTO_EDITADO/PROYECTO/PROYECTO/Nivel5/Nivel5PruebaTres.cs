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
    public partial class FrmNivel5PruebaTres : Form
    {

        public FrmNivel5PruebaTres()
        {
            InitializeComponent();
        }

       

        

        private void lblPregunta3_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
			
			if ((this.rbRespuestaUno.Checked == false) && (this.rbRespuestaDos.Checked == false) && (this.rbRespuestaTres.Checked == false) && (this.rbRespuestaCuatro.Checked == false))
			{
				MessageBox.Show("Debe responder.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}else if (rbRespuestaUno.Checked == true)
            {
                FrmNivel5PruebaCuatro pregunta4 = new FrmNivel5PruebaCuatro();
                AuxiliarNivel.contarNivel5++;
                pregunta4.Show();
				this.Close();
			}
			else
			{
                FrmNivel5PruebaCuatro pregunta4 = new FrmNivel5PruebaCuatro();
                pregunta4.Show();
				this.Close();
			}


           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void gpRespuestas_Enter(object sender, EventArgs e)
        {

        }

        private void txtPreguntaTres_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTituloNivelTres_Click(object sender, EventArgs e)
        {

        }

        
        private void FrmNivel5PruebaTres_Load(object sender, EventArgs e)
        {
            lblTituloNivelTres.Select();
        }

        private void rbRespuestaUno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmNivel5PruebaDos nivel5 = new FrmNivel5PruebaDos();
            nivel5.Show();
        }
    }
}
