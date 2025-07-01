using AutoMapper;
using CarBook.Aplication.Features.CQRS.Commands.CategoryCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.CategoryDtos;

namespace CarBook.Persistence.Services
{
	public class CategoryService(ICategoryApiClient categoryApiClient, IMapper mapper) : ICategoryService
	{
		public async Task<CreateCategoryResult> CreateCategoryAsync(CreateCategoryRequest request)
		{
			var command = mapper.Map<CreateCategoryCommand>(request);
			return await categoryApiClient.SendCreateCategoryAsync(request);
		}

		public async Task<UpdateCategoryRequest> UpdateCategoryAsync(UpdateCategoryRequest request)
		{
			var command = mapper.Map<UpdateCategoryCommand>(request);
			return await categoryApiClient.SendUpdateCategoryAsync(request);
		}
	}
}
