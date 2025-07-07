using CarBook.Domain.Entities.Common;
namespace CarBook.Domain.Entities
{
	public class RentACar: BaseEntity<int>
	{
		public int LocationID { get; set; }
		public Location Location { get; set; }= default!;
		public int CarID { get; set; }
		public Car Car { get; set; }= default!;
		public bool Available { get; set; }
	}
}
