using CarBook.Aplication.Features.CQRS.Commands.CategoryCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CategoryHandlers
{
	public class RemoveCategoryCommandHandler(IRepository<Category> repository, IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(RemoveCategoryCommand command)
		{
			var category = await repository.GetByIdAsync(command.Id);
			repository.Remove(category!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
