using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class SocialMedia:BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public string Url { get; set; } = default!;
		public string? Icon { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
