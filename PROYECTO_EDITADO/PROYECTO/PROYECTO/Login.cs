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
using MySql.Data.MySqlClient;
using PROYECTO;

namespace LoginProyecto
{
	public partial class FrmLoginReg : Form
	{
        Funciones dato = new Funciones();
        Dato d = new Dato();
		public FrmLoginReg()
		{
			InitializeComponent();
		
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnIngresar_Click_1(object sender, EventArgs e)
		{
            if ((txtUsuario.Text.Length > 0) && (txtPassword.Text.Length > 0))
            {
                int documento1 = Convert.ToInt32(txtUsuario.Text);
                bool valida = dato.validarUsuario(documento1, txtPassword.Text);
                int documento = Convert.ToInt32(txtUsuario.Text);
   
                d.traerCodigoAprendiz(documento);
                d.InsertarPrimeraVez();
                Dato.documento = Convert.ToInt32(txtUsuario.Text);
                d.ConsultarNivel();
                if (valida == true)
                {
                    MessageBox.Show("Bienvenido al software SALBA.", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto. ", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos no completados. ", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            




        }

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{


        }

		

		

         

    private void Login_Enter(object sender, EventArgs e)
        {

        }

		private void FrmLoginReg_Load(object sender, EventArgs e)
		{
            label1.Select();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();

		}

		private void txtVerfContraseaa_TextChanged(object sender, EventArgs e)
		{

		}
        

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            ptUser.Image = PROYECTO.Properties.Resources.users2;
            panel3.BackColor = Color.FromArgb(252, 115, 35);
            txtUsuario.ForeColor = Color.FromArgb(252, 115, 35);

            ptPass.Image = PROYECTO.Properties.Resources.key;
            panel4.BackColor = Color.FromArgb(35, 130, 118);
            txtPassword.ForeColor = Color.FromArgb(35, 130, 118);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '●';
            ptPass.Image = PROYECTO.Properties.Resources.key1;
            panel4.BackColor = Color.FromArgb(252, 115, 35);
            txtPassword.ForeColor = Color.FromArgb(252, 115, 35);

            ptUser.Image = PROYECTO.Properties.Resources.users;
            panel3.BackColor = Color.FromArgb(35, 130, 118);
            txtUsuario.ForeColor = Color.FromArgb(35, 130, 118);
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
        }

        

        

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmLoginReg_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
