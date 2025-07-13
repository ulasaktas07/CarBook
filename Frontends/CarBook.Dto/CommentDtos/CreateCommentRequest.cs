namespace CarBook.Dto.CommentDtos
{
	public class CreateCommentRequest
	{
		public string Name { get; set; } = default!;
		public string Email { get; set; } = default!;

		public string Description { get; set; } = default!;
		public int BlogID { get; set; }
	}
}
