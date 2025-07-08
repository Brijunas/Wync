using Core.Dtos;

namespace Core.Interfaces
{
    public interface IOpenWeatherService
    {
        Task<GetCurrentResponse> GetCurrent();
    }
}
