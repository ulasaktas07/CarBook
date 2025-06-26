using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Testimonial:BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public string Title { get; set; } = default!;
		public string? Comment { get; set; }
		public string? ImageUrl { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
