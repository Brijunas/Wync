using Core.Interfaces.External;
using Core.Dtos;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;

namespace Infra.Services
{
    public class OpenWeatherClient(HttpClient httpClient, IConfiguration configuration) : IOpenWeatherClient
    {
        private readonly string _apiKey = GetConfig(configuration, "OpenWeatherMap:ApiKey");
        private readonly string _lat = GetConfig(configuration, "OpenWeatherMap:Latitude");
        private readonly string _lon = GetConfig(configuration, "OpenWeatherMap:Longitude");
        private readonly string _lang = GetConfig(configuration, "OpenWeatherMap:Language");

        public async Task<GetCurrentResponse> GetCurrent()
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?lat={_lat}&lon={_lon}&appid={_apiKey}&units=metric&lang={_lang}";
            var response = await httpClient.GetFromJsonAsync<GetCurrentResponse>(url);
            return response ?? throw new InvalidOperationException("Response was null");
        }

        private static string GetConfig(IConfiguration configuration, string key) => configuration[key] ?? throw new ArgumentNullException(nameof(key), $"{key} is missing");
    }
}
