using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using MediatR;

namespace BlogBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
public record GetBlogCountQuery : IRequest<ServiceResult<GetBlogCountQueryResult>>;

