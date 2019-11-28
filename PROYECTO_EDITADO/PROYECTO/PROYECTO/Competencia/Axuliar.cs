using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
	class Axuliar
	{
		private static CompetenciaFrmFacil facil;
		private static CompetenciaFrmMedio medio;

		private static CompetenciaFrmDificil dificil;
		private static CompetenciaFrmAvanzado avanzado;
        

		public void seleccionarFacil()
		{
			facil = new CompetenciaFrmFacil();
			facil.ShowDialog();
		}
		public void seleccionarMedio()
		{
			medio = new CompetenciaFrmMedio();
			medio.ShowDialog();
		}
		public void seleccionarDificil()
		{
			dificil = new CompetenciaFrmDificil();
			dificil.ShowDialog();
		}
		public void seleccionarAvanzado()
		{
			avanzado = new CompetenciaFrmAvanzado();
			avanzado.ShowDialog();
		}
	}
}
