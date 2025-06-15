using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
	public record GetBlogQuery:IRequest<ServiceResult<List<GetBlogQueryResult>>>;
