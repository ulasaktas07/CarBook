
using CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class CreateBlogCommandHandler(IRepository<Blog> repository, IUnitOfWork unitOfWork) :
		IRequestHandler<CreateBlogCommand, ServiceResult<CreateBlogByIdCommand>>
	{
		public async Task<ServiceResult<CreateBlogByIdCommand>> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
		{
			var blog = new Blog
			{
				Title = request.Title,
				WriterID = request.WriterID,
				CoverImageUrl= request.CoverImageUrl,
				CategoryID = request.CategoryID
				
			};
			var any = await repository.AnyAsync(x => x.Title == request.Title && x.WriterID == request.WriterID);
			if (any)
			{
				return ServiceResult<CreateBlogByIdCommand>.Fail("Bu başlıkla aynı yazı zaten var", System.Net.HttpStatusCode.Conflict);
			}
			await repository.CreateAsync(blog);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateBlogByIdCommand>.SuccessAsCreated(new CreateBlogByIdCommand(blog.Id),$"api/blogs/{blog.Id}");
		}
	}
}


