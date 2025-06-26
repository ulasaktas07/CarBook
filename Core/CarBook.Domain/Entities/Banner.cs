using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Banner:BaseEntity<int>, IAuditEntity
	{
		public string Title { get; set; }=default!;
		public string? Description { get; set; }
		public string? VideoDescription { get; set; }
		public string? VideoUrl { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
