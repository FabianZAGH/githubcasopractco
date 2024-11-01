using ManejoDeInventario.Abstracciones.Modelos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.Interfaces.Clientes.Listar
{
	public interface IListarClientesLN
	{
		List<ClientesDto> Listar();
	}
}
