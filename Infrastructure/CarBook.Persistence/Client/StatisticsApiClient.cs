using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto;
using CarBook.Dto.StatisticsDtos;
using Newtonsoft.Json;

namespace CarBook.Persistence.Client
{
	public class StatisticsApiClient(IHttpClientFactory httpClientFactory) : IStatisticsApiClient
	{
		public async Task<StatiscticsDto> GetAvrgRentPriceForDailyAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetAvrgRentPriceForDaily");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetAvrgRentPriceForMonthlyAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetAvrgRentPriceForMonthly");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetAvrgRentPriceForWeeklyAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetAvrgRentPriceForWeekly");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetBlogCountAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetBlogCount");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetBlogTitleByMaxBlogCommentAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetBlogTitleByMaxBlogComment");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetBrandCountAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetBrandCount");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetBrandNameByMaxCarAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetBrandNameByMaxCar");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetCarBrandAndModelByRentPriceDailyMaxAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetCarBrandAndModelByRentPriceDailyMinAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetCarCountAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetCarCount");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();

			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();


		}

		public async Task<StatiscticsDto> GetCarCountByFuelElectricAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetCarCountByFuelElectric");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetCarCountByFuelGasolineOrDieselAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetCarCountByKmSmallerThan1000Async()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetCarCountByKmSmallerThan1000");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetCarCountByTransmissionIsAutoAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetCarCountByTransmissionIsAuto");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetLocationCountAsync()
		{
			
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetLocationCount");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}

		public async Task<StatiscticsDto> GetWriterCountAsync()
		{
			var client = httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7274/api/Statistics/GetWriterCount");
			if(!response.IsSuccessStatusCode)
				return new StatiscticsDto();
			var jsonData = await response.Content.ReadAsStringAsync();
			var apiResponse = JsonConvert.DeserializeObject<ApiIdResponse<StatiscticsDto>>(jsonData);
			return apiResponse?.Data ?? new StatiscticsDto();
		}
	}
}