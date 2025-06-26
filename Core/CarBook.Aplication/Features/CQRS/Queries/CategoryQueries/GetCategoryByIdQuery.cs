namespace CarBook.Aplication.Features.CQRS.Queries.CategoryQueries
{
	public record GetCategoryByIdQuery(int Id)
	{
		public int Id { get; } = Id;

	}
}
