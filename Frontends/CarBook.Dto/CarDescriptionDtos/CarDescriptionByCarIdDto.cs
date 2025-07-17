namespace CarBook.Dto.CarDescriptionDtos
{
	public class CarDescriptionByCarIdDto
	{
		public int Id { get; set; }
		public int CarId { get; set; }
		public string Details { get; set; } = default!;
	}
}
