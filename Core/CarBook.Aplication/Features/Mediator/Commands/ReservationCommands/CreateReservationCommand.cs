using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;

public record CreateReservationCommand(string Name,string Surname,string Email,string Phone,int PickUpLocationID
	,int DropOffLocationID, int CarID, int Age, int DriverLicenseYear, string? Description)
	: IRequest<ServiceResult<CreateResertationByIdCommand>>;
