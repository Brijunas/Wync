using Core.Interfaces;
using Core.Interfaces.External;
using Core.Models;

namespace App.Services
{
    public class WeatherService(IOpenWeatherClient openWeatherClient) : IWeatherService
    {
        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            return await openWeatherClient.FetchWeatherAsync(city);
        }
    }
}
