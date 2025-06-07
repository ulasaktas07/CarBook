namespace CarBook.Aplication.Features.Queries.AboutQueries
{
	public record GetAboutByIdQuery(int id)
	{
		public int Id { get; } = id;
	}
}


