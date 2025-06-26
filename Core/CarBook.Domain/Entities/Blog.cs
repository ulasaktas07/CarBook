using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Blog : BaseEntity<int>, IAuditEntity
	{
		public string Title { get; set; } = default!;
		public int WriterID { get; set; }
		public Writer Writer { get; set; }= default!;
		public string CoverImageUrl { get; set; }= default!;
		public int CategoryID { get; set; }
		public Category Category { get; set; }= default!;
		public string Description { get; set; } = default!;
		public List<TagCloud>? TagClouds { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
