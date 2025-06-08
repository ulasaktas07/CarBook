
using CarBook.Aplication.Features.CQRS.Results.ContactResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
	public class GetContactQueryHandler(IRepository<Contact> repository)
	{
		public async Task<ServiceResult<List<GetContactQueryResult>>> Handle()
		{
			var contacts = await repository.GetAllAsync();
			var result = contacts.Select(c => new GetContactQueryResult(c.Id, c.Name, c.Email,c.Subject,c.Message)).ToList();

			return ServiceResult<List<GetContactQueryResult>>.Success(result);
		}

	}
}
