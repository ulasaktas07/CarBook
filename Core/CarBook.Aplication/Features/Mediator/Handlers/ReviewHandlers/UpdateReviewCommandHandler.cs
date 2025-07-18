using CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ReviewHandlers
{
	public class UpdateReviewCommandHandler(IRepository<Review> repository,IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateReviewCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
		{
			var review = await repository.GetByIdAsync(request.Id);
			if (review is null)
			{
				return ServiceResult.Fail("Yorum bulunamadı",HttpStatusCode.NotFound);
			}
			review.CustomerName = request.CustomerName;
			review.CustomerImage = request.CustomerImage;
			review.Comment = request.Comment;
			review.RaytingValue = request.RaytingValue;
			repository.Update(review);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}
}
