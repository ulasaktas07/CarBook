using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.BlogQueries;

	public record GetLast3BlogsWithWritersQuery:IRequest<ServiceResult<List<GetLast3BlogsWithWritersQueryResult>>>;