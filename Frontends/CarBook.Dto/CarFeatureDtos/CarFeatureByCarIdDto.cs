namespace CarBook.Dto.CarFeatureDtos
{
	public class CarFeatureByCarIdDto
	{

		public int id { get; set; }
		public int featureId { get; set; }
		public string featureName { get; set; } = default!;
		public bool available { get; set; }

	}
}
