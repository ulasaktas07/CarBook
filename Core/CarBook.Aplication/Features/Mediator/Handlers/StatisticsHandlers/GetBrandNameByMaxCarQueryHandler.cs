using BrandBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetBrandNameByMaxCarQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetBrandNameByMaxCarQuery, ServiceResult<GetBrandNameByMaxCarQueryResult>>
	{
		public async Task<ServiceResult<GetBrandNameByMaxCarQueryResult>> Handle(GetBrandNameByMaxCarQuery request, CancellationToken cancellationToken)
		{
			var getBrandNameMaxCar = await repository.GetBrandNameByMaxCarAsync();

			return ServiceResult<GetBrandNameByMaxCarQueryResult>.Success(new GetBrandNameByMaxCarQueryResult(getBrandNameMaxCar!));

		}
	}
}
