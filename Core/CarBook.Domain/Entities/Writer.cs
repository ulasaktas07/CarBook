using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;
namespace CarBook.Domain.Entities
{
	public class Writer:BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string? ImageUrl { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
		public List<Blog>? Blogs { get; set; }
	}
}
