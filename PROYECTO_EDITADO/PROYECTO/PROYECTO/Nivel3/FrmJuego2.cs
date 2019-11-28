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

namespace FrmNivelTres
{
    public partial class JuegoCicloMientras : Form
    {
        int respuesta = 0;
        public JuegoCicloMientras()
        {
            InitializeComponent();
        }

        private void JuegoCicloMientras_Load(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Close();
            JuegoCiclosPara juego1 = new JuegoCiclosPara();
            juego1.Show();
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (cmbNro1.Text == "54321")
            {
                AuxiliarNivel.juego2Nivel3 = 1;
                respuesta = 1;
                MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No aprobó. Repita la práctica didáctica", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if(AuxiliarNivel.juego2Nivel3 == 1)
            {
                Close();
                JuegoCicloRepita juego3 = new JuegoCicloRepita();
                juego3.Show();
            }
            else
            {
                if (cmbNro1.Text.Length == 0)
                {
                    MessageBox.Show("Termine la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (respuesta == 1)
                    {
                        Close();
                        JuegoCicloRepita juego3 = new JuegoCicloRepita();
                        juego3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Las respuestas deben ser correctas.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
            }




           
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbNro1.Text = null;
        }

		private void cmbNro1_SelectedIndexChanged(object sender, EventArgs e)
		{
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
