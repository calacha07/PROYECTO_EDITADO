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
    public partial class FrmNivel6PreguntaUno : Form
    {

  
        public FrmNivel6PreguntaUno()
        {
            InitializeComponent();
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEjercicio6_Load(object sender, EventArgs e)
        {
            lblTitulo.Select();
        }

        private void chkRespuestaUnoD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguienteUno_Click(object sender, EventArgs e)
        {
            if ((rbRespuestaUno.Checked == false) && (rbRespuestaDos.Checked==false)&& (rbRespuestaTres.Checked == false) && (rbRespuestaCuatro.Checked == false))
            {
                MessageBox.Show("Debe seleccionar una opción.","SALBA",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (rbRespuestaUno.Checked == true)
            {
                AuxiliarNivel.contador += 1;
                FrmNivel6PreguntaDos pregunta2 = new FrmNivel6PreguntaDos();
                pregunta2.Show();
                this.Close();
            }
            else
            {
                FrmNivel6PreguntaDos pregunta2 = new FrmNivel6PreguntaDos();
                pregunta2.Show();
                this.Close();
            }

        }
    }
}
