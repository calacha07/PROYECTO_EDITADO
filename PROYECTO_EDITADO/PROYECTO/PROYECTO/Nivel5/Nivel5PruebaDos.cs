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
    public partial class FrmNivel5PruebaDos : Form
    {
        


        FrmNivel5Prueba suma2 = new FrmNivel5Prueba();

        public FrmNivel5PruebaDos()
        {
            InitializeComponent();
        }

      
      

       

        private void ckbRespuestaTres_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        
            
        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
			
			if ((this.rbRespuestaUno.Checked == false) && (this.rbRespuestaDos.Checked == false) && (this.rbRespuestaTres.Checked == false) && (this.rbRespuestaCuatro.Checked == false))
			{
				MessageBox.Show("Debe seleccionar una respuesta.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (rbRespuestaDos.Checked == true)
			{
                FrmNivel5PruebaTres pregunta3 = new FrmNivel5PruebaTres();
                AuxiliarNivel.contarNivel5++; 
                pregunta3.Show();
				this.Close();
			}else
			{
                FrmNivel5PruebaTres pregunta3 = new FrmNivel5PruebaTres();
                pregunta3.Show();
				this.Close();
			}
            
        }

        private void FrmNivel5PruebaDos_Load(object sender, EventArgs e)
        {
            lblTituloNivelDos.Select();
        }
        

        private void rbRespuestaDos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblRespuestass_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmNivel5Prueba nivel5 = new FrmNivel5Prueba();
            nivel5.Show();
        }
    }
}
