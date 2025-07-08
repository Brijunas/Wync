namespace Core.Dtos
{
    public class GetCurrentResponseWeather
    {
        /// <summary>
        /// Weather condition id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Group of weather parameters (Rain, Snow, Clouds etc.)
        /// </summary>
        public string Main { get; set; } = default!;

        /// <summary>
        /// Weather condition within the group
        /// </summary>
        public string Description { get; set; } = default!;

        /// <summary>
        /// Weather icon id
        /// </summary>
        public string Icon { get; set; } = default!;
    }
}
