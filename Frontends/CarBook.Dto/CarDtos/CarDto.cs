﻿
namespace CarBook.Dto.CarDtos
{
	public class CarDto
	{
		public int Id { get; set; }
		public int BrandID { get; set; }
		public string BrandName { get; set; } = default!;
		public string Model { get; set; } = default!;
		public string CoverImageUrl { get; set; } = default!;
		public int Km { get; set; }
		public string Transmission { get; set; } = default!;
		public byte Seat { get; set; }
		public byte Lunggage { get; set; }
		public string? Fuel { get; set; }
		public string BigImageUrl { get; set; } = default!;
	}
}
