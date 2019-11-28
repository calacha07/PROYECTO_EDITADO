using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PROYECTO.Menu;


namespace PROYECTO
{
    class Dato
    {
        public static int documento { get; set; }
        public static int id { get; set; }
        public static int numeroNivel { get; set; }




        public void traerCodigoAprendiz(int documento) {

            try
            {
                
                SqlConnection conx = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("idAprendiz", conx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigoAprendiz", SqlDbType.Int).Value = documento;

                SqlDataReader read = comando.ExecuteReader();


                if (read.Read() == true)
                {


                    id = Convert.ToInt32(read["codAp"]);

                }
                else
                {


                }
            }
            catch (Exception e) {


            }





           

        }


        public void ConsultarNivel()
        {

            try
            {

                SqlConnection conx = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("pa_Defecto", conx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@documento", SqlDbType.Int).Value = id;

                SqlDataReader read = comando.ExecuteReader();

                
                if (read.Read()) {

                    Dato.numeroNivel = Convert.ToInt32(read["numeroNivel"]);
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    menu.verificar();
                }

            }
            catch (Exception e)
            {

                DateTime TIME = new DateTime();
               
                TIME.

            }










        }


        public void ModficarNivel(int numero)
        {

            try
            {

                SqlConnection conx = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("p_ModificarNivel", conx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@numero", SqlDbType.Int).Value = numero;
                comando.Parameters.AddWithValue("@codAp", SqlDbType.Int).Value = id;

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {


            }







        }


        public void InsertarPrimeraVez()
        {

            try
            {

                SqlConnection conx = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("p_InsertarNivel0", conx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codAp", SqlDbType.Int).Value = id;

                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {


            }







        }



        public void Verificar07(int documento)
        {

            try
            {

                SqlConnection conx = Conexion.obtenerConexion();
                SqlCommand comando = new SqlCommand("idAprendiz07", conx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codAp ", SqlDbType.Int).Value = id;

                SqlDataReader read = comando.ExecuteReader();


                if (read.Read() == true)
                {


                    InsertarPrimeraVez();

                }
                else
                {
                   

                }
            }
            catch (Exception e)
            {


            }







        }



    }
}
