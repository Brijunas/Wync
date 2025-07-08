using App.Interfaces;
using Core.Interfaces.External;
using Infra.Repositories;
using Infra.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IOpenWeatherClient, OpenWeatherClient>();
            services.AddScoped<IOpenWeatherGetCurrentRepository, OpenWeatherGetCurrentRepository>();
            return services;
        }
    }
}
