using CarBook.Aplication.Features.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.LocationQueries;
public record GetLocationQuery : IRequest<ServiceResult<List<GetLocationQueryResult>>>;
