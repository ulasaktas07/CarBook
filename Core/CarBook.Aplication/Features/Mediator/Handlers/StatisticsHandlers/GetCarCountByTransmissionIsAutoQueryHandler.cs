
using BlogBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetCarCountByTransmissionIsAutoQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetCarCountByTransmissionIsAutoQuery, ServiceResult<GetCarCountByTransmissionIsAutoQueryResult>>
	{
		public async Task<ServiceResult<GetCarCountByTransmissionIsAutoQueryResult>> Handle(GetCarCountByTransmissionIsAutoQuery request, CancellationToken cancellationToken)
		{
			var  values = await repository.GetCarCountByTransmissionIsAutoAsync();

			return ServiceResult<GetCarCountByTransmissionIsAutoQueryResult>.Success(new GetCarCountByTransmissionIsAutoQueryResult(values));

		}
	
	}
}
