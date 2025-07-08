using Core.Interfaces;
using Core.Dtos;
using FastEndpoints;

namespace Api.Endpoints
{
    public class GetWeatherEndpoint(IOpenWeatherService weatherService) : EndpointWithoutRequest<GetCurrentResponse>
    {
        public override void Configure()
        {
            Get("/weather");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var weather = await weatherService.GetCurrent();
            await SendAsync(weather, cancellation: ct);
        }
    }
}