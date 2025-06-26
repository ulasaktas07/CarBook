using CarBook.Aplication.Features.Mediator.Queries.FeatureQueries;
using CarBook.Aplication.Features.Mediator.Results.FeatureResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.FeatureHandlers
{
	public class GetFeatureByIdQueryHandler(IRepository<Feature> repository) :
		IRequestHandler<GetFeatureByIdQuery, ServiceResult<GetFeatureByIdQueryResult>>
	{
		public async Task<ServiceResult<GetFeatureByIdQueryResult>> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
		{
			var feature = await repository.GetByIdAsync(request.Id);
			if (feature == null||feature.Id!=request.Id) return ServiceResult<GetFeatureByIdQueryResult>.Fail("Feature bulunamadı",HttpStatusCode.NotFound);
			var result =  new GetFeatureByIdQueryResult(feature.Id, feature.Name);

			return ServiceResult<GetFeatureByIdQueryResult>.Success(result);
		}
	}
}
