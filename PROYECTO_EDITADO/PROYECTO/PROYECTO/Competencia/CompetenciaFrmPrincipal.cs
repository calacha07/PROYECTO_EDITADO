using PROYECTO.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Competencia
{
	public partial class frmCompetencias : Form
	{
		private static Axuliar auxi = new Axuliar();
		private static CompetenciaFrmDificil dificil = new CompetenciaFrmDificil();
		public frmCompetencias()
		{
			InitializeComponent();
			grbFacil.Visible = false;
			grbMedioo.Visible = false;
			grbDificil.Visible = false;
			grbAvanzado.Visible = false;

		}
		private void btnFacil_Click(object sender, EventArgs e)
		{
			grbFacil.Visible = true;
			grbMedioo.Visible = false;
			grbDificil.Visible = false;
			grbAvanzado.Visible = false;
		}

		private void btnMedio_Click(object sender, EventArgs e)
		{
			grbMedioo.Visible = true;
			grbFacil.Visible = false;
			grbDificil.Visible = false;
			grbAvanzado.Visible = false;
		}

		private void grbMedio_Enter(object sender, EventArgs e)
		{

		}

		private void btnDificil_Click(object sender, EventArgs e)
		{
			grbDificil.Visible = true;
			grbFacil.Visible = false;
			grbMedioo.Visible = false;
			grbAvanzado.Visible = false;
		}

		private void btnAvanzado_Click(object sender, EventArgs e)
		{
			grbAvanzado.Visible = true;
			grbFacil.Visible = false;
			grbMedioo.Visible = false;
			grbDificil.Visible = false;
		}

		private void btnCompetenciaFacil_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Seguro de comenzar la dificultad Fácil?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				auxi.seleccionarFacil();
			}

		}

		private void btnDifiicil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Seguro de comenzar la dificultad Difícil?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				auxi.seleccionarDificil();
			}
		}

		private void btnAvanzadoo_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Seguro de comenzar la dificultad Avanzado?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				auxi.seleccionarAvanzado();
			}
		}

		private void btnMedioo_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Seguro de comenzar la dificultad Medio?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				auxi.seleccionarMedio();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void lblDefinicionAvanzado_Click(object sender, EventArgs e)
        {

        }

        private void grbAvanzado_Enter(object sender, EventArgs e)
        {

        }

        private void grbMedioo_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCompetenciaFacil_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de comenzar la dificultad Fácil?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Hide();
                auxi.seleccionarFacil();

            }
        }

        private void btnMedioo_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de comenzar la dificultad Medio?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Hide();
                auxi.seleccionarMedio();
                
            }
        }

        private void btnDifiicil_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de comenzar la dificultad DifÍcil?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Hide();
                auxi.seleccionarDificil();
                
            }

        }

        private void btnAvanzadoo_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de comenzar la dificultad Avanzado?", "Señor usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Hide();
                auxi.seleccionarAvanzado();
                
            }
        }

        private void frmCompetencias_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
