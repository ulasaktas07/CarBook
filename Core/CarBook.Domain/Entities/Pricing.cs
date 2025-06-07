using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;
namespace CarBook.Domain.Entities
{
	public class Pricing:BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public List<CarPricing> CarPricings { get; set; } = default!;
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
