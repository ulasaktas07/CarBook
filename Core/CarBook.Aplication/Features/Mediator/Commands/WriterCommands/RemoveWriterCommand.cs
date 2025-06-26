using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.WriterCommands
{
	public record RemoveWriterCommand:IRequest<ServiceResult>
	{
		public int Id { get; set; }
		public RemoveWriterCommand(int id)
		{
			Id = id;
		}
	}
}
