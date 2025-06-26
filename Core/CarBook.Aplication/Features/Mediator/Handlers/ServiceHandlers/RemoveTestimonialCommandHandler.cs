using CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
	public class RemoveTestimonialCommandHandler(IRepository<Testimonial> repository,IUnitOfWork unitOfWork)
		: IRequestHandler<RemoveTestimonialCommand, ServiceResult>
	{
		public async Task<ServiceResult> Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
		{
			var testimonial = await repository.GetByIdAsync(request.Id);
			if (testimonial == null)
			{
				return ServiceResult.Fail("Testimonial not found.",HttpStatusCode.NotFound);
			}
			 repository.Remove(testimonial);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult.Success(HttpStatusCode.NoContent);
		}
	}
}
