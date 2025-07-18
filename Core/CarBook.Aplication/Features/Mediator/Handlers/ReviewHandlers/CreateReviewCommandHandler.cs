using CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;
using CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.ReviewHandlers
{
	public class CreateReviewCommandHandler(IRepository<Review> repository,IUnitOfWork unitOfWork)
		: IRequestHandler<CreateReviewCommand, ServiceResult<CreateReviewByIdCommand>>
	{
		public async Task<ServiceResult<CreateReviewByIdCommand>> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
		{
			var review = new Review
			{
			CarID = request.CarID,
			CustomerName = request.CustomerName,
			CustomerImage = request.CustomerImage,
			Comment = request.Comment,
			RaytingValue = request.RaytingValue
			};
			await repository.CreateAsync(review);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateReviewByIdCommand>
						.SuccessAsCreated(new CreateReviewByIdCommand(review.Id), $"api/reviews/{review.Id}");
		}
	}
}
