using EJERCICIOS;
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
using Proyecto;
using PROYECTO.Menu;

namespace Proyecto
{
   
    public partial class frmEvaluacion : Form
    {
        Dato d = new Dato();
        float i=0;
        public frmEvaluacion()
        {
            InitializeComponent();
        }

        private void frmEvaluacion_Load(object sender, EventArgs e)
        {

        }

        private void tbReal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTest1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTest1.Text== "Tipo de dato booleano")
            {
                i = i + 1.25f;
        
            }
            else
            {

            }
        }

        private void cboEntero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTest2.Text == "Tipo de dato cadena")
            {
                i = i + 1.25f;
            }
            else
            {

            }
        }

        private void cbTest2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTest3.Text == "Tipo de dato cadena")
            {
                i = i + 1.25f;
            }
            else
            {

            }

            
        }

        private void cboTextt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTextt.Text == "Tipo de dato real")
            {
                i = i + 1.25f;
            }
            else
            {

            }
           
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
            if (i >= 4)
            {

                
                MessageBox.Show("Felicidades aprobó.", "SALBA");
                cbTest2.Text = ("");
                cbTest1.Text = ("");
                cbTest3.Text = ("");
                cboTextt.Text = ("");
                d.ModficarNivel(1);
                Dato.numeroNivel = 1;
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.verificar();
               
                


                Nota.NotaLvl1 = i;
                i = 0;
                IntroduccionLvl2 nivel2 = new IntroduccionLvl2();
                nivel2.Show();
                this.Close();
            }
            else
             {
                
                MessageBox.Show("Debe repetir el nivel.","SALBA");
                cbTest2.Text = null;
                cbTest1.Text = null;
                cbTest3.Text = null;
                cboTextt.Text = null;

                i = 0;
                
            }


        }

        private void grpbTest_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPregunta2_Click(object sender, EventArgs e)
        {

        }
    }
}
