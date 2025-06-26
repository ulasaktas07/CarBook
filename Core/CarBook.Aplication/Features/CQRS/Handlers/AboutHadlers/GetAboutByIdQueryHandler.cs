using CarBook.Aplication.Features.CQRS.Queries.AboutQueries;
using CarBook.Aplication.Features.CQRS.Results.AboutResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.AboutHadlers
{
	public class GetAboutByIdQueryHandler(IRepository<About> repository)
	{

		public async Task<ServiceResult<GetAboutByIdQueryResult>> Handle(GetAboutByIdQuery query)
		{
			var about = await repository.GetByIdAsync(query.Id);
			if (about is null) return ServiceResult<GetAboutByIdQueryResult>.Fail("About bulunamadı", HttpStatusCode.NotFound);

			var values=new GetAboutByIdQueryResult(about.Id, about.Title, about.Description, about.ImageUrl);
			return ServiceResult< GetAboutByIdQueryResult>.Success(values)!;
		}
	}
}
