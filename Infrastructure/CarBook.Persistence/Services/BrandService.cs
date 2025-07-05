using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.BrandDtos;

namespace CarBook.Persistence.Services
{
	public class BrandService(IBrandApiClient brandApiClient,IMapper mapper) : IBrandService
	{
		public async Task<bool> CreateBrandAsync(CreateBrandRequest createBrandRequest)
		{ 
			var command = mapper.Map<CreateBrandCommand>(createBrandRequest);
			return await brandApiClient.SendCreateBrandAsync(createBrandRequest);
		}

		public async Task<bool> UpdateBrandAsync(UpdateBrandRequest updateBrandRequest)
		{
			var command = mapper.Map<UpdateBrandCommand>(updateBrandRequest);
			return await brandApiClient.SendUpdateBrandAsync(updateBrandRequest);
		}
	}
}
