using CarBook.Dto.CommentDtos;

namespace CarBook.Aplication.Services
{
	public interface ICommentService
	{
		Task<CreateCommentResult> CreateCommentAsync(CreateCommentRequest createCommentRequest);

	}
}
