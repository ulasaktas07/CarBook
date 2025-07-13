using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.CommentDtos;

namespace CarBook.Persistence.Services
{
	public class CommentService(ICommentApiClient CommentApiClient, IMapper mapper) : ICommentService
	{
		public async Task<CreateCommentResult> CreateCommentAsync(CreateCommentRequest createCommentRequest)
		{
			var command = mapper.Map<CreateCommentCommad>(createCommentRequest);
			return await CommentApiClient.SendCreateCommentAsync(createCommentRequest);
		}

	}
}
