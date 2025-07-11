using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.ReservationDtos;

namespace CarBook.Persistence.Services
{
	public class ReservationService(IReservationApiClient ReservationApiClient, IMapper mapper) : IReservationService
	{
		public async Task<CreateReservationResult> CreateReservationAsync(CreateReservationRequest createReservationRequest)
		{
			var command = mapper.Map<CreateReservationCommand>(createReservationRequest);
			return await ReservationApiClient.SendCreateReservationAsync(createReservationRequest);
		}


	}
}
