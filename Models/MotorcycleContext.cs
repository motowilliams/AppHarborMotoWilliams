using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppHarborMotoWilliams.Models
{
	public interface IMotorcycleContext
	{
		DbSet<Motorcycle> Motorcycles { get; set; }
	}

	public class MotorcycleContext : DbContext, IMotorcycleContext
	{
		public DbSet<Motorcycle> Motorcycles { get; set; }
	}
}