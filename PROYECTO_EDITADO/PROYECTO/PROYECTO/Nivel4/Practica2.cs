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

namespace PROYECTO.Nivel4
{
    public partial class Practica2 : Form
    {
        public Practica2()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            Practica1 practica = new Practica1();
            practica.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((cmbNro1.Text.Length == 0) && (cmbNro2.Text.Length == 0) && (cmbNro3.Text.Length == 0) && (cmbNro4.Text.Length == 0))
            {
                MessageBox.Show("Las respuestas deben ser correctas.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if ((cmbNro1.Text.Trim() == "i") && (cmbNro2.Text.Trim() == "Inicio") && (cmbNro3.Text.Trim() == "Fin") && (cmbNro4.Text.Trim() == "50"))
                {
                    MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    FrmPueba prueba = new FrmPueba();
                    prueba.Show();

                }
                else
                {
                    MessageBox.Show("No aprobó. Repita la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbNro3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Practica2_Load(object sender, EventArgs e)
        {

        }

        private void cmbNro1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEvaluar_Click(object sender, EventArgs e)
        {
            //BtnLimpiar
            cmbNro1.Text = null;
            cmbNro2.Text = null;
            cmbNro3.Text = null;
            cmbNro4.Text = null;
        }
    }
}
