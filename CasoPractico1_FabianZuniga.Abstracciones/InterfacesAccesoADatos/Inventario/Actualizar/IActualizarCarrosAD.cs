using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Actualizar
{
	public interface IActualizarCarrosAD
	{
		int Actualizar(Carros elRepuestoParaActualizar);
	}
}
