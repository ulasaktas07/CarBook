using CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using CarBook.Aplication.Interfaces.BlogInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class GetBlogByWriterIdQueryHandler(IBlogRepository blogRepository):
		IRequestHandler<GetBlogByWriterIdQuery, ServiceResult<GetBlogByWriterIdQueryResult>>
	{
		public async Task<ServiceResult<GetBlogByWriterIdQueryResult>> Handle(GetBlogByWriterIdQuery request, CancellationToken cancellationToken)
		{
			var blog = await blogRepository.GetWriterByBlogId(request.Id);
			if (blog == null)
			{
				return ServiceResult<GetBlogByWriterIdQueryResult>.Fail("Blog not found.",HttpStatusCode.NotFound);
			}
			var result = new GetBlogByWriterIdQueryResult(blog.Id,blog.Writer.Name,blog.Writer.Description,blog.Writer.ImageUrl,
				blog.WriterID);
			return ServiceResult<GetBlogByWriterIdQueryResult>.Success(result);
		}
	}

}
