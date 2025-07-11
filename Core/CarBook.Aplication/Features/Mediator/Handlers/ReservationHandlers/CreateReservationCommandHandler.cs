using CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.ReservationHandlers
{
	public class CreateReservationCommandHandler(IRepository<Reservation> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateReservationCommand, ServiceResult<CreateResertationByIdCommand>>
	{
		public async Task<ServiceResult<CreateResertationByIdCommand>> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
		{
			var reservation = new Reservation
			{
				Name = request.Name,
				Surname = request.Surname,
				Email = request.Email,
				Phone = request.Phone,
				PickUpLocationID = request.PickUpLocationID,
				DropOffLocationID = request.DropOffLocationID,
				Age = request.Age,
				CarID= request.CarID,
				DriverLicenseYear = request.DriverLicenseYear,
				Description = request.Description,
				Status="Rezervasyon Alındı"
			};
			await repository.CreateAsync(reservation);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateResertationByIdCommand>
				.SuccessAsCreated(new CreateResertationByIdCommand(reservation.Id),$"api/reservations/{reservation.Id}");
		}
	}
}
