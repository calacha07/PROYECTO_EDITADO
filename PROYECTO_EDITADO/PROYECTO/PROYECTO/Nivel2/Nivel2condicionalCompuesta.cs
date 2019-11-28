using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS
{
    public partial class frmNivel2condicionalCompuesta : Form
    {
        
        
        public frmNivel2condicionalCompuesta()
        {
            InitializeComponent();
        }
        private void CbxReal_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
        }

        private void CbxPromedio_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }

        private void CbxPromedioDos_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
        }

        private void CbxEntonces_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnEvaluar_Click(object sender, EventArgs e)
        {
          
        }

        private void Condicionales_Enter(object sender, EventArgs e)
        {

        }

        private void CondiciomalCompuesta_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {        
        }


        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if ((cbxEntonces.Text.Length == 0) && (cbxFin.Text.Length == 0) && (cbxPromedio.Text.Length == 0) && (cbxPromedioDos.Text.Length == 0) && (cbxReal.Text.Length == 0))
            {
                MessageBox.Show("Debe completar la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((cbxReal.Text == "Real") && (cbxPromedio.Text == "promedio") && (cbxPromedioDos.Text == "promedio") && (cbxEntonces.Text == "Entonces") && (cbxFin.Text == "Fin Si"))
                {
                    MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Nivel2condicionalCaso ejercicio3 = new Nivel2condicionalCaso();
                    ejercicio3.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Repita la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            

        }

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			Close();
			frmNivel2condicionalSimple nivel2 = new frmNivel2condicionalSimple();
			nivel2.Show();
		}
	}
}
