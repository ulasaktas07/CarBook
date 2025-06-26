
using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
public record GetBlogByIdQuery : IRequest<ServiceResult<GetBlogByIdQueryResult>>
{
	public int Id { get; set; }
	public GetBlogByIdQuery(int id)
	{
		Id = id;
	}
}