using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Competencia
{
	public partial class CompetenciaFrmDificil : Form
	{
		public CompetenciaFrmDificil()
		{
			InitializeComponent();
		}
		float i = 0;
		
		private void cboReferencia_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboReferencia.Text == "Pasa la posición de memoria donde esta guardada la variable")
			{
				i = i + 2.5f;
			}
			else
			{
				
			}
		}

		private void cboValor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboValor.Text== "Recibe sólo una copia del valor que tiene la variable")
			{
				i = i + 2.5f;
			}
			else
			{
				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lblCalificacionT.Text = Convert.ToString(i);
			cboReferencia.Text = "";
			cboValor.Text = "";
            i = 0;
			
			
			//MessageBox.Show("Su calificacion es: "+ i +" Con un numero de respuestas incorrectas " + j + "", "Señor usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        private void FrmDificil_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompetencias n = new frmCompetencias();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
