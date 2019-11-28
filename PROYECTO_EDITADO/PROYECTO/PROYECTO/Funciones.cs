using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO
{
	class Funciones
	{
        public static string docIde;


		public void registroUsuario(string nombre, int id, string correo, string contraseña)
        {
            try
            {
                SqlConnection conex = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("pa_RegisUsuario", conex);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nomApre", SqlDbType.Text).Value = nombre;
                comando.Parameters.Add("@numDoc", SqlDbType.Int).Value = id ;
                comando.Parameters.Add("@corrApre", SqlDbType.Text).Value = correo;
                comando.Parameters.Add("@pass", SqlDbType.Text).Value = contraseña;
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                DataSet set = new DataSet();
                adap.Fill(set, "RegistroAprendiz");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        public bool validarUsuario(int documento,string pass)
        {
            try
            {
      
          
                bool valida = false;
                SqlConnection conx = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("pa_ValidApre", conx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@numDoc", SqlDbType.Int).Value = documento;
                comando.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = pass;
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {

                    valida = true;
                    

                }
                else {

                    valida = false;
                }
                leer.Close();
                return valida;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }
            
        }


        public bool validarUsuarioRegistro(int documento)
        {
            try
            {


                bool valida = false;
                SqlConnection conx = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("pa_ValidApreRegistro", conx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@numDoc", SqlDbType.Int).Value = documento;
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {

                    valida = true;


                }
                else
                {

                    valida = false;
                }
                leer.Close();
                return valida;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }

        }
    }
}
