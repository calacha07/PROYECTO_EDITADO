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
    public partial class Practica1 : Form
    {
        public Practica1()
        {
            InitializeComponent();
        }

        private void Practica1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmCuatroPrincipal conceptos = new FrmCuatroPrincipal();
            conceptos.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((cmbNro1.Text.Length == 0) && (cmbNro2.Text.Length == 0) && (cmbNro3.Text.Length == 0) && (cmbNro4.Text.Length == 0))
            {
                MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if ((cmbNro1.Text.Trim() == "resultado") && (cmbNro2.Text.Trim() == "Fin") && (cmbNro3.Text.Trim() == "Llamar") && (cmbNro4.Text.Trim() == "5"))
                {
                    MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    Practica2 practica = new Practica2();
                    practica.Show();
                }
                else
                {
                    MessageBox.Show("No aprobó. Repita la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
           
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
