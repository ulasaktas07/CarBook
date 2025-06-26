namespace CarBook.Dto.CategoryDtos
{
	public class CategoryDto : ApiResponse<CategoryDto>
	{
		public int Id { get; set; }
		public string Name { get; set; } = default!;
	}
}
