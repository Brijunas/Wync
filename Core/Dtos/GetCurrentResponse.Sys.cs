using Core.Utils;
using System.Text.Json.Serialization;

namespace Core.Dtos
{
    public class GetCurrentResponseSys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; } = default!;

        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime Sunrise { get; set; }

        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime Sunset { get; set; }
    }
}
