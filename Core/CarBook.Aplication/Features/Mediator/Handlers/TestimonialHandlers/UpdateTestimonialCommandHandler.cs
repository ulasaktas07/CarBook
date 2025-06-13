using CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.TestimonialHandlers
{
	public class UpdateTestimonialCommandHandler(IRepository<Testimonial> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<UpdateTestimonialCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
		{
			var testimonial = await repository.GetByIdAsync(request.Id);
			if (testimonial == null || testimonial.Id != request.Id)
				return ServiceResult.Fail("Testimonial bulunamadı", HttpStatusCode.NotFound);

			testimonial.Name = request.Name;
			testimonial.Title = request.Title;
			testimonial.Comment = request.Comment;
			testimonial.ImageUrl = request.ImageUrl;
			repository.Update(testimonial);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success();
		}
	}

}
