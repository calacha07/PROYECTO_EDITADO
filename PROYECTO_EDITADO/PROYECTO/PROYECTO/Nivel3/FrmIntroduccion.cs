using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmNivelTres;
using PROYECTO.Menu;


namespace PROYECTO.Nivel3
{
    public partial class FrmIntroduccion : Form
    {
        public FrmIntroduccion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
            frmMenu.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Close();
            FrmNivel3Principal nivelConceptos = new FrmNivel3Principal();
            nivelConceptos.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
