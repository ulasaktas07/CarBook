using AutoMapper;
using CarBook.Aplication.Features.Mediator.Commands.WriterCommands;
using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.WriterDtos;

namespace CarBook.Persistence.Services
{
	public class WriterService(IWriterApiClient writerApiClient, IMapper mapper) : IWriterService
	{
		public async Task<CreateWriterResult> CreateWriterAsync(CreateWriterRequest request)
		{
			var command = mapper.Map<CreateWriterCommand>(request);
			return await writerApiClient.SendCreateWriterAsync(request); 	
		}

		public async Task<UpdateWriterRequest> UpdateWriterAsync(UpdateWriterRequest request)
		{
			var command = mapper.Map<UpdateWriterCommand>(request);
			return await writerApiClient.SendUpdateWriterAsync(request);
		}
	}
}
