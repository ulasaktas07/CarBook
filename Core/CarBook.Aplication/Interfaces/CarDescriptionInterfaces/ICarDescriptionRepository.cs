using CarBook.Domain.Entities;

namespace CarBook.Aplication.Interfaces.CarDescriptionInterfaces
{
	public interface ICarDescriptionRepository
	{
		Task<CarDescription> CarDescriptionGetByCarIdAsync(int carid);
	}
}
