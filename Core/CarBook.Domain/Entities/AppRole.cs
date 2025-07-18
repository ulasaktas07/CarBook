using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;
namespace CarBook.Domain.Entities
{
	public class AppRole : BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public List<AppUser>? AppUsers { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
