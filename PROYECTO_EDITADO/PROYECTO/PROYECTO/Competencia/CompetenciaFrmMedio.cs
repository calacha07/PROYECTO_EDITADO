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
    public partial class CompetenciaFrmMedio : Form
    {
        float i = 0;
       
     
        public CompetenciaFrmMedio()
        {
            InitializeComponent();
        }

        private void FrmMedio_Load(object sender, EventArgs e)
        {
        }

        private void cboMedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedio.Text == "Ciclo Repita")
            {
                i = i + 1.25f;
            }

            else
            {
             
            }

        }

    

        private void cboRespuesta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboRespuesta.Text == "Ciclo Para")
            {
                i = i + 1.25f;
            }
            else
            {
              
            }
        }

        private void cboMientras_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboMientras.Text == "Ciclo Mientras")
            {
                i = i + 1.25f;
            }
            else
            {
              
            }
        }

        private void cboRepita_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        if (cboRepita.Text == "Ciclo Repita")
        {
            i = i + 1.25f;
        }
        else
        {
               
            }
    }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            lblTotal.Text = Convert.ToString(i);
            cboMedio.Text = "";
            cboRespuesta.Text = "";
            cboMientras.Text = "";
            cboRepita.Text = "";
            
            i = 0;


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
   
