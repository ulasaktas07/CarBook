using CarBook.Aplication.Features.CQRS.Commands.CategoryCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CategoryHandlers
{
	public class UpdateCategoryCommandHandler(IRepository<Category> repository, IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(UpdateCategoryCommand command)
		{
			var category = await repository.GetByIdAsync(command.Id);
			if (category is null) return ServiceResult.Fail("Kategori bulunamadı", HttpStatusCode.NotFound);

			var anyCategory = await repository.AnyAsync(c => c.Name == command.Name && c.Id != command.Id);
			if (anyCategory) return ServiceResult.Fail("Bu isimde bir kategori zaten var", HttpStatusCode.Conflict);

			category.Name = command.Name;
			repository.Update(category);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
