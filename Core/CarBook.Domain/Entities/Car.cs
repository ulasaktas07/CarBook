using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Car : BaseEntity<int>, IAuditEntity
	{
		public int BrandID { get; set; }
		public Brand Brand { get; set; } = default!;
		public string Model { get; set; } = default!;
		public string CoverImageUrl { get; set; } = default!;
		public int Km { get; set; } 
		public string Transmission { get; set; } = default!;
		public byte Seat { get; set; } 
		public byte Lunggage { get; set; } 
		public string? Fuel { get; set; } 
		public string BigImageUrl { get; set; } = default!;
		public List<CarFeature> CarFeatures { get; set; } = default!;
		public List<CarDescription>? CarDescriptions { get; set; }
		public List<CarPricing> CarPricings { get; set; } = default!;
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
