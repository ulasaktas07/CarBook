using CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;
using CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
	public class GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
		: IRequestHandler<GetTagCloudByIdQuery, ServiceResult<GetTagCloudByIdQueryResult>>
	{
		public async Task<ServiceResult<GetTagCloudByIdQueryResult>> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
		{
			var tagCloud = await repository.GetByIdAsync(request.Id);
			if (tagCloud == null)
			{
				return ServiceResult<GetTagCloudByIdQueryResult>.Fail("Tag cloud not found.",HttpStatusCode.NotFound);
			}
			var result = new GetTagCloudByIdQueryResult(tagCloud.Id, tagCloud.Title, tagCloud.BlogID);
			return ServiceResult<GetTagCloudByIdQueryResult>.Success(result);
		}
	}

}
