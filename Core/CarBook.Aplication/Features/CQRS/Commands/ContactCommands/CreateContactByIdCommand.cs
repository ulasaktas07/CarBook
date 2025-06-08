using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Aplication.Features.CQRS.Commands.ContactCommands
{
	public class CreateContactByIdCommand(int Id)
	{
		public int Id { get; } = Id;

	}
}
