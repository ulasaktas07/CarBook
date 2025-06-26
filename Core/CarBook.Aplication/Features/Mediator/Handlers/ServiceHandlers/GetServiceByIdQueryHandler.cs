using CarBook.Aplication.Features.Mediator.Queries.ServiceQueries;
using CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
	public class GetServiceByIdQueryHandler(IRepository<Service> repository)
		: IRequestHandler<GetServiceByIdQuery, ServiceResult<GetServiceByIdQueryResult>>
	{
		public async Task<ServiceResult<GetServiceByIdQueryResult>> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
		{
			var service = await repository.GetByIdAsync(request.Id);

			if (service == null || service.Id != request.Id)
				return ServiceResult<GetServiceByIdQueryResult>.Fail("Servis bulunamadı", HttpStatusCode.NotFound);

			var result = new GetServiceByIdQueryResult(service.Id, service.Title, service.Description, service.IconUrl);

			return ServiceResult<GetServiceByIdQueryResult>.Success(result);
		}
	}
}
