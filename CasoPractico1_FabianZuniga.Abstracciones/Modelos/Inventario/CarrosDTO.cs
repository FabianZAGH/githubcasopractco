using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ManejoDeInventario.Abstracciones.Modelos.Inventario
{
	public class CarrosDTO
	{
        public int Id { get; set; }
        [DisplayName("Código del carro")]
		[Required]
		[MinLength(4)]
		public string Modelo { get; set; }
		public string Marca { get; set; }
		public string Anio { get; set; }
		public int Tipo { get; set; }
        public double MontoPorDia { get; set; }
        public string MontoDeSeguro { get; set; }
        public string FechaDeRegistro { get; set; }
		public string FechaDeModificacion { get; set; }
		public bool Estado { get; set; }
    }
}
