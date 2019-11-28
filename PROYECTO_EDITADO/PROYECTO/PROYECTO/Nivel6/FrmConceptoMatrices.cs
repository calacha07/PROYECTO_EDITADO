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
using PROYECTO.Nivel3;

namespace PROYECTO
{
    public partial class FrmConceptoMatrices : Form
    {
        public FrmConceptoMatrices()
        {
            InitializeComponent();
        }
        private void FrmConceptoMatrices_Load(object sender, EventArgs e)
        {
            lblTituloNivel6.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAvanzarNivel_Click(object sender, EventArgs e)
        {
            FrmNivel6PreguntaUno pregunta1 = new FrmNivel6PreguntaUno();
            pregunta1.Show();
            this.Hide();
        }



		private void button1_Click(object sender, EventArgs e)
		{
            FrmIntroduccion retry = new FrmIntroduccion();
            retry.Show();
            Close();
		}

        private void lblConcepto_Click(object sender, EventArgs e)
        {

        }
	}
}
