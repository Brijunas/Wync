using Core.Interfaces;
using Core.Interfaces.External;
using Core.Dtos;

namespace App.Services
{
    public class WeatherService(IOpenWeatherClient openWeatherClient) : IWeatherService
    {
        public Task<GetCurrentResponse> GetWeatherAsync()
        {
            return openWeatherClient.GetCurrent();
        }
    }
}

