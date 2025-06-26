using CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class GetBlogQueryHandler(IRepository<Blog> repository) : IRequestHandler<GetBlogQuery, ServiceResult<List<GetBlogQueryResult>>>
	{
		public async Task<ServiceResult<List<GetBlogQueryResult>>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
		{
			var blogs = await repository.GetAllAsync();

			var result = blogs.Select(blog => new GetBlogQueryResult(blog.Id,blog.Title,blog.WriterID,
				blog.CoverImageUrl,blog.CategoryID,blog.Description)).ToList();
			return ServiceResult<List<GetBlogQueryResult>>.Success(result);
		}
	}
}
