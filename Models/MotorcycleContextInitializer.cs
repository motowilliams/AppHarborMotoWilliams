using System.Collections.Generic;
using System.Data.Entity.Database;

namespace AppHarborMotoWilliams.Models
{
	public class MotorcycleContextInitializer : DropCreateDatabaseAlways<MotorcycleContext>
	{
		protected override void Seed(MotorcycleContext context)
		{
			var motorcycles = new List<Motorcycle>
			                  	{
			                  		new Motorcycle {CubicCentiMeters = 1450, Make = "Harley Davidson", Model = "Fatboy", Year = 2003},
			                  		new Motorcycle {CubicCentiMeters = 950, Make = "Buell", Model = "Firebold", Year = 2003},
			                  		new Motorcycle {CubicCentiMeters = 510, Make = "KTM", Model = "Sixdays", Year = 2011}
			                  	};

			motorcycles.ForEach(x => context.Motorcycles.Add(x));
			context.SaveChanges();
		}
	}
}