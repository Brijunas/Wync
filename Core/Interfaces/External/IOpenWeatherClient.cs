using Core.Models;

namespace Core.Interfaces.External
{
    public interface IOpenWeatherClient
    {
        Task<WeatherData> FetchWeatherAsync(string city);
    }
}
