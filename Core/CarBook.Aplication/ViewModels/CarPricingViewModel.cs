
namespace CarBook.Aplication.ViewModels
{
	public class CarPricingViewModel
	{
		public CarPricingViewModel()
		{
			Amounts = new List<Decimal>();
		}

		public string Model { get; set; } = default!;
		public List<Decimal> Amounts { get; set; } = default!;

	}
}
