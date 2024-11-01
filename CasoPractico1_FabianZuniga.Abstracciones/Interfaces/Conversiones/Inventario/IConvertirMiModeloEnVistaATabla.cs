using ManejoDeInventario.Abstracciones.Modelos.Inventario;
using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.Interfaces.Conversiones.Inventario
{
	public interface IConvertirMiModeloEnVistaATabla
	{
		Carros ObtenerRepuesto(CarrosDTO elRepuesto);
	}
}
