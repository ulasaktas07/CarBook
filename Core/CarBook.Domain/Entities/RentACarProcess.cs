using CarBook.Domain.Entities;
using CarBook.Domain.Entities.Common;

public class RentACarProcess : BaseEntity<int>
{
	public int CarID { get; set; }
	public Car Car { get; set; } = default!;

	public int PickUpLocation { get; set; }
	public Location PickUpLocationNavigation { get; set; } = default!;

	public int DropOffLocation { get; set; }
	public Location DropOffLocationNavigation { get; set; } = default!;

	public DateOnly PickUpDate { get; set; }
	public DateOnly DropOffDate { get; set; }
	public TimeOnly PickUpTime { get; set; }
	public TimeOnly DropOffTime { get; set; }

	public int CustomerID { get; set; }
	public Customer Customer { get; set; } = default!;
	public string? PickUpDescription { get; set; }
	public string? DropOffDescription { get; set; }
	public decimal TotalPrice { get; set; }
}