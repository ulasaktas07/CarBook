namespace CarBook.Dto.AboutDtos;
public class AboutDto
{
	public int Id { get; set; }
	public string Title { get; set; } = default!;
	public string Description { get; set; } = default!;
	public string? ImageUrl { get; set; }
}


