using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Actualizar;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos.Inventario.Actualizar
{
	public class ActualizarRepuestoAD: IActualizarCarrosAD
	{
		Contexto _elContexto;
		public ActualizarRepuestoAD()
		{
			_elContexto = new Contexto();
		}
		public int Actualizar(Carros elRepuestoParaActualizar)
		{
			Carros elRepuesto = _elContexto.Repuestos.Where(repuesto => repuesto.Id == elRepuestoParaActualizar.Id).FirstOrDefault();
			elRepuesto.NombreDelRepuesto = elRepuestoParaActualizar.NombreDelRepuesto;
			elRepuesto.MarcaDelRepuesto = elRepuestoParaActualizar.MarcaDelRepuesto;
			EntityState estado = _elContexto.Entry(elRepuesto).State = System.Data.Entity.EntityState.Modified;
			int seGuardoElRepuesto = _elContexto.SaveChanges();
			return seGuardoElRepuesto;
		}
	}
}
