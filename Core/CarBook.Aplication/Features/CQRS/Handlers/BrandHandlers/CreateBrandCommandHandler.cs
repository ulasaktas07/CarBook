using CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
	public class CreateBrandCommandHandler(IRepository<Brand> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult<CreateBrandByIdCommand>> Handle(CreateBrandCommand command)
		{
			var anyBrand = await repository.AnyAsync(b => b.Name == command.Name);
			if (anyBrand) return ServiceResult<CreateBrandByIdCommand>.Fail("Bu marka zaten mevcut", HttpStatusCode.Conflict);

			var brand = new Brand
			{
				Name = command.Name
			};
			await repository.CreateAsync(brand);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateBrandByIdCommand>.SuccessAsCreated(new CreateBrandByIdCommand(brand.Id),$"api/brands/{brand.Id}");
		}
	}
}
