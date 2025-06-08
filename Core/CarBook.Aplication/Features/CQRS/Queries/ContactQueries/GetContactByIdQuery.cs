
namespace CarBook.Aplication.Features.CQRS.Queries.ContactQueries
{
	public record GetContactByIdQuery(int Id)
	{
		public int Id { get; } = Id;
	}
}
