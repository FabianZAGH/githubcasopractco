using ManejoDeInventario.Abstracciones.ModelosAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeInventario.AccesoADatos
{
	public class Contexto: DbContext
	{
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<FLOTA_ADMINISTRATIVA>().ToTable("FLOTA_ADMINISTRATIVA");
			modelBuilder.Entity<RESERVACIONES>().ToTable("RESERVACIONES");

		}
		public DbSet<Carros> FLOTA_ADMINISTRATIVA { get; set; }
		public DbSet<RESERVACIONES> RESERVACIONES { get; set; }
	}
}
