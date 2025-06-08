namespace CarBook.Aplication.Features.CQRS.Results.ContactResults;
	public record GetContactByIdQueryResult(int Id, string Name, string Email, string Subject, string Message);
