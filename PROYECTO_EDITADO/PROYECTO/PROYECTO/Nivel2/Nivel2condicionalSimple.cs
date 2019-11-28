using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOS
{
    public partial class frmNivel2condicionalSimple : Form
    {

        public frmNivel2condicionalSimple()
        {
            InitializeComponent();
        }

     
        private void CbSueldo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CbSueldo2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void CbValor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CbEscriba_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnEvaluar_Click(object sender, EventArgs e)
        {
          
        }

      
        private void CondicionalSimple_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((cbSueldo.Text.Length == 0) && (cbSueldo2.Text.Length == 0) && (cbValor.Text.Length == 0) && (cbEscriba.Text.Length == 0))
            {
                MessageBox.Show("Debe completar la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((cbSueldo.Text == "sueldo") && (cbSueldo2.Text == "sueldo") && (cbValor.Text == "3000") && (cbEscriba.Text == "Escriba"))
                {
                    MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNivel2condicionalCompuesta ejercicio2 = new frmNivel2condicionalCompuesta();
                    ejercicio2.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Repita la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			Close();
			FrmNivel2Principal principal = new FrmNivel2Principal();
			principal.Show();
			
		}

        private void Condicionales_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
	}
}
