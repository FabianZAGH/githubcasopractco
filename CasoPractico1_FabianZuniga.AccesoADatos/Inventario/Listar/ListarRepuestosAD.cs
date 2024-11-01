using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Listar;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos.Inventario.Listar
{
	public class ListarRepuestosAD: IListarRepuestosAD
	{
		Contexto elContexto;

		public ListarRepuestosAD()
		{
			elContexto = new Contexto();
		}

		public List<CarrosDTO> Listar()
		{
			List<CarrosDTO> losRepuestos = (from inventario in elContexto.Repuestos
											  //join imagenEnBD in elContexto.AdjuntosRepuestos on inventario.Id equals imagenEnBD.IdRepuesto 
											  select new CarrosDTO { 
												Id = inventario.Id,
												FechaDeRegistro = inventario.FechaDeRegistro.ToString(),
												FechaDeModificacion = inventario.FechaDeModificacion.ToString(),
												Anio = inventario.Anio,
												Cantidad = inventario.Cantidad,
												CodigoDelRepuesto = inventario.CodigoDelRepuesto,
												MarcaDelRepuesto = inventario.MarcaDelRepuesto,
												Estado = inventario.Estado,
												Modelo = inventario.Modelo,
												NombreDeArchivo = inventario.NombreDelRepuesto,
												NombreDelRepuesto = inventario.NombreDelRepuesto,
												Vehiculo = inventario.Vehiculo,
												//Base64Imagen = imagenEnBD.Adjunto
											}).ToList();
			return losRepuestos;
		}
	}
}
