namespace Core.Dtos
{
    public class GetCurrentResponseWeather
    {
        public int Id { get; set; }
        public string Main { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Icon { get; set; } = default!;
    }
}
