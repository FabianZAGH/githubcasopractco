using ManejoDeInventario.Abstracciones.Interfaces.General.Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.LogicaDeNegocio.General.Fechas
{
	public class Fechas: IFechas
	{

		public DateTime ObtenerFecha()
		{
			return DateTime.Now;
		}

		public DateTime ObtenerFechaUTC()
		{
			return DateTime.UtcNow;
		}

		public DateTime ObtenerFechaMenosSeisHoras()
		{
			return DateTime.UtcNow.AddHours(-6);
		}
	}
}
