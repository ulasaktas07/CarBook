namespace CarBook.Aplication.Features.CQRS.Queries.AboutQueries
{
	public record GetAboutByIdQuery(int Id)
	{
		public int Id { get; } = Id;
	}
}


