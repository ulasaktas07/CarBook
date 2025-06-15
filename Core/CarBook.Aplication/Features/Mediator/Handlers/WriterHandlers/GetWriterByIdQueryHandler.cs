using CarBook.Aplication.Features.Mediator.Queries.WriterQueries;
using CarBook.Aplication.Features.Mediator.Results.WriterResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.WriterHandlers
{
	public class GetWriterByIdQueryHandler(IRepository<Writer> repository) :
		 IRequestHandler<GetWriterByIdQuery, ServiceResult<GetWriterByIdQueryResult>>
	{
		public async Task<ServiceResult<GetWriterByIdQueryResult>> Handle(GetWriterByIdQuery request, CancellationToken cancellationToken)
		{
			var writer = await repository.GetByIdAsync(request.Id);
			if (writer == null)
			{
				return ServiceResult<GetWriterByIdQueryResult>.Fail("Yazar bulunamadı", HttpStatusCode.NotFound);
			}
			var result = new GetWriterByIdQueryResult(writer.Id, writer.Name, writer.ImageUrl, writer.Description);

			return ServiceResult<GetWriterByIdQueryResult>.Success(result);
		}
	}
}
