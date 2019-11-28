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
    public partial class frmEntero : Form
    {
        public frmEntero()
        {
            InitializeComponent();
            lblEntero.Select();
        }

        private void frmEntero_Load(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            FrmVariables retry = new FrmVariables();
            retry.Show();
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            frmReal real = new frmReal();
            real.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbDE_Enter(object sender, EventArgs e)
        {

        }
    }
}
