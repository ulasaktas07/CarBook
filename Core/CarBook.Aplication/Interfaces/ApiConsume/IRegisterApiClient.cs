using CarBook.Dto.RegisterDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IRegisterApiClient
	{
		Task<CreateRegisterResult> SendCreateRegisterAsync(CreateRegisterRequest createRegisterRequest);

	}
}
