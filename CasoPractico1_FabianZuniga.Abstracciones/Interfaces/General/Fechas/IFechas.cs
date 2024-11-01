using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.Interfaces.General.Fechas
{
	public interface IFechas
	{
		DateTime ObtenerFecha();
		DateTime ObtenerFechaUTC();
		DateTime ObtenerFechaMenosSeisHoras();
	}
}
