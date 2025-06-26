using CarBook.Aplication.Features.Mediator.Queries.PricingQueries;
using CarBook.Aplication.Features.Mediator.Results.PricingResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.PricingHandlers
{
	public class GetPricingQueryHandler(IRepository<Pricing> repository) :
		IRequestHandler<GetPricingQuery, ServiceResult<List<GetPricingQueryResult>>>
	{
		public async Task<ServiceResult<List<GetPricingQueryResult>>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
		{
			var result = await repository.GetAllAsync();

			var pricingResults = result.Select(p => new GetPricingQueryResult(p.Id, p.Name)).ToList();

			return ServiceResult<List<GetPricingQueryResult>>.Success(pricingResults);
		}
	}
}
