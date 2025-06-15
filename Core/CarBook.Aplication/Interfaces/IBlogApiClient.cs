using CarBook.Dto.BlogDtos;
using CarBook.Dto.CarDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Aplication.Interfaces
{
	public interface IBlogApiClient
	{
		Task<List<Last3BlogsWithWriterDto>> GetLast3BlogsWithWriterAsync();

	}
}
