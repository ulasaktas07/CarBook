using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Comment : BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public int BlogID { get; set; }
		public Blog Blog { get; set; } = default!;
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
