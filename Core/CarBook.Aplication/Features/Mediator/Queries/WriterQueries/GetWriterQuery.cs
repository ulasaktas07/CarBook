using CarBook.Aplication.Features.Mediator.Results.WriterResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.WriterQueries;
public record GetWriterQuery:IRequest<ServiceResult<List<GetWriterQueryResult>>>;