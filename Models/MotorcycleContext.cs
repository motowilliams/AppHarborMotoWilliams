using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppHarborMotoWilliams.Models
{
	public class MotorcycleContext : DbContext
	{
		public DbSet<Motorcycle> Motorcycles { get; set; }
	}
}