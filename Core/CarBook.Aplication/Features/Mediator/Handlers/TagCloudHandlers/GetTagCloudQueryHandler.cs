
using CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;
using CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
	public class GetTagCloudQueryHandler(IRepository<TagCloud> repository)
		: IRequestHandler<GetTagCloudQuery, ServiceResult<List<GetTagCloudQueryResult>>>
	{
		public async Task<ServiceResult<List<GetTagCloudQueryResult>>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
		{
			var tagClouds = await repository.GetAllAsync();

			var result = tagClouds.Select(tc => new GetTagCloudQueryResult(tc.Id,tc.Title,tc.BlogID)).ToList();

			return ServiceResult<List<GetTagCloudQueryResult>>.Success(result);
		}
	}
}
