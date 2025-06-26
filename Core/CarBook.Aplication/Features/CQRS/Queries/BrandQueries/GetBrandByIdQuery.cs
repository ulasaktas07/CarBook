namespace CarBook.Aplication.Features.CQRS.Queries.BrandQueries
{
	public record GetBrandByIdQuery(int Id)
	{
		public int Id { get; } = Id;
	}
}
