using CarBook.Aplication.Features.Mediator.Queries.PricingQueries;
using CarBook.Aplication.Features.Mediator.Results.PricingResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.PricingHandlers
{
	public class GetPricingByIdQueryHandler(IRepository<Pricing> repository) :
		IRequestHandler<GetPricingByIdQuery, ServiceResult<GetPricingByIdQueryResult>>
	{
		public async Task<ServiceResult<GetPricingByIdQueryResult>> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
		{
			var pricing = await repository.GetByIdAsync(request.Id);
			if (pricing == null||pricing.Id!=request.Id)
			{
				return ServiceResult<GetPricingByIdQueryResult>.Fail("Fiyatlandırma bulunamadı", HttpStatusCode.NotFound);
			}
			var result = new GetPricingByIdQueryResult(pricing.Id, pricing.Name);
			return ServiceResult<GetPricingByIdQueryResult>.Success(result);
		}
	}

}