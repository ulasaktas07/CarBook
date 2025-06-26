using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
	public class CreateCarCommandHandler(IRepository<Car> repository,IUnitOfWork unitOfWork)
	{
		public async Task<ServiceResult<CreateCarByIdCommand>> Handle(CreateCarCommand command)
		{
			var car = new Car
			{
				BrandID = command.BrandID,
				Model = command.Model,
				CoverImageUrl = command.CoverImageUrl,
				Km = command.Km,
				Seat = command.Seat,
				Lunggage = command.Lunggage,
				Fuel = command.Fuel,
				BigImageUrl = command.BigImageUrl,
				Transmission = command.Transmission
			};
		
			await repository.CreateAsync(car);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateCarByIdCommand>.SuccessAsCreated(new CreateCarByIdCommand(car.Id),$"api/cars/{car.Id}");
		}
	}
}
