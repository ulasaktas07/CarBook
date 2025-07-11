namespace CarBook.Dto.CarPricingDtos
{
	public class CarPricingListWithModelDto
	{
		public string model { get; set; }= default!;
		public string coverImageUrl { get; set; }= default!;
		public string brandName { get; set; }= default!;
		public decimal dailyPrice { get; set; }
		public decimal weeklyPrice { get; set; }
		public decimal monthlyPrice { get; set; }

	}
}
