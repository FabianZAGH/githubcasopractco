using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Listar;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Listar;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.AccesoADatos.Inventario.Listar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.Listar
{
	public class ListarCarrosLN: IListarRepuestosLN
	{
		IListarRepuestosAD _listarInventario;
		public ListarCarrosLN()
		{
			_listarInventario = new ListarRepuestosAD();
		}
		public List<CarrosDTO> Listar()
		{
			List<CarrosDTO> laListaDeRepuestosEnBaseDeDatos = _listarInventario.Listar();
			return laListaDeRepuestosEnBaseDeDatos;
		}

	}
}
