using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using MediatR;

namespace WriterBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
public record GetWriterCountQuery : IRequest<ServiceResult<GetWriterCountQueryResult>>;
