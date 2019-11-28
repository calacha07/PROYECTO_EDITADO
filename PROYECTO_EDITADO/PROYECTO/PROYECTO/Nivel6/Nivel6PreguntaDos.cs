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
    public partial class FrmNivel6PreguntaDos : Form
    {
        int punto ;
        public FrmNivel6PreguntaDos()
        {
            InitializeComponent();
            
        }

        private void Segunda_Pregunta_Load(object sender, EventArgs e)
        {
            lblTitulo.Select();
        }

        private void chkRespuestaDosA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguienteDos_Click(object sender, EventArgs e)
        {
            if ((rbRespuestaUno.Checked == false) && (rbRespuestaDos.Checked == false) && (rbRespuestaTres.Checked == false) && (rbRespuestaCuatro.Checked == false))
            {
                MessageBox.Show("Debe seleccionar una opción.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbRespuestaTres.Checked == true)
            {
                AuxiliarNivel.contador += 1;
                FrmNivel6PreguntaTres pregunta3 = new FrmNivel6PreguntaTres();
                pregunta3.Show();
                this.Close();
            }
            else
            {
                FrmNivel6PreguntaTres pregunta3 = new FrmNivel6PreguntaTres();
                pregunta3.Show();
                this.Close();
            }
  
        }

        private void txtPreguntaDos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
