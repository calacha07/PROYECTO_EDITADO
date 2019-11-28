using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO.Nivel4
{
    public partial class FrmCuatroPrincipal : Form
    {
        public FrmCuatroPrincipal()
        {
            InitializeComponent();
        }

        private void cboConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConcepto.Text == "Procedimiento")
            {
                txtConceptos.Text = "Un procedimiento es un subprograma que realiza una tarea específica y que puede ser definido mediante 0 , 1 o más parámetros . \n" +
                    " Tanto en entrada de información al procedimiento como la devolución de resultados desde el subprograma se realiza mediante parámetros, " +
                    "el cual sirve para introducir o modificar información del programa principal.";
            }
            else if (cboConcepto.Text == "Función")
            {
                txtConceptos.Text = "Las funciones son subprogramas que hacen una o más instrucciones pero que siempre retornan un valor.";
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Close();
            Practica1 practica = new Practica1();
            practica.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FrmIntroducionNivel4 intro4 = new FrmIntroducionNivel4();
            intro4.Show();
        }

        private void FrmCuatroPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblEjemplo_Click(object sender, EventArgs e)
        {

        }
    }
}
