using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
public record GetBlogByWriterIdQuery:IRequest<ServiceResult<GetBlogByWriterIdQueryResult>>
{
	public int Id { get; set; }
	public GetBlogByWriterIdQuery(int id)
	{
		Id = id;
	}
}
