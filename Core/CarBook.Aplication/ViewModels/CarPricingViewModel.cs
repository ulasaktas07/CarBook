
namespace CarBook.Aplication.ViewModels
{
	public class CarPricingViewModel
	{
		public CarPricingViewModel()
		{
			Amounts = new List<Decimal>();
		}
		public string BrandName { get; set; } = default!;
		public string CoverImage { get; set; } = default!;

		public string Model { get; set; } = default!;
		public List<Decimal> Amounts { get; set; } = default!;

	}
}
