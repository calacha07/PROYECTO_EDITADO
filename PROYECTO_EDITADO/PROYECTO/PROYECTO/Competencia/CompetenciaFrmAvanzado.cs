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
    public partial class CompetenciaFrmAvanzado : Form
    {
        float i = 0;
     
        public CompetenciaFrmAvanzado()
        {
            InitializeComponent();
        }

        private void lblTres_Click(object sender, EventArgs e)
        {

        }

        private void cboCondicional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cboAvanzado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAvanzado.Text == "Metodo Burbuja")
            {

                i = i + 2.5f;


            }
            else
            {
                
            }
        }


        private void cboRespuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRespuesta.Text == "Matrices")
            {

                i = i + 2.5f;

            }
            else
            {

                
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            lblTotal.Text = Convert.ToString(i);
            cboAvanzado.Text = "";
            cboRespuesta.Text = "";
            i = 0;
         
        }

		private void FrmAvanzado_Load(object sender, EventArgs e)
		{

		}

        private void grbFacil_Enter(object sender, EventArgs e)
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
