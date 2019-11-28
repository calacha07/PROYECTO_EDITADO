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
    public partial class JuegoCiclosPara : Form
    {
        int respuesta = 0;
        public JuegoCiclosPara()
        {
            InitializeComponent();
        }

        private void Juegos_Ciclos_Load(object sender, EventArgs e)
        {

        }

        private void cmbNro1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNro2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (cmbNro1.Text == "Escriba")
            {
                x = x + 33;
            }
            if (cmbNro2.Text == "n3")
            {
                x = x + 33;
            }
            if (cmbNro3.Text == "Para")
            {
                x = x + 34;
            }
            if (x == 100)
            {
                AuxiliarNivel.juego1Nivel3 = 1;
                respuesta = 1;
             
                MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No aprobó. Repita la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            FrmNivel3Principal frmNivel3 = new FrmNivel3Principal();
            frmNivel3.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (AuxiliarNivel.juego1Nivel3 == 1)
            {
                Close();
                JuegoCicloMientras juegos2 = new JuegoCicloMientras();
                juegos2.Show();
            }
            else
            {
                if ((cmbNro1.Text.Length == 0) && (cmbNro2.Text.Length == 0) && (cmbNro3.Text.Length == 0))
                {
                    MessageBox.Show("Termine la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if ((respuesta == 1))
                    {
                        Close();
                        JuegoCicloMientras juegos2 = new JuegoCicloMientras();
                        juegos2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Las respuestas deben ser correctas.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }


                }
            }



            
            
            
           
        
            
        }  
    }
}
