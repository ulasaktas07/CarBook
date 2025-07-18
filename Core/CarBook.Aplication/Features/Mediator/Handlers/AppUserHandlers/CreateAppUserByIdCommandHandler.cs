using CarBook.Aplication.Enums;
using CarBook.Aplication.Features.Mediator.Commands.AppUserCommands;
using CarBook.Aplication.Features.Mediator.Commands.BlogCommands;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;
using System.Reflection.Metadata;

namespace CarBook.Aplication.Features.Mediator.Handlers.AppUserHandlers
{
	public class CreateAppUserByIdCommandHandler(IRepository<AppUser> repository, IUnitOfWork unitOfWork)
		: IRequestHandler<CreateAppUserCommand, ServiceResult<CreateAppUserByIdCommand>>
	{
		public async Task<ServiceResult<CreateAppUserByIdCommand>> Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
		{
			var result = new ServiceResult<CreateAppUserByIdCommand>();
			var appUser = new AppUser
			{
				Password = request.Password,
				UserName = request.UserName,
				Name = request.Name,
				Surname = request.Surname,
				Email = request.Email,
				AppRoleId = (int)RolesType.Member // Varsayılan rol ID'si, ihtiyaca göre değiştirilebilir
			};
			var any = await repository.AnyAsync(x => x.UserName == request.UserName);
			var anyPassword = await repository.AnyAsync(x => x.Password == request.Password);

			if (any || anyPassword)
				return ServiceResult<CreateAppUserByIdCommand>
					.Fail("Kullanıcı adı veya şifre zaten kullanılmış", HttpStatusCode.Conflict);



			await repository.CreateAsync(appUser);
			await unitOfWork.SaveChangesAsync();
			return ServiceResult<CreateAppUserByIdCommand>.SuccessAsCreated(new CreateAppUserByIdCommand(appUser.Id), $"api/registers/{appUser.Id}");


		}
	}

}
