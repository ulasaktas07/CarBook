using CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class UpdateBlogCommandHandler(IRepository<Blog> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateBlogCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
		{
			var blog = await repository.GetByIdAsync(request.Id);
			if (blog == null || blog.Id!=request.Id)
			{
				return ServiceResult.Fail("Blog bulunamadı",HttpStatusCode.NotFound);
			}
			blog.Title = request.Title;
			blog.WriterID = request.WriterID;
			blog.CoverImageUrl = request.CoverImageUrl;
			blog.CategoryID = request.CategoryID;
			repository.Update(blog);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
