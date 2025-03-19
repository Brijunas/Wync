using Core.Utils;
using System.Text.Json.Serialization;

namespace Core.Dtos
{
    public class GetCurrentResponse
    {
        public GetCurrentResponseCoord Coord { get; set; } = default!;
        public List<GetCurrentResponseWeather> Weather { get; set; } = [];
        public string Base { get; set; } = default!;
        public GetCurrentResponseMain Main { get; set; } = default!;
        public int Visibility { get; set; }
        public GetCurrentResponseWind Wind { get; set; } = default!;
        public GetCurrentResponseDrops? Rain { get; set; }
        public GetCurrentResponseDrops? Snow { get; set; }
        public GetCurrentResponseClouds Clouds { get; set; } = default!;

        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime Dt { get; set; }

        public GetCurrentResponseSys Sys { get; set; } = default!;
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Cod { get; set; }
    }
}