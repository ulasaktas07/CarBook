using CarBook.Aplication.Features.CQRS.Commands.CategoryCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CategoryHandlers
{
	public class CreateCategoryCommandHandler(IRepository<Category> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult<CreateCategoryByIdCommand>> Handle(CreateCategoryCommand command)
		{
			var category = new Category
			{
				Name = command.Name
			};
			var anyCategory = await repository.AnyAsync(x => x.Name == command.Name);
			if (anyCategory) return ServiceResult<CreateCategoryByIdCommand>.Fail("Bu isimde bir kategori zaten var.", HttpStatusCode.Conflict);
			
			await repository.CreateAsync(category);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateCategoryByIdCommand>.SuccessAsCreated(new CreateCategoryByIdCommand(category.Id),$"api/categories/{category.Id}");
		}
	}
}
