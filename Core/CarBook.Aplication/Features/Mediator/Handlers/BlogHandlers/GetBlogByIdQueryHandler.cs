using CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class GetBlogByIdQueryHandler(IRepository<Blog> repository) :
		IRequestHandler<GetBlogByIdQuery, ServiceResult<GetBlogByIdQueryResult>>
	{
		public async Task<ServiceResult<GetBlogByIdQueryResult>> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
		{
			var blog = await repository.GetByIdAsync(request.Id);
			if (blog == null)
			{
				return ServiceResult<GetBlogByIdQueryResult>.Fail("Blog bulunamadı",HttpStatusCode.NotFound);
			}
			var result = new GetBlogByIdQueryResult(blog.Id, blog.Title, blog.WriterID, blog.CoverImageUrl, blog.CategoryID,blog.Description);
			return ServiceResult<GetBlogByIdQueryResult>.Success(result);
		}
	}
}
