using LoginProyecto;
using Proyecto;
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
    public partial class Evaluacion : Form
    {
        public Evaluacion()
        {
            InitializeComponent();
        }

        private void pntNro1_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (cmbRespuesta.Text == "11111 22222 33333 44444")
            {
                MessageBox.Show("Felicidades aprobó con el 100%", "Salba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmCuatroNivel nivel4 = new FrmCuatroNivel();
                nivel4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No aprobó. Repita el Test", "Salba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmNivel3Principal retry = new FrmNivel3Principal();
                retry.Show();
                this.Close();
            }
        }

        private void cmbRespuesta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Evaluacion_Load(object sender, EventArgs e)
        {

        }

        private void lblNro2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
