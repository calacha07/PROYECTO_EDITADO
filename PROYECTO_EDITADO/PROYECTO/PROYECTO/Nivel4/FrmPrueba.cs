using LoginProyecto;
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
using PROYECTO.Nivel5;
using PROYECTO;

namespace Proyecto
{
    public partial class FrmPueba : Form
    {
        float i;
        Dato d = new Dato();
        public FrmPueba()
        {
            InitializeComponent();
        }

        private void lblPregunta3_Click(object sender, EventArgs e)
        {

        }

        private void cbTest2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTest1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTest1.Text == "Falso")
            {
                i = i + 2.5f;
            }
            else
            {

            }
        }

        private void cboEntero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTest2.Text == "Función")
            {
                i=i+2.5f; 
            }
            else
            {

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void FrmPueba_Load(object sender, EventArgs e)
        {

        }

		private void grpbTest_Enter(object sender, EventArgs e)
		{

		}

        private void lblPregunta1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i >= 4)
            {

                MessageBox.Show("Felicidades aprobó.", "SALBA");
                cbTest1.Text = "";
                cboTest2.Text = "";
                d.ModficarNivel(4);
                Dato.numeroNivel = 4;
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.verificar();

                i = 0;
                Nivel5Introduccion nivel5 = new Nivel5Introduccion();
                nivel5.Show();
                this.Close();

            }
            else
            {

                MessageBox.Show("Debe repetir el nivel.", "SALBA");
                cbTest1.Text = "";
                cboTest2.Text = "";
                i = 0;

            }
        }
	}
}
