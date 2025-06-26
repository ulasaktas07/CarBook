using CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries
{
	public record GetTagCloudByBlogIdQuery:IRequest<ServiceResult<List<GetTagCloudByBlogIdQueryResult>>>
	{
		public int Id { get; init; }

		public GetTagCloudByBlogIdQuery(int id)
		{
			Id = id;
		}
	}
}
