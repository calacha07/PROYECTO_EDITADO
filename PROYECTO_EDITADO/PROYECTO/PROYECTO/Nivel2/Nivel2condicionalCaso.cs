using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO;


namespace EJERCICIOS
{
    public partial class Nivel2condicionalCaso : Form
    {
        
        public Nivel2condicionalCaso()
        {
            InitializeComponent();
        }

        private void Condicionales_Enter(object sender, EventArgs e)
        {

        }
        private void Label26_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
                   
        }

        private void CbCaracter_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void CbCaso_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CbFinCaso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((cbCaracter.Text.Length==0 ) && (cbReal.Text.Length==0) && (cbCaso.Text.Length==0) && (cbFinCaso.Text.Length == 0))
            {
                MessageBox.Show("Debe completar la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else    
            {
                if ((cbCaracter.Text == "Caracter") && (cbReal.Text == "Real") && (cbCaso.Text == "Caso") && (cbFinCaso.Text == "Fin Caso"))
                {
                    MessageBox.Show("Felicidades aprobó la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nivel2Evaluacion test = new Nivel2Evaluacion();
                    test.Show();
                    Close();
                   

                }
                else
                {
                    MessageBox.Show("Repita la práctica didáctica.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
            }
            
           
            
            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			Close();
            frmNivel2condicionalCompuesta nivel2 = new frmNivel2condicionalCompuesta();
            nivel2.Show();


        }

        private void Nivel2condicionalCaso_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
