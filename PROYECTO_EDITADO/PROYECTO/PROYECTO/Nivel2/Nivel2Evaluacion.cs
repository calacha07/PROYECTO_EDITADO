using FrmNivelTres;
using PROYECTO.Nivel3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO;
using PROYECTO.Menu;

namespace EJERCICIOS
{
    public partial class Nivel2Evaluacion : Form
    {
        float total;

        Dato d = new Dato();
        public Nivel2Evaluacion()
        {
            InitializeComponent();
        }

        private void CondicionalCaso2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          if((rbtnUno.Checked==false)&&(rbtnDos.Checked==false)&&(rbtnTres.Checked == false)&&(rbtnCuatro.Checked == false)&&(rbtnCinco.Checked == false) && (rbtnSeis.Checked == false) && (rbtnSiete.Checked == false) && (rbtnOcho.Checked == false) && (rbtnNueve.Checked == false) && (rbtnDiez.Checked == false) && (rbtnOnce.Checked == false) && (rbtnDoce.Checked == false) && (rbtnTrece.Checked == false) && (rbtnCatorce.Checked == false) && (rbtnQuince.Checked == false) && (rbtnDieciseis.Checked == false))
          {
                MessageBox.Show("Debe escoger una opción.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
            if ((rbtnUno.Checked == true) &&(rbtnCinco.Checked == true)&& (rbtnOnce.Checked == true) && (rbtnCatorce.Checked == true))
            {

               
                MessageBox.Show("Felicidades aprobó.", "SALBA");          
                total = 0;
                FrmIntroduccion nivel3 = new FrmIntroduccion();
                Nota.notaLvl2 = 5.0f;
                d.ModficarNivel(2);
                Dato.numeroNivel = 2;
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.verificar();
                nivel3.Show();             
                this.Close();
            }           
            else
            {
                MessageBox.Show("Debe repetir el nivel.", "SALBA");
                total = 0;
                rbtnUno.Checked = false;
                rbtnDos.Checked = false;
                rbtnTres.Checked = false;
                rbtnCuatro.Checked = false;
                rbtnCinco.Checked = false;
                rbtnSeis.Checked = false;
                rbtnSiete.Checked = false;
                rbtnOcho.Checked = false;
                rbtnNueve.Checked = false;
                rbtnDiez.Checked = false;
                rbtnOnce.Checked = false;
                rbtnDoce.Checked = false;
                rbtnTrece.Checked = false;
                rbtnCatorce.Checked = false;
                rbtnQuince.Checked = false;
                rbtnDieciseis.Checked = false;

            }

        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            

        }

        private void ChSiete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbtnUno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUno.Checked == true)
            {

                total = total + 1.25f;
            }
        }

        private void rbtnCinco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCinco.Checked == true)
            {

                total = total + 1.25f;
            }
        }

        private void rbtnOnce_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOnce.Checked == true)
            {

                total = total + 1.25f;
            }
        }

        private void rbtnTrece_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCatorce.Checked == true)
            {

                total = total + 1.25f;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnUno_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rbtnDoce_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnDiez_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnNueve_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnCuatro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
