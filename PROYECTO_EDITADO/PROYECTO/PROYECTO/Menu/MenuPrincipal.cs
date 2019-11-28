using Competencia;
using EJERCICIOS;
using FrmNivelTres;
using LoginProyecto;
using Matematicas.Repaso;
using Proyecto;
using PROYECTO.Nivel1;
using PROYECTO.Nivel3;
using PROYECTO.Nivel4;
using PROYECTO.Nivel5;
using PROYECTO.Nivel6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace PROYECTO.Menu
{
    public partial class FrmMenuPrincipal : Form
    {

        Dato d = new Dato();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (BarraMenu.Width == 220)
            {
                BarraMenu.Width = 65;
                btnSalir.Location = new Point(679, 3);
                btnMinimizar.Location = new Point(641, 5);

                panelIntroducc.Location = new Point(139, 56);
            }
            else
            {
                BarraMenu.Width = 220;
                btnSalir.Location = new Point(527, 3);
                btnMinimizar.Location = new Point(489 , 5);
                
                panelIntroducc.Location = new Point(220, 82);



            }
        }

        

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
            
        }

        

        private void btnNivel_Click(object sender, EventArgs e)
        {

            if (BarraNiveles.Visible == false)
            {
                BarraNiveles.Visible = true;
                

            }
            else
            {
                BarraNiveles.Visible = false;
                

            }

            btnNivel.Location = new Point(8, 93);
            PanelNivel.Location = new Point(0, 93);
            BarraNiveles.Location = new Point(10, 138);
            btnCompetencia.Location = new Point(8, 423);
            panelCompeten.Location = new Point(0, 423);
            btnMatermaticas.Location = new Point(8, 473);
            panelMate.Location = new Point(0, 473);
            btnCrear.Location = new Point(8, 524);
            panelCrear.Location = new Point(0, 524);
            
            






            if (BarraNiveles.Visible == false)
            {
                btnNivel.Location = new Point(8, 93);
                PanelNivel.Location = new Point(0, 93);                
                btnCompetencia.Location = new Point(6, 144);
                panelCompeten.Location = new Point(0, 144);
                btnMatermaticas.Location = new Point(6, 194);
                panelMate.Location = new Point(0, 194);
                btnCrear.Location = new Point(6, 245);
                panelCrear.Location = new Point(0, 245);
                
                //panelIntroducc.Location = new Point(223, 44);

                
                


            }
        }

        private void btnCompetencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Competencia no implementada", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*frmCompetencias competencia = new frmCompetencias();
            competencia.Show();
            Close();*/
        }

        private void FrmMenuPrincipal_Load_1(object sender, EventArgs e)
        {




            if (Dato.numeroNivel == 0)
            {

                btnNivel1.Enabled = true;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }
            //Validar Nivel

            if (Dato.numeroNivel == 1) {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = true;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;
              
              


            }


            if (Dato.numeroNivel == 2)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = true;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }

            if (Dato.numeroNivel == 3)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = true;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }


            if (Dato.numeroNivel == 4)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = true;
                btnNIvel6.Enabled = false;


            }



            if (Dato.numeroNivel == 5)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = true;


            }

            if (Dato.numeroNivel == 6)
            {

                btnNivel1.Enabled = true;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }



            //Fin Validar Nivel

            llbLeer.Links.Add(0, llbLeer.Text.Length, "file:///C:/Users/crist/Downloads/PROYECTO_EDITADO/PROYECTO_EDITADO/PROYECTO/SALBA1.pdf");
            btnUsuario.Text = "     "+AuxiliarNivel.nombre;


            BarraMenu.Width = 220;

            btnNivel.Location = new Point(8, 93);
            PanelNivel.Location = new Point(0, 93);
            btnCompetencia.Location = new Point(6, 144);
            panelCompeten.Location = new Point(0, 144);
            btnMatermaticas.Location = new Point(6, 194);
            panelMate.Location = new Point(0, 194);
            btnCrear.Location = new Point(6, 245);
            panelCrear.Location = new Point(0, 245);


            panelIntroducc.Location = new Point(220, 82);



            //BarraNiveles.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            Frminstruccion nivel1 = new Frminstruccion();
            nivel1.Show();
            Close();
        }

        private void btnNivel2_Click(object sender, EventArgs e)
        {
            IntroduccionLvl2 nivel2 = new IntroduccionLvl2();
            nivel2.Show();
            Close();
        }

        private void btnNivel3_Click(object sender, EventArgs e)
        {
            FrmIntroduccion nivel3 = new FrmIntroduccion();
            nivel3.Show();
            Close();
        }

        private void btnNivel4_Click(object sender, EventArgs e)
        {
            FrmIntroducionNivel4 nivel4 = new FrmIntroducionNivel4();
            nivel4.Show();
            Close();
        }

        private void btnNivel5_Click(object sender, EventArgs e)
        {
            Nivel5Introduccion nivel5 = new Nivel5Introduccion();
            nivel5.Show();
            Close();
        }

       

        private void btnMatermaticas_Click(object sender, EventArgs e)
        {
            Form0 matematicas = new Form0();
            matematicas.Show();
            Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            DialogResult salir= MessageBox.Show("¿Desea cerrar sesión?", "SALBA", MessageBoxButtons.YesNo);
            if (salir == DialogResult.Yes)
            {
                this.Close();
                FrmLoginReg login = new FrmLoginReg();
                login.Show();
            }
            
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crear sala no implementada", "SALBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNIvel6_Click_1(object sender, EventArgs e)
        {
            FrmIntroduccionNivel6 nivel6 = new FrmIntroduccionNivel6();
            nivel6.Show();
            Close();
        }

        private void llbLeer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo informacion = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(informacion);
        }


        public  void verificar()
        {




            //Validar Nivel

            if (Dato.numeroNivel == 0)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = true;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }


            if (Dato.numeroNivel == 1)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = true;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;
           

            }


            if (Dato.numeroNivel == 2)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = true;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }

            if (Dato.numeroNivel == 3)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = true;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }


            if (Dato.numeroNivel == 4)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = true;
                btnNIvel6.Enabled = false;


            }



            if (Dato.numeroNivel == 5)
            {

                btnNivel1.Enabled = false;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = true;


            }

            if (Dato.numeroNivel == 6)
            {

                btnNivel1.Enabled = true;
                btnNivel2.Enabled = false;
                btnNivel3.Enabled = false;
                btnNivel4.Enabled = false;
                btnNivel5.Enabled = false;
                btnNIvel6.Enabled = false;


            }



            //Fin Validar Nivel
        }
    }
}
