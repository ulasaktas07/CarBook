namespace CarBook.Dto.CommentDtos
{
	public class CommentDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
		public string Description { get; set; } = default!;
		public int BlogID { get; set; }
		public DateTime Created { get; set; }
	}
}
