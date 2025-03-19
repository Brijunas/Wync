using Core.Dtos;

namespace Core.Interfaces.External
{
    public interface IOpenWeatherClient
    {
        Task<GetCurrentResponse> GetCurrent();
    }
}
