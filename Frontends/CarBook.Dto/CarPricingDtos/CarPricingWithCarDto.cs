namespace CarBook.Dto.CarPricingDtos
{
	public class CarPricingWithCarDto 
	{
		public int Id { get; set; }
		public int CarId { get; set; }
		public string Brand { get; set; }= default!;
		public string Model { get; set; } = default!;
		public decimal Price { get; set; }
		public string CoverImageUrl { get; set; } = default!;
	}
}
