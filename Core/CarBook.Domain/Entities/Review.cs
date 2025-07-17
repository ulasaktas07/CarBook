using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Review : BaseEntity<int>, IAuditEntity
	{
		public string CustomerName { get; set; } = default!;
		public string? CustomerImage { get; set; } 
		public string Comment { get; set; } = default!;
		public int RaytingValue { get; set; } 
		public Car Car { get; set; } = default!;
		public int CarID { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
