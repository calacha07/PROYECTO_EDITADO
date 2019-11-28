using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PROYECTO
{
	class Conexion
	{

        private static SqlConnection conex;

        private Conexion()
        {

        }

		public static SqlConnection obtenerConexion()
		{
            SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadena);
			conex.Open();

			return conex;
		}


	}
}
