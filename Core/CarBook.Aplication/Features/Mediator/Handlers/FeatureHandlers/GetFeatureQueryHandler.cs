using CarBook.Aplication.Features.Mediator.Queries.FeatureQueries;
using CarBook.Aplication.Features.Mediator.Results.FeatureResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.FeatureHandlers
{
	public class GetFeatureQueryHandler(IRepository<Feature> repository) :
		IRequestHandler<GetFeatureQuery, ServiceResult<List<GetFeatureQueryResult>>>
	{
		public async Task<ServiceResult<List<GetFeatureQueryResult>>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
		{
			var features = await repository.GetAllAsync();
			var result = features.Select(f => new GetFeatureQueryResult(f.Id, f.Name)).ToList();
			return ServiceResult<List<GetFeatureQueryResult>>.Success(result);
		}
	}
}
