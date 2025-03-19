using Core.Interfaces;
using Core.Dtos;
using FastEndpoints;

namespace Api.Endpoints
{
    public class GetWeatherEndpoint(IWeatherService weatherService) : EndpointWithoutRequest<GetCurrentResponse>
    {
        public override void Configure()
        {
            Get("/weather");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var weather = await weatherService.GetWeatherAsync();
            await SendAsync(weather, cancellation: ct);
        }
    }
}