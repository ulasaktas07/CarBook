namespace CarBook.Aplication.Features.Mediator.Results.CommentResults;
	public record GetCommentByIdQueryResult(int Id, string Name, string Description, int BlogID, DateTime Created);

