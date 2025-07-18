using CarBook.Dto.RegisterDtos;

namespace CarBook.Aplication.Services
{
	public interface IRegisterService
	{
		Task<CreateRegisterResult> CreateRegisterAsync(CreateRegisterRequest createRegisterRequest);

	}
}
