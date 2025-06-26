using CarBook.Aplication.Features.Mediator.Queries.LocationQueries;
using CarBook.Aplication.Features.Mediator.Results.LocationResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.LocationHandlers
{
	public class GetLocationQueryHandler(IRepository<Location> repository) :
		IRequestHandler<GetLocationQuery, ServiceResult<List<GetLocationQueryResult>>>
	{
		public async Task<ServiceResult<List<GetLocationQueryResult>>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
		{
			var locations = await repository.GetAllAsync();

			var result = locations.Select(l => new GetLocationQueryResult(l.Id, l.Name)).ToList();
			return ServiceResult<List<GetLocationQueryResult>>.Success(result);
		}
	}
}
