using App.Interfaces;
using Core.Dtos;

namespace Infra.Repositories
{
    internal class OpenWeatherGetCurrentRepository : IOpenWeatherGetCurrentRepository
    {
        public Task<GetCurrentResponse> Create(GetCurrentResponse response)
        {
            throw new NotImplementedException();
        }

        public Task<GetCurrentResponse> GetLatest(DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
