namespace CarBook.Aplication.Features.Mediator.Results.CommentResults;
public record GetCommentsByBlogIdQueryResult(int Id, string Name, string Description, int BlogID, DateTime Created);
