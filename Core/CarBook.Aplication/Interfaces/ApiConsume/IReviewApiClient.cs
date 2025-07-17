using CarBook.Dto.ReviewDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IReviewApiClient
	{
		Task<List<ReviewByCarIdDto>> GetReviewByCarIdAsync(int id);
	}
}
