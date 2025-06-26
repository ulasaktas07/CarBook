using CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
	public class RemoveBrandCommandHandler(IRepository<Brand> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(RemoveBrandCommand request)
		{
			var brand = await repository.GetByIdAsync(request.Id);

			repository.Remove(brand!);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
