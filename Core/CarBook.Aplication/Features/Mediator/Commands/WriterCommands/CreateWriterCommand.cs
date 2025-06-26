using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
public record CreateWriterCommand(string Name, string? ImageUrl, string Description):IRequest<ServiceResult<CreateWriterByIdCommand>>;