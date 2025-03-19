using Core.Dtos;

namespace Core.Interfaces
{
    public interface IWeatherService
    {
        Task<GetCurrentResponse> GetWeatherAsync();
    }
}
