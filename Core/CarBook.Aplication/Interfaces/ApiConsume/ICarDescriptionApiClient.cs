using CarBook.Dto.CarDescriptionDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface ICarDescriptionApiClient
	{
		Task<CarDescriptionByCarIdDto> CarDescriptionByCarIdAsync(int id);
	}
}
