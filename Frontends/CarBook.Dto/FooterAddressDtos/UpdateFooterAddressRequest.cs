namespace CarBook.Dto.FooterAddressDtos
{
	public class UpdateFooterAddressRequest
	{
		public int Id { get; set; }
		public string Description { get; set; } = default!;
		public string Address { get; set; } = default!;
		public string Phone { get; set; } = default!;
		public string Email { get; set; } = default!;
	}
}
