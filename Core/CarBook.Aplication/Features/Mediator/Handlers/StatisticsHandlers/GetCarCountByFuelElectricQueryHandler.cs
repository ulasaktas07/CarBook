using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetCarCountByFuelElectricQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetCarCountByFuelElectricQuery, ServiceResult<GetCarCountByFuelElectricQueryResult>>
	{
		public async Task<ServiceResult<GetCarCountByFuelElectricQueryResult>> Handle(GetCarCountByFuelElectricQuery request, CancellationToken cancellationToken)
		{
			var getCarCountByFuelElectric = await repository.GetCarCountByFuelElectricAsync();

			return ServiceResult<GetCarCountByFuelElectricQueryResult>.Success(new GetCarCountByFuelElectricQueryResult(getCarCountByFuelElectric));

		}
	
	}
}
