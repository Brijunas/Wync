namespace Core.Dtos
{
    public class GetCurrentResponseWind
    {
        /// <summary>
        /// Wind speed. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        public int Deg { get; set; }

        /// <summary>
        /// Wind gust. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour
        /// </summary>
        public double? Gust { get; set; }
    }
}
