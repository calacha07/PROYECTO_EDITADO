﻿using LoginProyecto;
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

namespace PROYECTO.Nivel5
{
    public partial class Nivel5Introduccion : Form
    {
        public Nivel5Introduccion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
            frmMenu.Show();
        }

        private void btnSiguientePregunta_Click(object sender, EventArgs e)
        {
            Hide();
            FrmNivel5 nivel = new FrmNivel5();
            nivel.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
