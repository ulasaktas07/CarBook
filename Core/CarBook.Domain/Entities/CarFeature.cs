using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class CarFeature:BaseEntity<int>, IAuditEntity
	{
		public int CarId { get; set; }
		public Car Car { get; set; } = default!;
		public int FeatureId { get; set; }
		public Feature? Feature { get; set; }
		public bool Available { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
