using Core.Utils;
using System.Text.Json.Serialization;

namespace Core.Dtos
{
    public class GetCurrentResponseSys
    {
        /// <summary>
        /// Internal parameter
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Internal parameter
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Country code (GB, JP etc.)
        /// </summary>
        public string Country { get; set; } = default!;

        /// <summary>
        /// Sunrise time, unix, UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime Sunrise { get; set; }

        /// <summary>
        /// Sunset time, unix, UTC
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime Sunset { get; set; }
    }
}
