using CarBook.Aplication.Features.Mediator.Queries.LocationQueries;
using CarBook.Aplication.Features.Mediator.Results.LocationResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.LocationHandlers
{
	public class GetLocationByIdQueryHandler(IRepository<Location> repository) : 
		IRequestHandler<GetLocationByIdQuery, ServiceResult<GetLocationByIdQueryResult>>
	{
		public async Task<ServiceResult<GetLocationByIdQueryResult>> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
		{
			var location = await repository.GetByIdAsync(request.Id);
			if (location is null || location.Id!=request.Id)
				return ServiceResult<GetLocationByIdQueryResult>.Fail("Location bulunamadı", System.Net.HttpStatusCode.NotFound);
			
			var result = new GetLocationByIdQueryResult(location.Id, location.Name);
			return ServiceResult<GetLocationByIdQueryResult>.Success(result);
		}
	}
}
