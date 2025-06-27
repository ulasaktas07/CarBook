
using CarBook.Aplication.Features.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Queries.CommentQueries;

public record GetCommentQuery:IRequest<ServiceResult<List<GetCommentQueryResult>>>;
