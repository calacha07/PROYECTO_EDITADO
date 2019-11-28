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
    public partial class FrmNivel6PreguntaTres : Form
    {

        public FrmNivel6PreguntaTres()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNivel6PreguntaTres_Load(object sender, EventArgs e)
        {
            lblTitulo.Select();
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if ((rbRespuestaUno.Checked == false) && (rbRespuestaDos.Checked ==false) && (rbRespuestaTres.Checked == false) && (rbRespuestaCuatro.Checked == false))
            {
                MessageBox.Show("Debe seleccionar una opción.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbRespuestaUno.Checked == true)
            {
                AuxiliarNivel.contador+= 1;
                FrmNivel6PreguntaCuatro pregunta4 = new FrmNivel6PreguntaCuatro();
                pregunta4.Show();
                this.Close();
            }
            else
            {
                FrmNivel6PreguntaCuatro pregunta4 = new FrmNivel6PreguntaCuatro();
                pregunta4.Show();
                this.Close();
            }
 
        }

        private void gpRespuestas_Enter(object sender, EventArgs e)
        {

        }
    }
}
