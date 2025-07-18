using CarBook.Aplication.Features.Mediator.Queries.AppUserQueries;
using CarBook.Aplication.Features.Mediator.Results.AppUserResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System.Net;

namespace CarBook.Aplication.Features.Mediator.Handlers.AppUserHandlers
{
	public class GetCheckAppUserQueryHandler(IRepository<AppUser> appUserRepository, IRepository<AppRole> appRoleRepository)
		: IRequestHandler<GetCheckAppUserQuery, ServiceResult<GetCheckAppUserQueryResult>>
	{
		public async Task<ServiceResult<GetCheckAppUserQueryResult>> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
		{
			var user = await appUserRepository.GetByFilterAsync(x => x.UserName == request.UserName && x.Password == request.Password);
			if (user == null)
			{
				return ServiceResult<GetCheckAppUserQueryResult>.Fail("Kullanıcı bulunamadı.",HttpStatusCode.NotFound);
			}
			else
			{
				
				var result = new GetCheckAppUserQueryResult(user.Id,user.UserName,(await appRoleRepository
					.GetByFilterAsync(x => x.Id == user.AppRoleId))?.Name!,true
				);
				return ServiceResult<GetCheckAppUserQueryResult>.Success(result);
			}
		}
	}
}
