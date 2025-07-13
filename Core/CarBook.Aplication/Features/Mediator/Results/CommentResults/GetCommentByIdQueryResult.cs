namespace CarBook.Aplication.Features.Mediator.Results.CommentResults;
	public record GetCommentByIdQueryResult(int Id, string Name, string Description, string Email, int BlogID, DateTime Created);

