using LoginProyecto;
using Proyecto;
using PROYECTO.Nivel4;
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

namespace FrmNivelTres
{
    public partial class Evaluacion : Form
    {
        Dato d = new Dato();
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
                MessageBox.Show("Felicidades aprobó.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                d.ModficarNivel(3);
                Dato.numeroNivel = 3;
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.verificar();
                FrmIntroducionNivel4 nivel4 = new FrmIntroducionNivel4();
                nivel4.Show();
                this.Close();
                Nota.notaLvl3 = 5.0f;
            }
            else
            {
                MessageBox.Show("No aprobó. Repita el test.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
