using CarBook.Aplication.Features.CQRS.Results.AboutResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
namespace CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers
{
	public class GetAboutQueryHandler(IRepository<About> repository)
	{

		public async Task<ServiceResult<List<GetAboutQueryResult>>> Handle()
		{
			var abouts = await repository.GetAllAsync();
			var values= abouts.Select(a => new GetAboutQueryResult(a.Id, a.Title, a.Description, a.ImageUrl)).ToList();
			return ServiceResult<List<GetAboutQueryResult>>.Success(values);
		}
	}
}
