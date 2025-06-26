using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class FooterAddress:BaseEntity<int>, IAuditEntity
	{
		public string Description { get; set; } = default!;
		public string Address { get; set; } = default!;
		public string Phone { get; set; } = default!;
		public string Email { get; set; } = default!;
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }

	}
}
