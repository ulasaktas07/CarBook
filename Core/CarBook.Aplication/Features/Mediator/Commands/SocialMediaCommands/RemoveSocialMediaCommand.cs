using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommands
{
	public record RemoveSocialMediaCommand:IRequest<ServiceResult>
	{
		public int Id { get; init; }
		public RemoveSocialMediaCommand(int id)
		{
			Id = id;
		}
	}
}
