using App.Services;
using Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace App
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IOpenWeatherService, OpenWeatherService>();

            return services;
        }
    }
}
