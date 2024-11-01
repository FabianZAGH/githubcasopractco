using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.ObtenerPorId;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos.Inventario.ObtenerPorId
{
	public class ObtenerRepuestoPorIdAD: IObtenerCarrosPorIdAD
	{
		Contexto _elContexto;
		public ObtenerRepuestoPorIdAD()
		{
			_elContexto = new Contexto();
		}
		public Carros Obtener(int Id)
		{
			Carros elRepuesto = _elContexto.Repuestos.Where(repuesto => repuesto.Id == Id).FirstOrDefault();
			return elRepuesto;
		}
	}
}
