using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmBooleano : Form
    {
        public FrmBooleano()
        {
            InitializeComponent();
            lblbooleano.Select();
        }

        private void frmBooleano_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            frmCadena cadena = new frmCadena();
            cadena.Show();
        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            
            frmEvaluacion evaluacion = new frmEvaluacion();
            evaluacion.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbB_Enter(object sender, EventArgs e)
        {

        }
    }
}
