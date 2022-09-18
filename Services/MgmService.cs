using Abstractions;

namespace Services
{
	public class MgmService : IWeatherService
	{
		public decimal GetTemprature(string place)
		{
			switch (place.ToLower())
			{
				case "ankara":
					return 26.6m;
                case "izmir":
                    return 30.1m;
                case "bursa":
                    return 28.7m;
                case "adana":
                    return 31.8m;
                
                default:
					return new Random().Next(30);
					
			}
		}

		public decimal Temperature(string placeName)
		{
			return GetTemprature(placeName);
		}
	}
}