using LoginProyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FrmRegistro : Form
    {
        Funciones dato = new Funciones();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

          bool validarDuplicado =  dato.validarUsuarioRegistro(Convert.ToInt32(txtNumDoc.Text));
            if (validarDuplicado == false)
            {
                if ((txtNombre.Text.Length > 0) && (txtNumDoc.Text.Length > 0) && (txtCorreo.Text.Length > 0) && (txtPassword.Text.Length > 0))
                {
                    dato.registroUsuario(txtNombre.Text, Convert.ToInt32(txtNumDoc.Text), txtCorreo.Text, txtPassword.Text);
                    MessageBox.Show("Registro completado.", "SLABA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Funciones.docIde = txtNumDoc.Text;
                    Close();
                    FrmLoginReg login = new FrmLoginReg();
                    login.Show();
                }
                else
                {


                    MessageBox.Show("Campos incompletos", "SLABA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else {

                MessageBox.Show("Número De documento registrado", "SLABA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

             
            }
         











            /*
            Usuarios agregar = new Usuarios();
            agregar.user = txtNombre.Text;
            agregar.apellido = txtNumDoc.Text;
            agregar.correo = txtCorreo.Text;
            agregar.contra = txtPassword.Text;

            int retorno = Funciones.agregar(agregar);

            if (retorno > 0)
            {
                MessageBox.Show("Registrado en la base de datos, ahora puede iniciar sesión. ", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumDoc.Text = "";
                txtNombre.Text = "";
                txtCorreo.Text = "";
                txtPassword.Text = "";

                Close();
                FrmLoginReg login = new FrmLoginReg();
                login.Show();

            }
            */
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptUser_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            ptNombre.Image = PROYECTO.Properties.Resources.users2;
            flowLayoutPanel1.BackColor = Color.FromArgb(252, 115, 35);
            txtNombre.ForeColor = Color.FromArgb(252, 115, 35);

            ptApellido.Image = PROYECTO.Properties.Resources.users;
            flowLayoutPanel2.BackColor = Color.FromArgb(35, 130, 118);
            txtNumDoc.ForeColor = Color.FromArgb(35, 130, 118);

            ptEmail.Image = PROYECTO.Properties.Resources.envelop1;
            flowLayoutPanel3.BackColor = Color.FromArgb(35, 130, 118);
            txtCorreo.ForeColor = Color.FromArgb(35, 130, 118);

            ptPass.Image = PROYECTO.Properties.Resources.key2;
            flowLayoutPanel4.BackColor = Color.FromArgb(35, 130, 118);
            txtPassword.ForeColor = Color.FromArgb(35, 130, 118);
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            txtNumDoc.Clear();
            ptApellido.Image = PROYECTO.Properties.Resources.users2;
            flowLayoutPanel2.BackColor = Color.FromArgb(252, 115, 35);
            txtNumDoc.ForeColor = Color.FromArgb(252, 115, 35);

            ptNombre.Image = PROYECTO.Properties.Resources.users;
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 130, 118);
            txtNombre.ForeColor = Color.FromArgb(35, 130, 118);


            ptEmail.Image = PROYECTO.Properties.Resources.envelop1;
            flowLayoutPanel3.BackColor = Color.FromArgb(35, 130, 118);
            txtCorreo.ForeColor = Color.FromArgb(35, 130, 118);

            ptPass.Image = PROYECTO.Properties.Resources.key2;
            flowLayoutPanel4.BackColor = Color.FromArgb(35, 130, 118);
            txtPassword.ForeColor = Color.FromArgb(35, 130, 118);
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            txtCorreo.Clear();
            ptEmail.Image = PROYECTO.Properties.Resources.envelop;
            flowLayoutPanel3.BackColor = Color.FromArgb(252, 115, 35);
            txtCorreo.ForeColor = Color.FromArgb(252, 115, 35);

            ptNombre.Image = PROYECTO.Properties.Resources.users;
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 130, 118);
            txtNombre.ForeColor = Color.FromArgb(35, 130, 118);

            ptApellido.Image = PROYECTO.Properties.Resources.users;
            flowLayoutPanel2.BackColor = Color.FromArgb(35, 130, 118);
            txtNumDoc.ForeColor = Color.FromArgb(35, 130, 118);

            ptPass.Image = PROYECTO.Properties.Resources.key2;
            flowLayoutPanel4.BackColor = Color.FromArgb(35, 130, 118);
            txtPassword.ForeColor = Color.FromArgb(35, 130, 118);
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '●';
            ptPass.Image = PROYECTO.Properties.Resources.key1;
            flowLayoutPanel4.BackColor = Color.FromArgb(252, 115, 35);
            txtPassword.ForeColor = Color.FromArgb(252, 115, 35);

            ptNombre.Image = PROYECTO.Properties.Resources.users;
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 130, 118);
            txtNombre.ForeColor = Color.FromArgb(35, 130, 118);

            ptApellido.Image = PROYECTO.Properties.Resources.users;
            flowLayoutPanel2.BackColor = Color.FromArgb(35, 130, 118);
            txtNumDoc.ForeColor = Color.FromArgb(35, 130, 118);

            ptEmail.Image = PROYECTO.Properties.Resources.envelop1;
            flowLayoutPanel3.BackColor = Color.FromArgb(35, 130, 118);
            txtCorreo.ForeColor = Color.FromArgb(35, 130, 118);

        }

        

        

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            FrmLoginReg login = new FrmLoginReg();
            login.Show();
            Close();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
