namespace CarBook.Aplication.Features.CQRS.Results.ContactResults;
	public record GetContactQueryResult(int Id,string Name,string Email,string Subject,string Message,DateTime Created);