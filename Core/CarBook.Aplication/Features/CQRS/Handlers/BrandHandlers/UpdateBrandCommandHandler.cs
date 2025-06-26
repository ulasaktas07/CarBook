using CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
	public class UpdateBrandCommandHandler(IRepository<Brand> repository, IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(UpdateBrandCommand command)
		{
			var brand = await repository.GetByIdAsync(command.Id);
			if (brand == null) return ServiceResult.Fail("Marka bulunamadı", HttpStatusCode.NotFound);

			var anyBrand = await repository.AnyAsync(b => b.Name == command.Name && b.Id != command.Id);
			if (anyBrand) return ServiceResult.Fail("Bu marka zaten mevcut", HttpStatusCode.Conflict);

			brand.Name = command.Name;
			repository.Update(brand);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
