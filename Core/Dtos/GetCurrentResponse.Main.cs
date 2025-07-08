namespace Core.Dtos
{
    public class GetCurrentResponseMain
    {
        /// <summary>
        /// Temperature
        /// </summary>
        public double Temp { get; set; }

        /// <summary>
        ///  Temperature. This temperature parameter accounts for the human perception of weather.
        /// </summary>
        public double Feels_Like { get; set; }

        /// <summary>
        /// Minimum temperature at the moment. This is minimal currently observed temperature (within large megalopolises and urban areas).
        /// </summary>
        public double Temp_Min { get; set; }

        /// <summary>
        /// Maximum temperature at the moment. This is maximal currently observed temperature (within large megalopolises and urban areas).
        /// </summary>
        public double Temp_Max { get; set; }

        /// <summary>
        ///  Atmospheric pressure on the sea level, hPa
        /// </summary>
        public int Pressure { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        public int Humidity { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        public int? Sea_Level { get; set; }

        /// <summary>
        /// Atmospheric pressure on the ground level, hPa
        /// </summary>
        public int? Grnd_Level { get; set; }
    }
}
