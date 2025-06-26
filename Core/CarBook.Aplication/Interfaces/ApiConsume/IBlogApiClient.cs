using CarBook.Dto.BlogDtos;
using CarBook.Dto.WriterDtos;
namespace CarBook.Aplication.Interfaces
{
	public interface IBlogApiClient
	{
		Task<List<Last3BlogsWithWriterDto>> GetLast3BlogsWithWriterAsync();
		Task<List<BlogWithWriterDto>> GetAllBlogsWithWriterAsync();
		Task<BlogByIdDto> GetBlogByIdAsync(int id);

		Task<WriterByBlogWriterDto> GetWriterByBlogIdAsync(int id);
	}
}
