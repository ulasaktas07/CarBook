using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using MediatR;
namespace CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;

public record GetCarCountByKmSmallerThan1000Query:IRequest<ServiceResult<GetCarCountByKmSmallerThan1000QueryResult>>;
