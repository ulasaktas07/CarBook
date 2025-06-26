using CarBook.Aplication.Interfaces.TagCloudInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence;
using Microsoft.EntityFrameworkCore;

public class TagCloudRepository : ITagCloudRepository
{
	private readonly CarBookContext _context;

	public TagCloudRepository(CarBookContext context)
	{
		_context = context;
	}

	public async Task<List<TagCloud>> GetTagCloudsByBlogIdAsync(int id)
	{
		return await _context.TagClouds
			.Where(tc => tc.BlogID == id)
			.ToListAsync();
	}
}
