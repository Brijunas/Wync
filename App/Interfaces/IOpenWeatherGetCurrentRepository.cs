using Core.Dtos;

namespace App.Interfaces
{
    public interface IOpenWeatherGetCurrentRepository
    {
        Task<GetCurrentResponse> Create(GetCurrentResponse response);
        Task<GetCurrentResponse> GetLatest(DateTime to);
    }
}
