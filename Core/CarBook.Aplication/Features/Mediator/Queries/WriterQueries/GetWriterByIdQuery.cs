using CarBook.Aplication.Features.Mediator.Results.WriterResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.WriterQueries;
public record GetWriterByIdQuery:IRequest<ServiceResult<GetWriterByIdQueryResult>>
{
	public int Id { get; set; }
	public GetWriterByIdQuery(int id)
	{
		Id = id;
	}
}

