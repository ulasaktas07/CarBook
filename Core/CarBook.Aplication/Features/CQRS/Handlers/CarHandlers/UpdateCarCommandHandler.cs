using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class UpdateCarCommandHandler(IRepository<Car> repository, IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult> Handle(UpdateCarCommand command)
		{
			var car = await repository.GetByIdAsync(command.Id);
			if (car == null) return ServiceResult.Fail("Araba bulunamadı");
			car.BrandID = command.BrandID;
			car.Model = command.Model;
			car.CoverImageUrl = command.CoverImageUrl;
			car.Km = command.Km;
			car.Seat = command.Seat;
			car.Lunggage = command.Lunggage;
			car.Fuel = command.Fuel;
			car.BigImageUrl = command.BigImageUrl;
			car.Transmission = command.Transmission;
			 repository.Update(car);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
