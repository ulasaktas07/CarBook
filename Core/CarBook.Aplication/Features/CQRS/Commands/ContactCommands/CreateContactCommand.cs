namespace CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
	public record CreateContactCommand(string Name, string Email, string Subject, string Message);
