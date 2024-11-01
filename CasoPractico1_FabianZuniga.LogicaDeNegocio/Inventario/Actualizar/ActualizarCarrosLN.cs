using ManejoDeInventario.Abstracciones.Interfaces.Conversiones.Inventario;
using ManejoDeInventario.Abstracciones.Interfaces.Inventario.Actualizar;
using ManejoDeInventario.Abstracciones.InterfacesAccesoADatos.Inventario.Actualizar;
using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using ManejoDeInventario.AccesoADatos.Inventario.Actualizar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.LogicaDeNegocio.Inventario.Actualizar
{
	public class ActualizarCarrosLN: IActualizarInventarioLN
	{
		IActualizarCarrosAD _actualizarRepuestosAD;
		IConvertirMiModeloEnVistaATabla _convertirModelo;
		public ActualizarCarrosLN() {
			_actualizarRepuestosAD = new ActualizarRepuestoAD();
		}

		public int Actualizar(CarrosDTO elRepuestoParaActualizar)
		{
			Carros elRepuestoConvertido = _convertirModelo.ObtenerRepuesto(elRepuestoParaActualizar);
			int seGuardoElRepuesto = _actualizarRepuestosAD.Actualizar(elRepuestoConvertido);
			return seGuardoElRepuesto;
		}



	}
}
