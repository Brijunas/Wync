using Core.Interfaces.External;
using Core.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;

namespace Infra.Services
{
    public class OpenWeatherClient(HttpClient httpClient, IConfiguration configuration) : IOpenWeatherClient
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly string _apiKey = configuration["OpenWeatherMap:ApiKey"];
        private readonly string _lat = configuration["OpenWeatherMap:Latitude"];
        private readonly string _lon = configuration["OpenWeatherMap:Longitude"];
        private readonly string _lang = configuration["OpenWeatherMap:Language"];

        public async Task<WeatherData> Fetch()
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?lat={_lat}&lon={_lon}&appid={_apiKey}&units=metric&lang={_lang}";
            var response = await _httpClient.GetFromJsonAsync<OpenWeatherResponse>(url);

            return new WeatherData
            {
                Temperature = response?.Main?.Temp ?? 0,
                Summary = response?.Weather?.FirstOrDefault()?.Description ?? "Unknown"
            };
        }
    }

    // DTOs to map OpenWeather API response
    public class OpenWeatherResponse
    {
        public MainData? Main { get; set; }
        public List<WeatherDescription>? Weather { get; set; }
    }

    public class MainData { public float Temp { get; set; } }
    public class WeatherDescription { public string? Description { get; set; } }
}
