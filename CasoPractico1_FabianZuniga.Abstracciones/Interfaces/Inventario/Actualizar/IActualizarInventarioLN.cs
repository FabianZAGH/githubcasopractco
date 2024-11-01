using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.Interfaces.Inventario.Actualizar
{
	public interface IActualizarInventarioLN
	{
		int Actualizar(CarrosDTO elRepuestoParaActualizar);
	}
}
