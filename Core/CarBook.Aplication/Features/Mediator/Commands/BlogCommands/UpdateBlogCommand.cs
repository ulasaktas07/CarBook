using MediatR;

namespace CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
	public record UpdateBlogCommand(int Id, string Title, int WriterID, string CoverImageUrl, int CategoryID)
		:IRequest<ServiceResult>;