using CarBook.Aplication.Features.Queries.AboutQueries;
using CarBook.Aplication.Features.Results.AboutResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.Handlers.AboutHadlers
{
	public class GetAboutByIdQueryHandler(IRepository<About> repository)
	{

		public async Task<ServiceResult<GetAboutByIdQueryResult?>> Handle(GetAboutByIdQuery query)
		{
			var about = await repository.GetByIdAsync(query.Id);
			if (about is null) return ServiceResult<GetAboutByIdQueryResult?>.Fail("About bulunamadı", HttpStatusCode.NotFound);

			var values=new GetAboutByIdQueryResult(about.Id, about.Title, about.Description, about.ImageUrl);
			return ServiceResult< GetAboutByIdQueryResult>.Success(values)!;
		}
	}
}
