using CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;
public record GetTagCloudQuery:IRequest<ServiceResult<List<GetTagCloudQueryResult>>>;
