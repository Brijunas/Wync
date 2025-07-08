using App.Interfaces;
using Core.Dtos;
using Core.Interfaces;
using Core.Interfaces.External;

namespace App.Services
{
    public class OpenWeatherService(IOpenWeatherClient openWeatherClient, IOpenWeatherGetCurrentRepository repo) : IOpenWeatherService
    {
        public async Task<GetCurrentResponse> GetCurrent()
        {
            var lastHourReponse = await repo.GetLatest(DateTime.UtcNow.AddHours(-1));
            if (lastHourReponse != null)
                return lastHourReponse;

            var newResponse = await openWeatherClient.GetCurrent();
            _ = Task.Run(() => repo.Create(newResponse));

            return newResponse;
        }
    }
}

