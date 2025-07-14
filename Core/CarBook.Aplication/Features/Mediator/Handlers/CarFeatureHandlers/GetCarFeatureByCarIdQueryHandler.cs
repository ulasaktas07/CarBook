using CarBook.Aplication.Features.Mediator.Queries.CarFeatureQueries;
using CarBook.Aplication.Features.Mediator.Results.CarFeatureResults;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.CarFeatureHandlers
{
	public class GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository) : IRequestHandler<GetCarFeatureByCarIdQuery, ServiceResult<List<GetCarFeatureByCarIdQueryResult>>>
	{
		public async Task<ServiceResult<List<GetCarFeatureByCarIdQueryResult>>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
		{
			List<CarFeature> carFeatures = await repository.GetCarFeaturesByCarIdAsync(request.CarId);
			if (carFeatures == null || carFeatures.Count == 0)
			{
				return ServiceResult<List<GetCarFeatureByCarIdQueryResult>>
					.Fail("Belirtilen araç kimliği için araç özelliği bulunamadı.", HttpStatusCode.NotFound);
			}
			var result = carFeatures.Select(cf => new GetCarFeatureByCarIdQueryResult(cf.Id,cf.FeatureId,cf.Feature!.Name,
				cf.Available)).ToList();
			return ServiceResult<List<GetCarFeatureByCarIdQueryResult>>.Success(result);
		}
	}
}
