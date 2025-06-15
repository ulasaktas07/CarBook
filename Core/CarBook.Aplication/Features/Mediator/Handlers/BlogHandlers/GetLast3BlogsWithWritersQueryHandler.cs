using CarBook.Aplication.Features.CQRS.Results.CarResults;
using CarBook.Aplication.Features.Mediator.Queries.BlogQueries;
using CarBook.Aplication.Features.Mediator.Results.BlogResults;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.BlogHandlers
{
	public class GetLast3BlogsWithWritersQueryHandler(IBlogRepository repository)
		: IRequestHandler<GetLast3BlogsWithWritersQuery, ServiceResult<List<GetLast3BlogsWithWritersQueryResult>>>
	{
		public async Task<ServiceResult<List<GetLast3BlogsWithWritersQueryResult>>> Handle(GetLast3BlogsWithWritersQuery request, CancellationToken cancellationToken)
		{
			var blogs = await repository.GetBlogsLast3WithWriters();

			var result = blogs.Select(b => new GetLast3BlogsWithWritersQueryResult(b.Id,b.Title,b.WriterID,b.Writer.Name,
				b.CoverImageUrl,b.CategoryID)).ToList();
			return ServiceResult<List<GetLast3BlogsWithWritersQueryResult>>.Success(result);
		}
	}
}
