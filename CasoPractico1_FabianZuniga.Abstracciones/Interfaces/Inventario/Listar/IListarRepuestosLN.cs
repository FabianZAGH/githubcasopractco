using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.Interfaces.Inventario.Listar
{
	public interface IListarRepuestosLN
	{
		List<CarrosDTO> Listar();
	}
}
