using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.GuardarImagen;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos.Inventario.GuardarImagen
{
	public class GuardarImagenAD: IGuardarImagenAD
	{
		Contexto _elContexto;
		public GuardarImagenAD()
		{
			_elContexto = new Contexto();
		}
		public async Task<int> Guardar(AdjuntosCarros laImagenAGuardar)
		{
			_elContexto.AdjuntosRepuestos.Add(laImagenAGuardar);
			EntityState estado = _elContexto.Entry(laImagenAGuardar).State = System.Data.Entity.EntityState.Added;
			int seGuardoLaImagen = await _elContexto.SaveChangesAsync();
			return seGuardoLaImagen;
		}
	}
}
