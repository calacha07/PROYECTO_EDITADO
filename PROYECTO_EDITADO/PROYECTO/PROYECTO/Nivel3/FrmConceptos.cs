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

namespace FrmNivelTres
{
    public partial class FrmNivel3Principal : Form
    {
        public FrmNivel3Principal()
        {
            InitializeComponent();
        }

        private void grpNro1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeleccione.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbSeleccione.Text == "Ciclo")
            {
                txtConceptos.Text = "Un ciclo o bucle, es una instrucción que se ejecuta " +
                    "repetidas veces";

            }

            if (cmbSeleccione.Text == "Contador")
            {
                txtConceptos.Text = "Es una variable en la cual se le asigna un valor que se " +
                    "incrementa o decrementa en cada iteración de un bucle.";
                
            }

            if (cmbSeleccione.Text == "Acumulador ")
            {
                txtConceptos.Text = "Es una variable cuya misión es almacenar diferentes valores. " +
                    "Sumas, restas, multiplicaciones, divisiones, potenciaciones entre otros. ";
            }

            if (cmbSeleccione.Text == "Ciclo Para")
            {
                txtConceptos.Text = "El ciclo para se utiliza generalmente para ejecutar un conjunto de instrucciones " +
                    "que se repiten un número de veces, hasta que la condición asignada a dicho bucle deja de cumplirse.";
               
            }

            if (cmbSeleccione.Text == "Ciclo Mientras")
            {
                txtConceptos.Text = "El ciclo mientras se utiliza cuando se quiere ejecutar repetidamente un bloque " +
                    "de instrucciones basado en una condición. el bucle se repite mientras la condición se cumple.";

            }

            if (cmbSeleccione.Text == "Ciclo Repita")
            {
                txtConceptos.Text = "Es un bucle que no interrumpirá su ejecución hasta que la condición sea cumplida.";

            }
             
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            JuegoCiclosPara juegos = new JuegoCiclosPara();
            juegos.Show();
            this.Close();
          
           
        }

        private void grpImagines_Enter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmNro1_Load(object sender, EventArgs e)
        {

        }

		private void btnRegresar_Click(object sender, EventArgs e)
		{
            FrmIntroduccion introduccion = new FrmIntroduccion();
            introduccion.Show();
		}

        private void grpNro1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lblNro4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblNro1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
	}
}
