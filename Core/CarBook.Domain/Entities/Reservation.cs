using App.Domain.Entities.Common;
using CarBook.Domain.Entities.Common;

namespace CarBook.Domain.Entities
{
	public class Reservation : BaseEntity<int>, IAuditEntity
	{
		public string Name { get; set; } = default!;
		public string Surname { get; set; } = default!;
		public string Email { get; set; } = default!;
		public string Phone { get; set; } = default!;
		public int CarID { get; set; } = default!;
		public Car Car { get; set; } = default!;
		public int? PickUpLocationID { get; set; }
		public int? DropOffLocationID { get; set; }
		public int Age { get; set; }
		public int DriverLicenseYear { get; set; }
		public string? Description { get; set; }
		public string Status { get; set; } = default!;
		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }

		public Location PickUpLocation { get; set; } = default!;
		public Location DropOffLocation { get; set; } = default!;
	}
}
