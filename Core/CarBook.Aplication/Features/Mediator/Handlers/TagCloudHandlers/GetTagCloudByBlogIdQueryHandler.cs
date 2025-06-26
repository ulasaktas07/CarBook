using CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;
using CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using CarBook.Aplication.Interfaces.TagCloudInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
	public class GetTagCloudByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository)
		: IRequestHandler<GetTagCloudByBlogIdQuery, ServiceResult<List<GetTagCloudByBlogIdQueryResult>>>
	{
		public async Task<ServiceResult<List<GetTagCloudByBlogIdQueryResult>>> Handle(
		   GetTagCloudByBlogIdQuery request,
		   CancellationToken cancellationToken)
		{
			var tagClouds =await tagCloudRepository.GetTagCloudsByBlogIdAsync(request.Id);
			if (tagClouds == null)
			{
				return ServiceResult<List<GetTagCloudByBlogIdQueryResult>>.Fail("Tag cloud not found.", HttpStatusCode.NotFound);
			}

			var result = tagClouds.Select(tc => new GetTagCloudByBlogIdQueryResult(tc.Id, tc.Title, tc.BlogID)).ToList();


			return ServiceResult<List<GetTagCloudByBlogIdQueryResult>>.Success(result);
		}
	}
}