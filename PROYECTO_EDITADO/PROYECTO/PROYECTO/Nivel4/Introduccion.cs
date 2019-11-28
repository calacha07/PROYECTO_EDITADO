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
using Proyecto;


namespace PROYECTO.Nivel4
{
    public partial class FrmIntroducionNivel4 : Form
    {
        public FrmIntroducionNivel4()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
            frmMenu.Show();
        }

        

        private void Introducion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmCuatroPrincipal cuatro0 = new FrmCuatroPrincipal();
            cuatro0.Show();
            Close();
        }
    }
}
