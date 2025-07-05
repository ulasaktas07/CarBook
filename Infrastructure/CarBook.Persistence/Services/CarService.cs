using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Dto.CarDtos;

namespace CarBook.Persistence.Services
{
	public class CarService(ICarApiClient carApiClient, IMapper mapper) : ICarService
	{
		public async Task<bool> CreateCarAsync(CreateCarRequest request)
		{
			var command = mapper.Map<CreateCarCommand>(request);
			return await carApiClient.SendCreateCarAsync(request);
		}

		public async Task<bool> UpdateCarAsync(UpdateCarRequest result)
		{
			var command = mapper.Map<UpdateCarCommand>(result);
			return await carApiClient.SendUpdateCarAsync(result);

		}
	}
}
