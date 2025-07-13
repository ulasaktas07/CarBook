namespace CarBook.Dto.CommentDtos
{
	public class CreateCommentResult
	{
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public int BlogID { get; set; }
	}
}
