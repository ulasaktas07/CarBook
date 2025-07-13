using CarBook.Dto.CommentDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ICommentApiClient
	{
		Task<List<CommentDto>> GetCommentListByBlogIdAsync(int id);
		Task<CommentCountByBlogIdDto> GetCommentCountByBlogIdAsync(int id);
		Task<CreateCommentResult> SendCreateCommentAsync(CreateCommentRequest createCommentRequest);

	}
}
