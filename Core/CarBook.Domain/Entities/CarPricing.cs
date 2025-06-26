using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class CarPricing:BaseEntity<int>, IAuditEntity
	{
		public int CarId { get; set; }
		public Car Car { get; set; } = default!;
		public int PricingId { get; set; }
		public Pricing Pricing { get; set; } = default!;
		public decimal Price { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }

	}
}
