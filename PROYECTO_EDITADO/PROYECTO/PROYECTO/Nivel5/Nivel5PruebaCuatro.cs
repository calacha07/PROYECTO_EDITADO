using PROYECTO;
using PROYECTO.Nivel6;
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

namespace LoginProyecto
{
    public partial class FrmNivel5PruebaCuatro : Form
    {
        Dato d = new Dato();
        public FrmNivel5PruebaCuatro()
        {
            InitializeComponent();
      
        }

        

        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
			if ((this.cbRespuestaUno.Text == "") | (this.cbRespuestaDos.Text == "") | (this.cbRespuestaTres.Text == ""))
			{
				MessageBox.Show("Debe responder.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }else if ((cbRespuestaUno.Text == "Cadena") && (cbRespuestaDos.Text == "Entero") && (cbRespuestaTres.Text == "Lea"))
            {
                AuxiliarNivel.contarNivel5++;


                if ( AuxiliarNivel.contarNivel5 >= 3)
                {
                    MessageBox.Show("Felicidades aprobó.", "SALBA", MessageBoxButtons.OK);
                    d.ModficarNivel(5);
                    Dato.numeroNivel = 5;         
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.verificar();
                    FrmIntroduccionNivel6 cambio6 = new FrmIntroduccionNivel6();
                    
                    cambio6.Show();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Perdió el test del nivel", "SALBA", MessageBoxButtons.OK);
                    FrmNivel5Prueba retry = new FrmNivel5Prueba();
                    retry.Show();
                    this.Close();
                }

            }else
            {

                if (AuxiliarNivel.contarNivel5 >= 3)
                {
                    MessageBox.Show("Felicidades aprobó.", "SALBA", MessageBoxButtons.OK);
                    FrmIntroduccionNivel6 cambio6 = new FrmIntroduccionNivel6();
                    d.ModficarNivel(5);
                    Dato.numeroNivel = 5;
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.verificar();
                    cambio6.Show();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Perdió el test del nivel.", "SALBA", MessageBoxButtons.OK);
                    FrmNivel5Prueba retry = new FrmNivel5Prueba();
                    retry.Show();
                    this.Close();
                }
            }
            

           
        }
        private void FrmNivel5PruebaCuatro_Load(object sender, EventArgs e)
        {
            lblTituloNivelCuatro.Select();
        }

		private void cbRespuestaUno_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmNivel5PruebaTres nivel5 = new FrmNivel5PruebaTres();
            nivel5.Show();
        }

		private void cbRespuestaTres_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void lblTituloNivelCuatro_Click(object sender, EventArgs e)
        {

        }

        private void lblPregunta4_Click(object sender, EventArgs e)
        {

        }

        private void txtPreguntaCuatro_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
