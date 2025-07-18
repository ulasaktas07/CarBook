using CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Interfaces.ReviewInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ReviewHandlers
{
	public class RemoveReviewCommandHandler(IRepository<Review> repository,IUnitOfWork unitOfWork): IRequestHandler<RemoveReviewCommand, ServiceResult>
	{
	
		public async Task<ServiceResult> Handle(RemoveReviewCommand request, CancellationToken cancellationToken)
		{
			var review = await repository.GetByIdAsync(request.Id);
			if (review == null)
			{
				return ServiceResult.Fail("Yorum bulunamadı.", HttpStatusCode.NotFound);
			}
			 repository.Remove(review);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}

}
