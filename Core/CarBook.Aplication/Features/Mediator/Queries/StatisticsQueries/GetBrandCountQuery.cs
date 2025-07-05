using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using MediatR;

namespace BrandBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
public record GetBrandCountQuery : IRequest<ServiceResult<GetBrandCountQueryResult>>;
