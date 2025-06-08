namespace CarBook.Aplication.Features.CQRS.Queries.CarQueries
{
	public record GetCarByIdQuery(int Id)
	{
		public int Id { get; } = Id;

	}
}
