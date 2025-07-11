using App.Domain.Entities.Common;
using CarBook.Domain.Entities;
using CarBook.Domain.Entities.Common;

public class Location : BaseEntity<int>, IAuditEntity
{
	public string Name { get; set; } = default!;
	public List<RentACar> RentACars { get; set; } = new();  // bu ayrı ama mevcut kalabilir
	public List<Reservation> PickUpReservations { get; set; } = new();
	public List<Reservation> DropOffReservations { get; set; } = new();
	public DateTime Created { get; set; }
	public DateTime? Updated { get; set; }
}