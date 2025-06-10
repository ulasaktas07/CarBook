using CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.ServiceQueries;
public record GetServiceByIdQuery:IRequest<ServiceResult<GetServiceByIdQueryResult>>
{
	public int Id { get; init; }
	public GetServiceByIdQuery(int id)
	{
		Id = id;
	}
}
