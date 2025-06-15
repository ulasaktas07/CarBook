
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
	public record CreateBlogCommand(string Title, int WriterID, string CoverImageUrl, int CategoryID)
	:IRequest<ServiceResult<CreateBlogByIdCommand>>;