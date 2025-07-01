namespace CarBook.Dto.CategoryDtos
{
	public class UpdateCategoryRequest
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
	}
}
