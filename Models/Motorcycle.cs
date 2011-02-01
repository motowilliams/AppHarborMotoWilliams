using System.ComponentModel.DataAnnotations;

namespace AppHarborMotoWilliams.Models
{
	public class Motorcycle
	{
		[Key, Column(Order = 0)]
		[DatabaseGenerated(DatabaseGenerationOption.Identity)]
		public int Id { get; set; }
		[Column(Order = 1)]
		public string Make { get; set; }
		[Column(Order = 2)]
		public string Model { get; set; }
		[Column(Order = 3)]
		public int Year { get; set; }
		[Column(Order = 4)]
		public int CubicCentiMeters { get; set; }
	}
}