using CarBook.Aplication.Features.Mediator.Queries.ReviewQueries;
using CarBook.Aplication.Features.Mediator.Results.ReviewResults;
using CarBook.Aplication.Interfaces.ReviewInterfaces;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ReviewHandlers
{
	public class GetReviewByCarIdQueryHandler(IReviewRepository repository)
		: IRequestHandler<GetReviewByCarIdQuery, ServiceResult<List<GetReviewByCarIdQueryResult>>>
	{
		public async Task<ServiceResult<List<GetReviewByCarIdQueryResult>>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
		{
			var reviews = await repository.GetReviewsByCarIdAsync(request.Id);
			if (reviews == null || !reviews.Any())
			{
				return ServiceResult<List<GetReviewByCarIdQueryResult>>
					.Fail("Belirtilen araç kimliği için herhangi bir yorum bulunamadı.",HttpStatusCode.NotFound);
			}
			
			var result = reviews.Select(review => new GetReviewByCarIdQueryResult(review.Id,review.CustomerName,review.CustomerImage
				,review.Comment,review.RaytingValue,review.CarID,review.Created)).ToList();
			return ServiceResult<List<GetReviewByCarIdQueryResult>>.Success(result);
		}
	}
}
