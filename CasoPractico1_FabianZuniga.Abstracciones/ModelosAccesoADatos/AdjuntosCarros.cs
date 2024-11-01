using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.Abstracciones.ModelosAccesoADatos
{
	[Table("AdjuntosRepuestos")]
	public class AdjuntosCarros
	{
        public int Id { get; set; }
        public string Adjunto { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public int IdRepuesto { get; set; }
    }
}
