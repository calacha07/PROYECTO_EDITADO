using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmNivelTres;
using PROYECTO;

namespace FrmNivelTres
{
    public partial class JuegoCicloRepita : Form
    {
        int respuesta = 0;
        public JuegoCicloRepita()
        {
            InitializeComponent();
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            int x=0;
            if (cmbNro1.Text == "acumulador")
            {
                x = x + 33;
            }
            if (cmbNro2.Text == "Repita")
            {
                x = x + 33;
            }
            if (cmbNro3.Text == "o")
            {
                x = x + 34;
            }
            if (x == 100)
            {
                AuxiliarNivel.juego3Nivel3 = 1;
                respuesta = 1;
                MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No aprobó. Repita la práctica didáctica", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbNro1.Text = null;
            cmbNro2.Text = null;
            cmbNro3.Text = null;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            JuegoCicloMientras juego2 = new JuegoCicloMientras();
            juego2.Show();
        }

        private void JuegoCicloRepita_Load(object sender, EventArgs e)
        {

        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            if(AuxiliarNivel.juego3Nivel3 == 1)
            {
                Close();
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.Show();     
            }
            else
            {
                if ((cmbNro1.Text.Length == 0) && (cmbNro2.Text.Length == 0) && (cmbNro3.Text.Length == 0))
                {
                    MessageBox.Show("Termine la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (respuesta == 1)
                    {
                        Close();
                        Evaluacion evaluacion = new Evaluacion();
                        evaluacion.Show();
                    }

                    else
                    {
                        MessageBox.Show("Las respuestas deben ser correctas.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void cmbNro3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNro2_Click(object sender, EventArgs e)
        {

        }

        private void cmbNro2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
