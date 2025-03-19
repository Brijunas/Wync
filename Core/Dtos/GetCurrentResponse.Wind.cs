namespace Core.Dtos
{
    public class GetCurrentResponseWind
    {
        public double Speed { get; set; }
        public int Deg { get; set; }
        public double? Gust { get; set; }
    }
}
