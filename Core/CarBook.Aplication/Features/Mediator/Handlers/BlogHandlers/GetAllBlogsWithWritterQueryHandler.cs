using CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using CarBook.Aplication.Interfaces.BlogInterfaces;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class GetAllBlogsWithWritterQueryHandler(IBlogRepository blogRepository) :
		IRequestHandler<GetAllBlogsWithWritterQuery, ServiceResult<List<GetAllBlogsWithWriterQueryResult>>>
	{
		public async Task<ServiceResult<List<GetAllBlogsWithWriterQueryResult>>> Handle(GetAllBlogsWithWritterQuery request, CancellationToken cancellationToken)
		{
			var blogs = await blogRepository.GetBlogsWithWriters();

			var result = blogs.Select(blog => new GetAllBlogsWithWriterQueryResult(blog.Id,blog.Title,blog.Writer.Name,
				blog.Writer.Description,blog.Writer.ImageUrl,blog.Category.Name,blog.WriterID,blog.CoverImageUrl,
				blog.CategoryID,blog.Created,blog.Description
				)).ToList();
			return ServiceResult<List<GetAllBlogsWithWriterQueryResult>>.Success(result);
		}
	}
}
