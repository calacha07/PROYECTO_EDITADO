using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FrmNivel6PreguntaCuatro : Form
    {
        int punto;
        public FrmNivel6PreguntaCuatro()
        {
            InitializeComponent();
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPreguntaCuatro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cuarta_Pregunta_Load(object sender, EventArgs e)
        {
            lblTitulo.Select();
        }

        private void rbRespuestaCuatro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((rbRespuestaUno.Checked == false) && (rbRespuestaDos.Checked == false) && (rbRespuestaTres.Checked == false) && (rbRespuestaCuatro.Checked == false))
            {
                MessageBox.Show("Debe seleccionar una opción.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbRespuestaUno.Checked == true)
            {
                AuxiliarNivel.contador += 1;
                FrmNivel6PreguntaCinco pregunta5 = new FrmNivel6PreguntaCinco();
                pregunta5.Show();
                this.Close();
            }
            else
            {
                FrmNivel6PreguntaCinco pregunta5 = new FrmNivel6PreguntaCinco();
                pregunta5.Show();
                this.Close();
            }


        }
    }
}
