using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class EjercicioDos : Form
    {
        
        public EjercicioDos()
        {
            InitializeComponent();
            timer2.Start();
          
        }

        private void EjercicioDos_Load(object sender, EventArgs e)
        {
            timer2.Interval = auxiliar.inter;
            this.rbA.Checked = false;
            this.rbB.Checked = false;
            this.rbC.Checked = false;
            this.rbD.Checked = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EjercicioTres tres = new EjercicioTres();
            if ((this.rbA.Checked == false) && (this.rbB.Checked == false) && (this.rbC.Checked == false) && (this.rbD.Checked == false))
            {
                MessageBox.Show("Seleccione una casilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.rbC.Checked == true)
            {
                timer2.Stop();
                auxiliar.total += 1;
                auxiliar.r2 = 1;
                this.Hide();
                tres.Show();
            }
            else
            {
                timer2.Stop();
                this.Hide();
                tres.Show();
            }          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = Convert.ToString(auxiliar.tiempo) + " Segundos";
            auxiliar.tiempo--;
            if (auxiliar.tiempo == 0)
            {
                timer2.Stop();
                MessageBox.Show("Tiempo Agotado", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTiempo.Text = "0";
                Result resultado = new Result();
                this.Hide();
                resultado.Show();
;            }

        }
    }
}
