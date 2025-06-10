using CarBook.Aplication.Features.Mediator.Queries.ServiceQueries;
using CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
	public class GetServiceQueryHandler(IRepository<Service> repository)
		: IRequestHandler<GetServiceQuery, ServiceResult<List<GetServiceQueryResult>>>
	{
		public async Task<ServiceResult<List<GetServiceQueryResult>>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
		{
			var services = await repository.GetAllAsync();

			var serviceResults = services.Select(s => new GetServiceQueryResult(s.Id,s.Title,s.Description,s.IconUrl)).ToList();

			return ServiceResult<List<GetServiceQueryResult>>.Success(serviceResults);
		}
	}
}
