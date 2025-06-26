
using CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Aplication.Features.Mediator.Handlers.TestimonialHandlers
{
	public class CreateTestimonialCommandHandler(IRepository<Testimonial> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateTestimonialCommand, ServiceResult<CreateTestimonialByIdCommand>>
	{
		public async Task<ServiceResult<CreateTestimonialByIdCommand>> Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
		{
			var testimonial = new Testimonial
			{
				Title = request.Title,
				Name = request.Name,
				ImageUrl = request.ImageUrl,
				Comment = request.Comment
			};
			await repository.CreateAsync(testimonial);
			await unitOfWork.SaveChangesAsync();

			return ServiceResult<CreateTestimonialByIdCommand>.
				SuccessAsCreated(new CreateTestimonialByIdCommand(testimonial.Id), $"api/testimonial/{testimonial.Id}");

		}
	}

}
