using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.AppUserCommands;

public record CreateAppUserCommand(string UserName,string Password, string Name, string Surname, string Email)
	: IRequest<ServiceResult<CreateAppUserByIdCommand>>;
