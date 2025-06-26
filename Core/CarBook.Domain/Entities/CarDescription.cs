using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class CarDescription: BaseEntity<int>, IAuditEntity
	{
		public int CarId { get; set; }
		public Car Car { get; set; } = default!;
		public string Details { get; set; } = default!;
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
