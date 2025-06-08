using CarBook.Aplication.Features.CQRS.Queries.ContactQueries;
using CarBook.Aplication.Features.CQRS.Results.ContactResults;
using CarBook.Aplication.Interfaces;
using CarBook.Domain.Entities;
using System.Net;

namespace CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
	public class GetContactByIdQueryHandler(IRepository<Contact> repository)
	{
		public async Task<ServiceResult<GetContactByIdQueryResult>> Handle(GetContactByIdQuery query)
		{
			var contact = await repository.GetByIdAsync(query.Id);
			if (contact == null) return ServiceResult<GetContactByIdQueryResult>.Fail("Contact bulunamadı",HttpStatusCode.NotFound);
			
			var result = new GetContactByIdQueryResult(contact.Id, contact.Name, contact.Email, contact.Subject, contact.Message);
			return ServiceResult<GetContactByIdQueryResult>.Success(result);
		}

	}
}
