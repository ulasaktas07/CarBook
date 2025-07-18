using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class AppUser : BaseEntity<int>, IAuditEntity
	{
		public string UserName { get; set; } = default!;
		public string Password  { get; set; } = default!;
		public string Name  { get; set; } = default!;
		public string Surname  { get; set; } = default!;
		public string Email  { get; set; } = default!;
		public int AppRoleId { get; set; }
		public AppRole AppRole { get; set; } = default!;

		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
	}
}
