using CarBook.Domain.Entities.Common;
namespace CarBook.Domain.Entities
{
	public class Customer : BaseEntity<int>
	{
		public string CustomerName { get; set; } = default!;
		public string CustomerSurname { get; set; } = default!;
		public string CustomerMail { get; set; } = default!;
		public List<RentACarProcess> RentACarProcesses { get; set; } = new(); // bu ayrı ama mevcut kalabilir
	}
}
