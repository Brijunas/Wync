using Core.Models;

namespace Core.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherData> GetWeatherAsync();
    }
}
