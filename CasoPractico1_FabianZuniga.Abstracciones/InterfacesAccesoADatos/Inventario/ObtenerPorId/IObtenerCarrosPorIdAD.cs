using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.ObtenerPorId
{
	public interface IObtenerCarrosPorIdAD
	{
		Carros Obtener(int Id);
	}
}
