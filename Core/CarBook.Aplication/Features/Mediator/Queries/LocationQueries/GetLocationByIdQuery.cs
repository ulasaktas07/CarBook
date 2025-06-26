using CarBook.Aplication.Features.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.LocationQueries;

public record GetLocationByIdQuery:IRequest<ServiceResult<GetLocationByIdQueryResult>>
{
	public int Id { get; }

	public GetLocationByIdQuery(int id)
	{
		Id = id;
	}
}