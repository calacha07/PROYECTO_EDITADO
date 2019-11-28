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
    public partial class CompetenciaFrmFacil : Form
    {
        float i=0;
     
        public CompetenciaFrmFacil()
        {
            InitializeComponent();
        }

        private void FrmCompetencia_Load(object sender, EventArgs e)
        {

        }

        private void cboFacil_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (cboFacil.Text == "Secuenciales")
            {

                i=i+1.25f;



            }
            else
            {
             
               

            }
        }

        private void cboRespuesta_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboRespuesta.Text == "Tipos de Variables")
            {
                i=i + 1.25f;
            }

            else
            {
            
            }
        }

        private void cboCondicional_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCondicional.Text == "Condicionales")
            {
                i= i + 1.25f;
              
            }

            else
            {
              
             
            }

        }

        private void cboC_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboC.Text == "Condicionales")
            {
                i= i+ 1.25f;

            }

            else
            {
            


            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {   
            lblTotal.Text = Convert.ToString(i);
            cboFacil.Text = "";
            cboRespuesta.Text = "";
            cboCondicional.Text = "";
            cboC.Text = "";
     
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

