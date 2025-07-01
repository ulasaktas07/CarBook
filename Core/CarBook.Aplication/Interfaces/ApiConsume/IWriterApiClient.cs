
using CarBook.Dto.WriterDtos;

namespace CarBook.Aplication.Interfaces.ApiConsume
{
	public interface IWriterApiClient
	{
		Task<List<WriterDto>> GetWritersAsync();

		Task<CreateWriterResult> SendCreateWriterAsync(CreateWriterRequest request);

		Task<UpdateWriterRequest> GetWriteForUpdateAsync(int id);

		Task<UpdateWriterRequest> SendUpdateWriterAsync(UpdateWriterRequest request);

		Task<bool> DeleteWriterAsync(int id);


	}
}
