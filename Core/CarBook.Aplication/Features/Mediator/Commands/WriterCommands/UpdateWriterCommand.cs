using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
	public record UpdateWriterCommand(int Id, string Name, string? ImageUrl, string Description):IRequest<ServiceResult>;