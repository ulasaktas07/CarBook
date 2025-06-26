using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Contact: BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public string Email { get; set; } = default!;
		public string Subject { get; set; } = default!;
		public string Message { get; set; } = default!;
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }

	}
}
