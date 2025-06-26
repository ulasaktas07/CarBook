using CarBook.Aplication.Features.Mediator.Queries.WriterQueries;
using CarBook.Aplication.Features.Mediator.Results.WriterResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.WriterHandlers
{
	public class GetWriterQueryHandler(IRepository<Writer> repository) : IRequestHandler<GetWriterQuery, ServiceResult<List<GetWriterQueryResult>>>
	{
		public async Task<ServiceResult<List<GetWriterQueryResult>>> Handle(GetWriterQuery request, CancellationToken cancellationToken)
		{
			var writers = await repository.GetAllAsync();
			var result = writers.Select(writer => new GetWriterQueryResult(writer.Id, writer.Name, writer.Description, writer.ImageUrl)).ToList();
			return ServiceResult<List<GetWriterQueryResult>>.Success(result);
		}
	}
}
