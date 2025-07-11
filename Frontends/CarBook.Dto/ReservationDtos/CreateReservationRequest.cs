namespace CarBook.Dto.ReservationDtos
{
	public class CreateReservationRequest
	{
		public string Name { get; set; } = default!;
		public string Surname { get; set; } = default!;
		public string Email { get; set; } = default!;
		public string Phone { get; set; } = default!;
		public int CarID { get; set; } = default!;
		public int PickUpLocationID { get; set; }
		public int DropOffLocationID { get; set; }
		public int Age { get; set; }
		public int DriverLicenseYear { get; set; }
		public string? Description { get; set; }

	}
}
