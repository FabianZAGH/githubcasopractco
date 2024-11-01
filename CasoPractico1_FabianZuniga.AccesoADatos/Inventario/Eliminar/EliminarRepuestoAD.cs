using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Eliminar;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos.Inventario.Eliminar
{
	public class EliminarRepuestoAD: IEliminarCarrosAD
	{
		Contexto _elContexto;
		public EliminarRepuestoAD()
		{
			_elContexto = new Contexto();
		}
		public int Eliminar(int Id)
		{
			Carros elRepuesto = _elContexto.Repuestos.Where(repuesto => repuesto.Id == Id).FirstOrDefault();
			_elContexto.Repuestos.Remove(elRepuesto);
			EntityState estado = _elContexto.Entry(elRepuesto).State = System.Data.Entity.EntityState.Deleted;
			int seGuardoElRepuesto = _elContexto.SaveChanges();
			return seGuardoElRepuesto;
		}
	}
}
