using Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class WeatherComService : IWeatherService
    {
        public decimal GetTemprature(string place)
        {
            switch (place.ToLower())
            {
                case "ankara":
                    return 27m;
                case "izmir":
                    return 31m;
                case "bursa":
                    return 28m;
                case "adana":
                    return 32m;

                default:
                    return new Random().Next(10,20);

            }
        }

        public decimal Temperature(string placeName)
        {
            return GetTemprature(placeName);
        }
    }
}
