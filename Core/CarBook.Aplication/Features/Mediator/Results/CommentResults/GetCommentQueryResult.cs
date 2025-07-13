namespace CarBook.Aplication.Features.Mediator.Results.CommentResults;
public record GetCommentQueryResult(int Id,string Name, string Description, string Email, int BlogID, DateTime Created);
