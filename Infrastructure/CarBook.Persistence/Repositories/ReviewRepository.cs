using CarBook.Aplication.Interfaces.ReviewInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
	public class ReviewRepository(CarBookContext context) : IReviewRepository
	{
		public async Task<List<Review>> GetReviewsByCarIdAsync(int carId)
			=> await context.Reviews.Where(r => r.CarID == carId).ToListAsync();
	}
}
