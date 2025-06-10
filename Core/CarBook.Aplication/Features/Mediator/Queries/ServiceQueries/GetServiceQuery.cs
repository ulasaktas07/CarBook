using CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using MediatR;
namespace CarBook.Aplication.Features.Mediator.Queries.ServiceQueries;
public record GetServiceQuery:IRequest<ServiceResult<List<GetServiceQueryResult>>>;