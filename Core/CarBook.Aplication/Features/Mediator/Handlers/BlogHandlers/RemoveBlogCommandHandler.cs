
using CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class RemoveBlogCommandHandler(IRepository<Blog> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveBlogCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
		{
			var blog = await repository.GetByIdAsync(request.Id);
			if (blog == null)
			{
				return ServiceResult.Fail("Blog bulunamadı.",HttpStatusCode.NotFound);
			}
			repository.Remove(blog);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
