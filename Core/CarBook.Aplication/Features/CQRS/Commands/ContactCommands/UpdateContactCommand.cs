namespace CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
	public record UpdateContactCommand(int Id, string Name, string Email, string Subject, string Message);
