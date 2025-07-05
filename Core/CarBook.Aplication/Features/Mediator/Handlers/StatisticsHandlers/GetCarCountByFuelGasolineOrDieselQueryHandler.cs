using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetCarCountByFuelGasolineOrDieselQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetCarCountByFuelGasolineOrDieselQuery, ServiceResult<GetCarCountByFuelGasolineOrDieselQueryResult>>
	{
		public async Task<ServiceResult<GetCarCountByFuelGasolineOrDieselQueryResult>> Handle(GetCarCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
		{
			var getCarCountByFuelGasolineOrDiesel = await repository.GetCarCountByFuelGasolineOrDieselAsync();

			return ServiceResult<GetCarCountByFuelGasolineOrDieselQueryResult>.Success(new GetCarCountByFuelGasolineOrDieselQueryResult(getCarCountByFuelGasolineOrDiesel));

		}
	
	}
}
