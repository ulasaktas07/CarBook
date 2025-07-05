using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using MediatR;

namespace LocationBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
public record GetLocationCountQuery : IRequest<ServiceResult<GetLocationCountQueryResult>>;
