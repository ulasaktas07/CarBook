using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Dto.CarDtos;

namespace CarBook.Aplication.Services
{
	public class CarService(ICarApiClient carApiClient, IMapper mapper) : ICarService
	{
		public async Task<bool> CreateCarAsync(CreateCarRequest request)
		{
			var command = mapper.Map<CreateCarCommand>(request);
			return await carApiClient.SendCreateCarAsync(request);
		}

		public async Task<bool> UpdateCarAsync(ResultCarDto result)
		{
			var command = mapper.Map<UpdateCarCommand>(result);
			return await carApiClient.SendUpdateCarAsync(result);

		}
	}
}
