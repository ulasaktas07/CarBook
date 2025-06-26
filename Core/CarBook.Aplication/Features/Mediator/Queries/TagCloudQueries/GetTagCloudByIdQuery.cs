
using CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;

public record GetTagCloudByIdQuery:IRequest<ServiceResult<GetTagCloudByIdQueryResult>>
{
	public int Id { get; init; }
	public GetTagCloudByIdQuery(int id)
	{
		Id = id;
	}
}
