using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces.ReviewInterfaces
{
	public interface IReviewRepository
	{
		Task<List<Review>> GetReviewsByCarIdAsync(int carId);

	}
}
