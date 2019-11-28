using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
	class Usuarios
	{
		public string user { get; set; }
		public string apellido { get; set; }
		public string correo { get; set; }
		public string contra { get; set; }

		public Usuarios()
		{

		}

		public Usuarios(string user, string apellido, string correo, string contra)
		{
			this.user = user;
			this.apellido = apellido;
			this.correo = correo;
			this.contra = contra;

		}
	}
}
