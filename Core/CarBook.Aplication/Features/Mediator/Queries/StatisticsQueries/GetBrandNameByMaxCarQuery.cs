using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;

public record GetBrandNameByMaxCarQuery:IRequest<ServiceResult<GetBrandNameByMaxCarQueryResult>>;
