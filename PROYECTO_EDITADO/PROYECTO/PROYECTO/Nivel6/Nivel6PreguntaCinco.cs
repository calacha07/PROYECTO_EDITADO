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

namespace PROYECTO
{
    public partial class FrmNivel6PreguntaCinco : Form
    {
        int punto;
        public FrmNivel6PreguntaCinco()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNivel6PreguntaCinco_Load(object sender, EventArgs e)
        {
            lblTitulo.Select();
        }

        private void btnFinPrubea_Click(object sender, EventArgs e)
        {
            if ((cmbRespuestaUno.Text == "") | (cmbRespuestaDos.Text == "") | (cmbRespuestaTres.Text == ""))
            {
              
                    MessageBox.Show("Debe seleccionar todos los campos.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
    
            }
           else  if ((cmbRespuestaUno.Text == "Entero") &&(cmbRespuestaDos.Text=="Entero") && (cmbRespuestaTres.Text == "Escriba"))
            {
                AuxiliarNivel.contador+= 1;
                if (AuxiliarNivel.contador >= 4)
                {
                    MessageBox.Show("Pasó todos los niveles.", "SALBA", MessageBoxButtons.OK);
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    Dato d = new Dato();
                    d.ModficarNivel(6);
                    Dato.numeroNivel = 6;
                    menu.verificar();
                    menu.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("No logró superar el nivel 6 ", "SALBA", MessageBoxButtons.OK);
                    FrmNivel6PreguntaUno retry = new FrmNivel6PreguntaUno();
                    retry.Show();
                    this.Close();
                }

            }
            else
            {
                if (AuxiliarNivel.contador >= 4)
                {
                    MessageBox.Show("Pasó todos los niveles.", "SALBA", MessageBoxButtons.OK);
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    Dato d = new Dato();
                    d.ModficarNivel(6);
                    Dato.numeroNivel = 6;
                    menu.verificar();
                    menu.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("No logró superar el nivel 6 ", "SALBA", MessageBoxButtons.OK);
                    FrmNivel6PreguntaUno retry = new FrmNivel6PreguntaUno();
                    retry.Show();
                    this.Close();
                }
            }







        }

        private void cmbRespuestaUno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
