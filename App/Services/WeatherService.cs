using Core.Interfaces;
using Core.Interfaces.External;
using Core.Models;

namespace App.Services
{
    public class WeatherService(IOpenWeatherClient openWeatherClient) : IWeatherService
    {
        public Task<WeatherData> GetWeatherAsync()
        {
            return openWeatherClient.Fetch();
        }
    }
}

