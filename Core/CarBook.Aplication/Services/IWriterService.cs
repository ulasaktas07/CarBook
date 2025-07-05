using CarBook.Dto.WriterDtos;

namespace CarBook.Aplication.Services
{
	public interface IWriterService
	{
		Task<CreateWriterResult> CreateWriterAsync(CreateWriterRequest request);
		Task<UpdateWriterRequest> UpdateWriterAsync(UpdateWriterRequest request);
	}
}
