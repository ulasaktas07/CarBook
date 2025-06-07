namespace CarBook.Aplication.Features.CQRS.Queries.BannerQueries
{
	public record GetBannerByIdQuery(int Id)
	{
		public int Id { get; } = Id;
	}
}
