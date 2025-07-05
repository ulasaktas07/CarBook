using CarBook.Aplication;
using CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using CarBook.Aplication.Interfaces.StatisticsInterfaces;
using WriterBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using MediatR;

namespace WriterBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
	public class GetWriterCountQueryHandler(IStatisticsRepository repository) :
		IRequestHandler<GetWriterCountQuery, ServiceResult<GetWriterCountQueryResult>>
	{
		public async Task<ServiceResult<GetWriterCountQueryResult>> Handle(GetWriterCountQuery request, CancellationToken cancellationToken)
		{
			var WriterCount = await repository.GetWriterCountAsync();

			return ServiceResult<GetWriterCountQueryResult>.Success(new GetWriterCountQueryResult(WriterCount));

		}
	}
}
