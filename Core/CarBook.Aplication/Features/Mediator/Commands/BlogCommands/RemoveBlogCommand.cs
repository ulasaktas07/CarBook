using MediatR;
namespace CarBook.Aplication.Features.Mediator.Commands.BlogCommands
{
	public record RemoveBlogCommand:IRequest<ServiceResult>
	{
		public int Id { get; init; }
		public RemoveBlogCommand(int id)
		{
			Id = id;
		}
	}
}
