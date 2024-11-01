using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Eliminar;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Eliminar;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.AccesoADatos.Inventario.Eliminar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.Eliminar
{
	public class EliminarCarrosLN: IEliminarInventarioLN
	{
		IEliminarCarrosAD _eliminarRepuestoAD;
		public EliminarCarrosLN() {
			_eliminarRepuestoAD = new EliminarRepuestoAD();
		}

		public int Eliminar(int Id)
		{
			if (Id == 0)
			{
				return 0;
			}
			int cantidadDeElementosEliminados = _eliminarRepuestoAD.Eliminar(Id);
			return cantidadDeElementosEliminados;
		}
	}
}
