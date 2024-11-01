using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.ModelosAccesoADatos
{
	[Table("Repuestos")]
	public class Carros
	{
		[Column("Id")]
		public int Id { get; set; }
		[Column("CodigoDelRepuesto")]
		public string CodigoDelRepuesto { get; set; }
		[Column("NombreDelRepuesto")]
		public string NombreDelRepuesto { get; set; }
		public string Vehiculo { get; set; }
		public string Modelo { get; set; }
		public string MarcaDelRepuesto { get; set; }
		public string Anio { get; set; }
		public int Cantidad { get; set; }
		public DateTime FechaDeRegistro { get; set; }
		public DateTime FechaDeModificacion { get; set; }
		public bool Estado { get; set; }
    }
}
