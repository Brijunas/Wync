using Core.Utils;
using System.Text.Json.Serialization;

namespace Core.Dtos
{
    public class GetCurrentResponse
    {
        public GetCurrentResponseCoord Coord { get; set; } = default!;

        public List<GetCurrentResponseWeather> Weather { get; set; } = [];

        /// <summary>
        ///  Internal parameter
        /// </summary>
        public string Base { get; set; } = default!;

        public GetCurrentResponseMain Main { get; set; } = default!;

        /// <summary>
        /// Visibility, meter. The maximum value of the visibility is 10 km
        /// </summary>
        public int Visibility { get; set; }

        public GetCurrentResponseWind Wind { get; set; } = default!;

        public GetCurrentResponseDrops? Rain { get; set; }

        public GetCurrentResponseDrops? Snow { get; set; }

        public GetCurrentResponseClouds Clouds { get; set; } = default!;

        /// <summary>
        /// Time of data calculation, unix, UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime Dt { get; set; }

        public GetCurrentResponseSys Sys { get; set; } = default!;

        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        public int Timezone { get; set; }

        /// <summary>
        ///  City ID. Please note that built-in geocoder functionality has been deprecated.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// City name. Please note that built-in geocoder functionality has been deprecated.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Internal parameter
        /// </summary>
        public int Cod { get; set; }
    }
}