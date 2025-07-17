using CarBook.Aplication.Features.Mediator.Results.ReviewResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.ReviewQueries;

public record GetReviewByCarIdQuery: IRequest<ServiceResult<List<GetReviewByCarIdQueryResult>>>
{
	public int Id { get; set; }
	public GetReviewByCarIdQuery(int id)
	{
		Id = id;
	}
}
