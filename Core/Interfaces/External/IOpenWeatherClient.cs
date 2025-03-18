using Core.Models;

namespace Core.Interfaces.External
{
    public interface IOpenWeatherClient
    {
        Task<WeatherData> Fetch();
    }
}
