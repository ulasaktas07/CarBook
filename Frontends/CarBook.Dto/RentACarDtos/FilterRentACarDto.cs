namespace CarBook.Dto.RentACarDtos
{
	public class FilterRentACarDto
	{
		public int carID { get; set; }
		public string brand { get; set; }=default!;
		public string model { get; set; } = default!;
		public decimal price { get; set; }
		public string coverImageUrl { get; set; } = default!;


	}
}
